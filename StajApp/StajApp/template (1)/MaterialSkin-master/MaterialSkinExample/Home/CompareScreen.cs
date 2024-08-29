using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkinExample.FUNCTIONS.Models;
using MaterialSkinExample.FUNCTIONS.Models.CompareList;
using System.Drawing;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading;

namespace MaterialSkinExample
{
    public partial class CompareScreen : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private List<Compare_TABLES> Compare_TABLEs;
        private List<Compare_TABLES> Compare_ViewTABLEs;
        private List<Compare_TABLES> Compare_Procedures;
        private List<Compare_TABLES> Compare_Triggers;
        private Prepare_Model prepare_Models;
        public CompareScreen(Prepare_Model prepare_Model)
        {
            InitializeComponent();
            prepare_Models = prepare_Model;
            
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.Text = "Database Eşitleme";
        }
        public void PrepareDatabases(Prepare_Model prepare_Model)
        {
            prepare_Models = prepare_Model;
            Compare_TABLEs = new List<Compare_TABLES>();
            //kaynak db den tablo isimlerini çekme
            using (SqlConnection connection =
            new SqlConnection(prepare_Model.ConnectionString_SOURCE))
            {
                string qString = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(qString, connection);

                // Create and execute the DataReader..
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Compare_TABLES newrow = new Compare_TABLES();
                    newrow.SOURCE_TABLE_NAME = (string)reader[0];
                    Compare_TABLEs.Add(newrow);
                }
                connection.Close();
            }
            //hedef database ile eşleme
            using (SqlConnection connection =
            new SqlConnection(prepare_Model.ConnectionString_HREF))
            {
                string qString = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(qString, connection);

                // Create and execute the DataReader..
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var checkrow= Compare_TABLEs.Where(m => m.SOURCE_TABLE_NAME == (string)reader[0]).FirstOrDefault();
                    if(checkrow==null)
                    {
                        if(prepare_Model.FAZLASATIRLAR==true)
                        {
                            Compare_TABLES newrow = new Compare_TABLES();
                            newrow.HREF_TABLE_NAME = (string)reader[0];
                            newrow.COMPARE_STATUS = false;
                            newrow.SOURCE_TABLE_NAME = "Bulunamadı!";
                            Compare_TABLEs.Add(newrow);
                        }
                        
                    }
                    else
                    {
                        Compare_TABLEs.Where(m => m.SOURCE_TABLE_NAME == (string)reader[0]).FirstOrDefault().HREF_TABLE_NAME = (string)reader[0];
                        Compare_TABLEs.Where(m => m.SOURCE_TABLE_NAME == (string)reader[0]).FirstOrDefault().TABLE_CHECK = true;
                    }
                    
                }
                connection.Close();
            }
            List<Compare_TABLES> lastlist = new List<Compare_TABLES>();
            //kolon check
            foreach (var TABLE in Compare_TABLEs)
            {
                if(TABLE.TABLE_CHECK==true)
                {
                    //kaynak db den kolon isimlerini çekme
                    using (SqlConnection connection =
                    new SqlConnection(prepare_Model.ConnectionString_SOURCE))
                    {
                        string qString = "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'" + TABLE.SOURCE_TABLE_NAME + "'";
                        // Create the Command and Parameter objects.
                        SqlCommand command = new SqlCommand(qString, connection);

                        // Create and execute the DataReader..
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Compare_COLOUMN newrow = new Compare_COLOUMN();
                            newrow.SOURCE_COLUMNNAME = (string)reader["COLUMN_NAME"];
                            newrow.SOURCE_DATA_TYPE = (string)reader["DATA_TYPE"];
                            if (reader["CHARACTER_MAXIMUM_LENGTH"] != DBNull.Value)
                            {
                                newrow.SOURCE_CHARACTER_MAXIMUM_LENGTH = (int?)reader["CHARACTER_MAXIMUM_LENGTH"];
                            }
                            else
                            {
                                newrow.SOURCE_CHARACTER_MAXIMUM_LENGTH = null;
                            }
                            newrow.SOURCE_IS_NULLABLE = (string)reader["IS_NULLABLE"];
                            TABLE.Compare_COLOUMNs.Add(newrow);
                        }
                        connection.Close();
                    }

                    //hedef database ile eşleme
                    using (SqlConnection connection =
                    new SqlConnection(prepare_Model.ConnectionString_HREF))
                    {
                        string qString = "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'"+TABLE.HREF_TABLE_NAME+"'";
                        // Create the Command and Parameter objects.
                        SqlCommand command = new SqlCommand(qString, connection);

                        // Create and execute the DataReader..
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            var checkrow = TABLE.Compare_COLOUMNs.Where(m => m.SOURCE_COLUMNNAME == (string)reader["COLUMN_NAME"]).FirstOrDefault();
                            if (checkrow == null)
                            {
                                //fazla kolon hedef sistemde
                            }
                            else
                            {
                                TABLE.Compare_COLOUMNs.Where(m => m.SOURCE_COLUMNNAME == (string)reader["COLUMN_NAME"]).FirstOrDefault().HREF_COLUMNNAME = (string)reader["COLUMN_NAME"];
                                TABLE.Compare_COLOUMNs.Where(m => m.SOURCE_COLUMNNAME == (string)reader["COLUMN_NAME"]).FirstOrDefault().HREF_DATA_TYPE = (string)reader["DATA_TYPE"];
                                if (reader["CHARACTER_MAXIMUM_LENGTH"] != DBNull.Value)
                                {
                                    TABLE.Compare_COLOUMNs.Where(m => m.SOURCE_COLUMNNAME == (string)reader["COLUMN_NAME"]).FirstOrDefault().HREF_CHARACTER_MAXIMUM_LENGTH = (int?)reader["CHARACTER_MAXIMUM_LENGTH"];
                                }
                                else
                                {
                                    TABLE.Compare_COLOUMNs.Where(m => m.SOURCE_COLUMNNAME == (string)reader["COLUMN_NAME"]).FirstOrDefault().HREF_CHARACTER_MAXIMUM_LENGTH = null;
                                }
                                TABLE.Compare_COLOUMNs.Where(m => m.SOURCE_COLUMNNAME == (string)reader["COLUMN_NAME"]).FirstOrDefault().HREF_IS_NULLABLE = (string)reader["IS_NULLABLE"];
                                TABLE.Compare_COLOUMNs.Where(m => m.SOURCE_COLUMNNAME == (string)reader["COLUMN_NAME"]).FirstOrDefault().COLOUMN_STATUS = true;
                            }
                        }
                        connection.Close();
                    }
                    bool okey = true;
                    foreach(var colon in TABLE.Compare_COLOUMNs)
                    {
                        if(colon.HREF_COLUMNNAME=="" || colon.HREF_COLUMNNAME==null)
                        {
                            okey = false;
                        }
                    }
                    if(okey==true)
                    {
                        if(prepare_Model.ESLESENSATIRLAR==true)
                        {
                            TABLE.COLOUMN_CHECK = true;
                            lastlist.Add(TABLE);
                        }
                    }
                    else
                    {
                        TABLE.COLOUMN_CHECK = false;
                        lastlist.Add(TABLE);
                    }
                }
                else
                {
                    //kaynak db den kolon isimlerini çekme
                    using (SqlConnection connection =
                    new SqlConnection(prepare_Model.ConnectionString_SOURCE))
                    {
                        string qString = "SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'" + TABLE.SOURCE_TABLE_NAME + "'";
                        // Create the Command and Parameter objects.
                        SqlCommand command = new SqlCommand(qString, connection);

                        // Create and execute the DataReader..
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Compare_COLOUMN newrow = new Compare_COLOUMN();
                            newrow.SOURCE_COLUMNNAME = (string)reader["COLUMN_NAME"];
                            newrow.SOURCE_DATA_TYPE = (string)reader["DATA_TYPE"];
                            if (reader["CHARACTER_MAXIMUM_LENGTH"] != DBNull.Value)
                            {
                                newrow.SOURCE_CHARACTER_MAXIMUM_LENGTH = (int?)reader["CHARACTER_MAXIMUM_LENGTH"];
                            }
                            else
                            {
                                newrow.SOURCE_CHARACTER_MAXIMUM_LENGTH = null;
                            }
                            newrow.SOURCE_IS_NULLABLE = (string)reader["IS_NULLABLE"];
                            TABLE.Compare_COLOUMNs.Add(newrow);
                        }
                        connection.Close();
                    }
                    lastlist.Add(TABLE);
                }
                
            }
            Compare_TABLEs = lastlist;
            Compare_TABLEs = Compare_TABLEs.OrderBy(m => m.SOURCE_TABLE_NAME).ToList();
            COMPARE_TABLES_GRID.DataSource = Compare_TABLEs;
            COMPARE_TABLES_GRID.Columns["SOURCE_DATABASE_NAME"].Visible = false;
            COMPARE_TABLES_GRID.Columns["HREF_DATABASE_NAME"].Visible = false;
            COMPARE_TABLES_GRID.Columns["SOURCE_TABLE_NAME"].ReadOnly = true;
            COMPARE_TABLES_GRID.Columns["HREF_TABLE_NAME"].ReadOnly = true;
            COMPARE_TABLES_GRID.Columns["TABLE_CHECK"].ReadOnly = true;
            COMPARE_TABLES_GRID.Columns["COLOUMN_CHECK"].ReadOnly = true;
            COMPARE_COLUMN_GRID.Update();
            COMPARE_COLUMN_GRID.Refresh();

            loadingtxt.Visible = false;
        }
        public void PrepareDatabasesViews(Prepare_Model prepare_Model)
        {
            prepare_Models = prepare_Model;
            Compare_ViewTABLEs = new List<Compare_TABLES>();
            //kaynak db den tablo isimlerini çekme
            using (SqlConnection connection =
            new SqlConnection(prepare_Model.ConnectionString_SOURCE))
            {
                string qString = "SELECT OBJECT_SCHEMA_NAME(v.object_id) schema_name,	v.name FROM sys.views as v;";
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(qString, connection);

                // Create and execute the DataReader..
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Compare_TABLES newrow = new Compare_TABLES();
                    newrow.SOURCE_TABLE_NAME = (string)reader[1];
                    Compare_ViewTABLEs.Add(newrow);
                }
                connection.Close();
            }
            //hedef database ile eşleme
            using (SqlConnection connection =
            new SqlConnection(prepare_Model.ConnectionString_HREF))
            {
                string qString = "SELECT OBJECT_SCHEMA_NAME(v.object_id) schema_name,	v.name FROM sys.views as v;";
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(qString, connection);

                // Create and execute the DataReader..
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var checkrow = Compare_ViewTABLEs.Where(m => m.SOURCE_TABLE_NAME == (string)reader[1]).FirstOrDefault();
                    if (checkrow == null)
                    {
                        if (prepare_Model.FAZLASATIRLAR == true)
                        {
                            Compare_TABLES newrow = new Compare_TABLES();
                            newrow.HREF_TABLE_NAME = (string)reader[1];
                            newrow.COMPARE_STATUS = false;
                            newrow.SOURCE_TABLE_NAME = "Bulunamadı!";
                            Compare_ViewTABLEs.Add(newrow);
                        }

                    }
                    else
                    {
                        Compare_ViewTABLEs.Where(m => m.SOURCE_TABLE_NAME == (string)reader[1]).FirstOrDefault().HREF_TABLE_NAME = (string)reader[1];
                        Compare_ViewTABLEs.Where(m => m.SOURCE_TABLE_NAME == (string)reader[1]).FirstOrDefault().TABLE_CHECK = true;
                    }

                }
                connection.Close();
            }
            List<Compare_TABLES> lastlist = new List<Compare_TABLES>();
            //kolon check
            foreach (var TABLE in Compare_ViewTABLEs)
            {
                if (TABLE.TABLE_CHECK == true)
                {
                    //kaynak db den kolon isimlerini çekme
                    using (SqlConnection connection =
                    new SqlConnection(prepare_Model.ConnectionString_SOURCE))
                    {
                        string qString = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + TABLE.SOURCE_TABLE_NAME + "')";
                        // Create the Command and Parameter objects.
                        SqlCommand command = new SqlCommand(qString, connection);

                        // Create and execute the DataReader..
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Compare_COLOUMN newrow = new Compare_COLOUMN();
                            newrow.SOURCE_COLUMNNAME = (string)reader["name"];
                            TABLE.Compare_COLOUMNs.Add(newrow);
                        }
                        connection.Close();
                    }

                    //hedef database ile eşleme
                    using (SqlConnection connection =
                    new SqlConnection(prepare_Model.ConnectionString_HREF))
                    {
                        string qString = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + TABLE.HREF_TABLE_NAME + "')";
                        // Create the Command and Parameter objects.
                        SqlCommand command = new SqlCommand(qString, connection);

                        // Create and execute the DataReader..
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            var checkrow = TABLE.Compare_COLOUMNs.Where(m => m.SOURCE_COLUMNNAME == (string)reader["name"]).FirstOrDefault();
                            if (checkrow == null)
                            {
                                //fazla kolon hedef sistemde
                            }
                            else
                            {
                                TABLE.Compare_COLOUMNs.Where(m => m.SOURCE_COLUMNNAME == (string)reader["name"]).FirstOrDefault().HREF_COLUMNNAME = (string)reader["name"];
                                TABLE.Compare_COLOUMNs.Where(m => m.SOURCE_COLUMNNAME == (string)reader["name"]).FirstOrDefault().COLOUMN_STATUS = true;
                            }
                        }
                        connection.Close();
                    }
                    bool okey = true;
                    foreach (var colon in TABLE.Compare_COLOUMNs)
                    {
                        if (colon.HREF_COLUMNNAME == "" || colon.HREF_COLUMNNAME == null)
                        {
                            okey = false;
                        }
                    }
                    if (okey == true)
                    {
                        if (prepare_Model.ESLESENSATIRLAR == true)
                        {
                            TABLE.COLOUMN_CHECK = true;
                            lastlist.Add(TABLE);
                        }
                    }
                    else
                    {
                        TABLE.COLOUMN_CHECK = false;
                        lastlist.Add(TABLE);
                    }
                }
                else
                {
                    //kaynak db den kolon isimlerini çekme
                    using (SqlConnection connection =
                    new SqlConnection(prepare_Model.ConnectionString_SOURCE))
                    {
                        string qString = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + TABLE.SOURCE_TABLE_NAME + "')";
                        // Create the Command and Parameter objects.
                        SqlCommand command = new SqlCommand(qString, connection);

                        // Create and execute the DataReader..
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Compare_COLOUMN newrow = new Compare_COLOUMN();
                            newrow.SOURCE_COLUMNNAME = (string)reader["name"];
                            TABLE.Compare_COLOUMNs.Add(newrow);
                        }
                        connection.Close();
                    }
                    lastlist.Add(TABLE);
                }

            }
            Compare_ViewTABLEs = lastlist;
            Compare_ViewTABLEs = Compare_ViewTABLEs.OrderBy(m => m.SOURCE_TABLE_NAME).ToList();
            COMPARE_VIEWS_GRID.DataSource = Compare_ViewTABLEs;
            COMPARE_VIEWS_GRID.Columns["SOURCE_DATABASE_NAME"].Visible = false;
            COMPARE_VIEWS_GRID.Columns["HREF_DATABASE_NAME"].Visible = false;
            COMPARE_VIEWS_GRID.Columns["SOURCE_TABLE_NAME"].ReadOnly = true;
            COMPARE_VIEWS_GRID.Columns["HREF_TABLE_NAME"].ReadOnly = true;
            COMPARE_VIEWS_GRID.Columns["TABLE_CHECK"].ReadOnly = true;
            COMPARE_VIEWS_GRID.Columns["COLOUMN_CHECK"].ReadOnly = true;
            COMPARE_VIEWS_GRID.Update();
            COMPARE_VIEWS_GRID.Refresh();

            loadingtxt2.Visible = false;
        }
        public void PrepareDatabasesProcedure(Prepare_Model prepare_Model)
        {
            prepare_Models = prepare_Model;
            Compare_Procedures = new List<Compare_TABLES>();
            //kaynak db den tablo isimlerini çekme
            using (SqlConnection connection =
            new SqlConnection(prepare_Model.ConnectionString_SOURCE))
            {
                string qString = "select m.definition,o.name from sys.objects as o inner join sys.sql_modules as m on o.object_id = m.object_id where o.type = 'p'";
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(qString, connection);

                // Create and execute the DataReader..
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Compare_TABLES newrow = new Compare_TABLES();
                    newrow.SOURCE_TABLE_NAME = (string)reader[1];
                    Compare_Procedures.Add(newrow);
                }
                connection.Close();
            }
            //hedef database ile eşleme
            using (SqlConnection connection =
            new SqlConnection(prepare_Model.ConnectionString_HREF))
            {
                string qString = "select m.definition,o.name from sys.objects as o inner join sys.sql_modules as m on o.object_id = m.object_id where o.type = 'p'";
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(qString, connection);

                // Create and execute the DataReader..
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var checkrow = Compare_Procedures.Where(m => m.SOURCE_TABLE_NAME == (string)reader[1]).FirstOrDefault();
                    if (checkrow == null)
                    {
                        if (prepare_Model.FAZLASATIRLAR == true)
                        {
                            Compare_TABLES newrow = new Compare_TABLES();
                            newrow.HREF_TABLE_NAME = (string)reader[1];
                            newrow.COMPARE_STATUS = false;
                            newrow.SOURCE_TABLE_NAME = "Bulunamadı!";
                            Compare_Procedures.Add(newrow);
                        }

                    }
                    else
                    {
                        if(prepare_Model.ESLESENSATIRLAR == true)
                        {
                            Compare_Procedures.Where(m => m.SOURCE_TABLE_NAME == (string)reader[1]).FirstOrDefault().HREF_TABLE_NAME = (string)reader[1];
                            Compare_Procedures.Where(m => m.SOURCE_TABLE_NAME == (string)reader[1]).FirstOrDefault().TABLE_CHECK = true;
                        }
                        else
                        {
                            Compare_Procedures.Remove(checkrow);
                        }
                        
                    }

                }
                connection.Close();
            }

            Compare_Procedures = Compare_Procedures.OrderBy(m => m.SOURCE_TABLE_NAME).ToList();
            COMPARE_PROCEDURE_GRID.DataSource = Compare_Procedures;
            COMPARE_PROCEDURE_GRID.Columns["SOURCE_DATABASE_NAME"].Visible = false;
            COMPARE_PROCEDURE_GRID.Columns["HREF_DATABASE_NAME"].Visible = false;
            COMPARE_PROCEDURE_GRID.Columns["SOURCE_TABLE_NAME"].ReadOnly = true;
            COMPARE_PROCEDURE_GRID.Columns["HREF_TABLE_NAME"].ReadOnly = true;
            COMPARE_PROCEDURE_GRID.Columns["TABLE_CHECK"].ReadOnly = true;
            COMPARE_PROCEDURE_GRID.Columns["COLOUMN_CHECK"].ReadOnly = true;
            COMPARE_PROCEDURE_GRID.Update();
            COMPARE_PROCEDURE_GRID.Refresh();

            loadingtxt3.Visible = false;
        }
        public void PrepareDatabasesTrigger(Prepare_Model prepare_Model)
        {
            prepare_Models = prepare_Model;
            Compare_Triggers = new List<Compare_TABLES>();
            //kaynak db den tablo isimlerini çekme
            using (SqlConnection connection =
            new SqlConnection(prepare_Model.ConnectionString_SOURCE))
            {
                string qString = "select [definition],obj.name,'GO' from sys.sql_modules m inner join sys.objects obj on obj.object_id=m.object_id where obj.type = 'TR'";
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(qString, connection);

                // Create and execute the DataReader..
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Compare_TABLES newrow = new Compare_TABLES();
                    newrow.SOURCE_TABLE_NAME = (string)reader[1];
                    Compare_Triggers.Add(newrow);
                }
                connection.Close();
            }
            //hedef database ile eşleme
            using (SqlConnection connection =
            new SqlConnection(prepare_Model.ConnectionString_HREF))
            {
                string qString = "select [definition],obj.name,'GO' from sys.sql_modules m inner join sys.objects obj on obj.object_id=m.object_id where obj.type = 'TR'";
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(qString, connection);

                // Create and execute the DataReader..
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var checkrow = Compare_Triggers.Where(m => m.SOURCE_TABLE_NAME == (string)reader[1]).FirstOrDefault();
                    if (checkrow == null)
                    {
                        if (prepare_Model.FAZLASATIRLAR == true)
                        {
                            Compare_TABLES newrow = new Compare_TABLES();
                            newrow.HREF_TABLE_NAME = (string)reader[1];
                            newrow.COMPARE_STATUS = false;
                            newrow.SOURCE_TABLE_NAME = "Bulunamadı!";
                            Compare_Triggers.Add(newrow);
                        }

                    }
                    else
                    {
                        if (prepare_Model.ESLESENSATIRLAR == true)
                        {
                            Compare_Triggers.Where(m => m.SOURCE_TABLE_NAME == (string)reader[1]).FirstOrDefault().HREF_TABLE_NAME = (string)reader[1];
                            Compare_Triggers.Where(m => m.SOURCE_TABLE_NAME == (string)reader[1]).FirstOrDefault().TABLE_CHECK = true;
                        }
                        else
                        {
                            Compare_Triggers.Remove(checkrow);
                        }
                            
                    }

                }
                connection.Close();
            }

            Compare_Triggers = Compare_Triggers.OrderBy(m => m.SOURCE_TABLE_NAME).ToList();
            COMPARE_TRIGGER_GRID.DataSource = Compare_Triggers;
            COMPARE_TRIGGER_GRID.Columns["SOURCE_DATABASE_NAME"].Visible = false;
            COMPARE_TRIGGER_GRID.Columns["HREF_DATABASE_NAME"].Visible = false;
            COMPARE_TRIGGER_GRID.Columns["SOURCE_TABLE_NAME"].ReadOnly = true;
            COMPARE_TRIGGER_GRID.Columns["HREF_TABLE_NAME"].ReadOnly = true;
            COMPARE_TRIGGER_GRID.Columns["TABLE_CHECK"].ReadOnly = true;
            COMPARE_TRIGGER_GRID.Columns["COLOUMN_CHECK"].ReadOnly = true;
            COMPARE_TRIGGER_GRID.Update();
            COMPARE_TRIGGER_GRID.Refresh();

            loadingtxt4.Visible = false;
        }
        private void CompareScreen_Load(object sender, EventArgs e)
        {

        }
        private void COMPARE_TABLES_GRID_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                int currentMouseOverRow = COMPARE_TABLES_GRID.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    MenuItem item = new MenuItem();
                    item.Text = currentMouseOverRow+". Kolonları Listele";
                    item.Click += MenuItemClick;
                    m.MenuItems.Add(item);                    
                }
                m.Show(COMPARE_TABLES_GRID, new Point(e.X, e.Y));
            }
        }
        private void COMPARE_VIEWS_GRID_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                int currentMouseOverRow = COMPARE_VIEWS_GRID.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    MenuItem item = new MenuItem();
                    item.Text = currentMouseOverRow + ". Kolonları Listele";
                    item.Click += MenuItemClick2;
                    m.MenuItems.Add(item);
                }
                m.Show(COMPARE_VIEWS_GRID, new Point(e.X, e.Y));
            }
        }
        private void MenuItemClick(Object sender, System.EventArgs e)
        {
            try
            {
                var objects = (MenuItem)sender;
                if (objects.Text.Contains("Kolonları Listele"))
                {
                    int rownmbr = Convert.ToInt32(objects.Text.ToString().Split('.')[0]);
                    var row = COMPARE_TABLES_GRID.Rows[rownmbr];
                    if (row != null)
                    {
                        var checkTableClass = Compare_TABLEs.Where(m => m.SOURCE_TABLE_NAME == (string)row.Cells["SOURCE_TABLE_NAME"].Value).FirstOrDefault();
                        if (checkTableClass != null)
                        {
                            COMPARE_COLUMN_GRID.DataSource = checkTableClass.Compare_COLOUMNs;
                            COMPARE_COLUMN_GRID.Update();
                            COMPARE_COLUMN_GRID.Refresh();
                            foreach (DataGridViewRow rows in COMPARE_COLUMN_GRID.Rows)
                            {
                                if (rows.Cells["COLOUMN_STATUS"].Value == null || (bool)rows.Cells["COLOUMN_STATUS"].Value == false)
                                {
                                    COMPARE_COLUMN_GRID.Rows[rows.Index].DefaultCellStyle.BackColor = Color.OrangeRed;
                                }
                            }
                            
                            
                        }

                    }
                }
            }
            catch(Exception Ex)
            {

            }            
        }
        private void MenuItemClick2(Object sender, System.EventArgs e)
        {
            try
            {
                var objects = (MenuItem)sender;
                if (objects.Text.Contains("Kolonları Listele"))
                {
                    int rownmbr = Convert.ToInt32(objects.Text.ToString().Split('.')[0]);
                    var row = COMPARE_VIEWS_GRID.Rows[rownmbr];
                    if (row != null)
                    {
                        var checkTableClass = Compare_ViewTABLEs.Where(m => m.SOURCE_TABLE_NAME == (string)row.Cells["SOURCE_TABLE_NAME"].Value).FirstOrDefault();
                        if (checkTableClass != null)
                        {
                            COMPARE_VIEWCOLUMN_GRID.DataSource = checkTableClass.Compare_COLOUMNs;
                            COMPARE_VIEWCOLUMN_GRID.Columns["SOURCE_IS_NULLABLE"].Visible = false;
                            COMPARE_VIEWCOLUMN_GRID.Columns["SOURCE_DATA_TYPE"].Visible = false;
                            COMPARE_VIEWCOLUMN_GRID.Columns["SOURCE_CHARACTER_MAXIMUM_LENGTH"].Visible = false;
                            COMPARE_VIEWCOLUMN_GRID.Columns["HREF_IS_NULLABLE"].Visible = false;
                            COMPARE_VIEWCOLUMN_GRID.Columns["HREF_DATA_TYPE"].Visible = false;
                            COMPARE_VIEWCOLUMN_GRID.Columns["HREF_CHARACTER_MAXIMUM_LENGTH"].Visible = false;
                            COMPARE_VIEWCOLUMN_GRID.Columns["SOURCE_COLUMNNAME"].ReadOnly = true;
                            COMPARE_VIEWCOLUMN_GRID.Columns["HREF_COLUMNNAME"].ReadOnly = true;
                            COMPARE_VIEWCOLUMN_GRID.Columns["SOURCE_DATA_TYPE"].ReadOnly = true;
                            COMPARE_VIEWCOLUMN_GRID.Columns["HREF_DATA_TYPE"].ReadOnly = true;
                            COMPARE_VIEWCOLUMN_GRID.Columns["COLOUMN_STATUS"].ReadOnly = true;
                            COMPARE_VIEWCOLUMN_GRID.Update();
                            COMPARE_VIEWCOLUMN_GRID.Refresh();
                            foreach (DataGridViewRow rows in COMPARE_VIEWCOLUMN_GRID.Rows)
                            {
                                if (rows.Cells["COLOUMN_STATUS"].Value == null || (bool)rows.Cells["COLOUMN_STATUS"].Value == false)
                                {
                                    COMPARE_VIEWCOLUMN_GRID.Rows[rows.Index].DefaultCellStyle.BackColor = Color.OrangeRed;
                                }
                            }


                        }

                    }
                }
            }
            catch (Exception Ex)
            {

            }
        }
        private void RowColored(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if(COMPARE_TABLES_GRID.Rows.Count>0)
            {
                if (COMPARE_TABLES_GRID.Rows[e.RowIndex].Cells["TABLE_CHECK"].Value == null || (bool)COMPARE_TABLES_GRID.Rows[e.RowIndex].Cells["TABLE_CHECK"].Value == false)
                {
                    COMPARE_TABLES_GRID.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.OrangeRed;
                }
                else if(COMPARE_TABLES_GRID.Rows[e.RowIndex].Cells["COLOUMN_CHECK"].Value == null || (bool)COMPARE_TABLES_GRID.Rows[e.RowIndex].Cells["COLOUMN_CHECK"].Value == false)
                {
                    COMPARE_TABLES_GRID.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
                }
            }
            
        }
        private void RowColored2(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (COMPARE_VIEWS_GRID.Rows.Count > 0)
            {
                if (COMPARE_VIEWS_GRID.Rows[e.RowIndex].Cells["TABLE_CHECK"].Value == null || (bool)COMPARE_VIEWS_GRID.Rows[e.RowIndex].Cells["TABLE_CHECK"].Value == false)
                {
                    COMPARE_VIEWS_GRID.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.OrangeRed;
                }
                else if (COMPARE_VIEWS_GRID.Rows[e.RowIndex].Cells["COLOUMN_CHECK"].Value == null || (bool)COMPARE_VIEWS_GRID.Rows[e.RowIndex].Cells["COLOUMN_CHECK"].Value == false)
                {
                    COMPARE_VIEWS_GRID.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
                }
            }

        }
        private void RowColored3(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (COMPARE_PROCEDURE_GRID.Rows.Count > 0)
            {
                if (COMPARE_PROCEDURE_GRID.Rows[e.RowIndex].Cells["TABLE_CHECK"].Value == null || (bool)COMPARE_PROCEDURE_GRID.Rows[e.RowIndex].Cells["TABLE_CHECK"].Value == false)
                {
                    COMPARE_PROCEDURE_GRID.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.OrangeRed;
                }                
            }

        }
        private void RowColored4(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (COMPARE_TRIGGER_GRID.Rows.Count > 0)
            {
                if (COMPARE_TRIGGER_GRID.Rows[e.RowIndex].Cells["TABLE_CHECK"].Value == null || (bool)COMPARE_TRIGGER_GRID.Rows[e.RowIndex].Cells["TABLE_CHECK"].Value == false)
                {
                    COMPARE_TRIGGER_GRID.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.OrangeRed;
                }                
            }

        }
        private void exit_Click(object sender, EventArgs e)
        {
            var m = new PrepareData();
            m.Show();
            this.Hide();
        }
        private void TableSelectAll_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in COMPARE_TABLES_GRID.Rows)
            {
                row.Cells["COMPARE_STATUS"].Value = true;
            }
        }
        private void Start_Compare_Click(object sender, EventArgs e)
        {
            StartTableCompare(100);
            StartViewCompare(100);
            StartProcedureCompare(100);
            StartTriggerCompare(100);
        }
        public string GetCreatePK_Query(string cnn,string table)
        {
            string snc = "";
            string sql = "select C.COLUMN_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS T JOIN INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE C ON C.CONSTRAINT_NAME = T.CONSTRAINT_NAME WHERE " +
                "C.TABLE_NAME = '"+ table + "' and T.CONSTRAINT_TYPE = 'PRIMARY KEY'";
            List<string> PKCOLUMNS = new List<string>();
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(cnn))
                {
                    // Create the Command and Parameter objects.
                    SqlCommand command = new SqlCommand(sql, connection);

                    // Create and execute the DataReader..
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader[0].ToString() != null)
                        {
                            PKCOLUMNS.Add(reader[0].ToString());
                        }
                    }
                    connection.Close();
                }
                if (PKCOLUMNS.Count() > 0)
                {
                    snc = "CONSTRAINT PK_" + table + " PRIMARY KEY (";
                    foreach (string col in PKCOLUMNS)
                    {
                        snc += col + ",";
                    }
                    snc = snc.Remove(snc.Length - 1, 1);
                    snc += ")";
                }
                return snc;
            }
            catch
            {
                return snc;
            }            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            loadingtxt2.Visible = true;
            MessageBox.Show("Hedef ve Kaynak Veritabanı Karşılaştırılacak bu işlem birkaç dakika sürecektir!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);          
            PrepareDatabasesViews(prepare_Models);
        }
        private void button1_ClickAsync(object sender, EventArgs e)
        {
            loadingtxt.Visible = true;
            MessageBox.Show("Hedef ve Kaynak Veritabanı Karşılaştırılacak bu işlem birkaç dakika sürecektir!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);            
            PrepareDatabases(prepare_Models);
        }

        public string StartTableCompare(int? type)
        {
            string BIGSQL = "";
            foreach (DataGridViewRow row in COMPARE_TABLES_GRID.Rows)
            {
                if ((bool)row.Cells["COMPARE_STATUS"].Value == true)
                {
                    if ((bool)row.Cells["TABLE_CHECK"].Value != true)
                    {
                        //hedef içerisinde yok
                        var TABLE = Compare_TABLEs.Where(m => m.SOURCE_TABLE_NAME == row.Cells["SOURCE_TABLE_NAME"].Value.ToString()).FirstOrDefault();
                        if (TABLE != null)
                        {
                            //tablo oluşturma ve kolonları ekleme
                            string SQLQUERY = "CREATE TABLE " + TABLE.SOURCE_TABLE_NAME + "(";
                            foreach (var col in TABLE.Compare_COLOUMNs)
                            {
                                if (col.HREF_IS_NULLABLE == "NO")
                                {
                                    if (col.SOURCE_CHARACTER_MAXIMUM_LENGTH != null && col.SOURCE_CHARACTER_MAXIMUM_LENGTH > 0 && col.SOURCE_DATA_TYPE != "image" && col.SOURCE_CHARACTER_MAXIMUM_LENGTH < 8000)
                                    {
                                        SQLQUERY += col.SOURCE_COLUMNNAME + " " + col.SOURCE_DATA_TYPE + "(" + col.SOURCE_CHARACTER_MAXIMUM_LENGTH.ToString() + ") NOT NULL,";
                                    }
                                    else
                                    {
                                        SQLQUERY += col.SOURCE_COLUMNNAME + " " + col.SOURCE_DATA_TYPE + " NOT NULL,";
                                    }
                                }
                                else
                                {
                                    if (col.SOURCE_CHARACTER_MAXIMUM_LENGTH != null && col.SOURCE_CHARACTER_MAXIMUM_LENGTH > 0 && col.SOURCE_DATA_TYPE != "image" && col.SOURCE_CHARACTER_MAXIMUM_LENGTH < 8000)
                                    {
                                        SQLQUERY += col.SOURCE_COLUMNNAME + " " + col.SOURCE_DATA_TYPE + "(" + col.SOURCE_CHARACTER_MAXIMUM_LENGTH.ToString() + "),";
                                    }
                                    else
                                    {
                                        SQLQUERY += col.SOURCE_COLUMNNAME + " " + col.SOURCE_DATA_TYPE + ",";
                                    }
                                }


                            }
                            SQLQUERY = SQLQUERY.Remove(SQLQUERY.Length - 1, 1);
                            string pk = GetCreatePK_Query(prepare_Models.ConnectionString_SOURCE, TABLE.SOURCE_TABLE_NAME);
                            if (pk != "")
                            {
                                SQLQUERY += "," + pk;
                            }
                            SQLQUERY = SQLQUERY + ")";
                            BIGSQL += " \n\r" + SQLQUERY;
                        }
                    }
                    else
                    {
                        //tablo sistemde açık
                        if (row.Cells["COLOUMN_CHECK"].Value == null || (bool)row.Cells["COLOUMN_CHECK"].Value == false)
                        {
                            //kolonlar eşleşmemiş
                            var TABLE = Compare_TABLEs.Where(m => m.SOURCE_TABLE_NAME == row.Cells["SOURCE_TABLE_NAME"].Value.ToString()).FirstOrDefault();
                            if (TABLE != null)
                            {
                                string SQLQUERY = "ALTER TABLE " + TABLE.SOURCE_TABLE_NAME + " ADD ";
                                foreach (var col in TABLE.Compare_COLOUMNs.Where(m => m.COLOUMN_STATUS == false).ToList())
                                {
                                    if (col.HREF_IS_NULLABLE == "NO")
                                    {
                                        if (col.SOURCE_CHARACTER_MAXIMUM_LENGTH != null && col.SOURCE_CHARACTER_MAXIMUM_LENGTH > 0 && col.SOURCE_DATA_TYPE != "image" && col.SOURCE_CHARACTER_MAXIMUM_LENGTH < 8000)
                                        {
                                            SQLQUERY += col.SOURCE_COLUMNNAME + " " + col.SOURCE_DATA_TYPE + "(" + col.SOURCE_CHARACTER_MAXIMUM_LENGTH.ToString() + ") NOT NULL,";
                                        }
                                        else
                                        {
                                            SQLQUERY += col.SOURCE_COLUMNNAME + " " + col.SOURCE_DATA_TYPE + " NOT NULL,";
                                        }
                                    }
                                    else
                                    {
                                        if (col.SOURCE_CHARACTER_MAXIMUM_LENGTH != null && col.SOURCE_CHARACTER_MAXIMUM_LENGTH > 0 && col.SOURCE_DATA_TYPE != "image" && col.SOURCE_CHARACTER_MAXIMUM_LENGTH < 8000)
                                        {
                                            SQLQUERY += col.SOURCE_COLUMNNAME + " " + col.SOURCE_DATA_TYPE + "(" + col.SOURCE_CHARACTER_MAXIMUM_LENGTH.ToString() + "),";
                                        }
                                        else
                                        {
                                            SQLQUERY += col.SOURCE_COLUMNNAME + " " + col.SOURCE_DATA_TYPE + ",";
                                        }
                                    }
                                }
                                SQLQUERY = SQLQUERY.Remove(SQLQUERY.Length - 1, 1);
                                BIGSQL += " \n\r" + SQLQUERY;
                            }


                        }
                    }
                }

            }
            if (BIGSQL != "")
            {
                if(type==100)
                {
                    try
                    {
                        //hedef db de güncelleme yap
                        using (SqlConnection connection =
                        new SqlConnection(prepare_Models.ConnectionString_HREF))
                        {
                            // Create the Command and Parameter objects.
                            SqlCommand command = new SqlCommand(BIGSQL, connection);

                            // Create and execute the DataReader..
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                        MessageBox.Show("Tablolar oluşturuldu!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Refresh();
                        Application.DoEvents();
                        return "ok";
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Tablolar oluşturulmadı ! Hata :" + Ex.ToString(), "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return BIGSQL;
                }
                

            }
            return " ";
        }
        public string StartViewCompare(int? type)
        {
            string BIGSQL = "";
            foreach (DataGridViewRow row in COMPARE_VIEWS_GRID.Rows)
            {
                if ((bool)row.Cells["COMPARE_STATUS"].Value == true)
                {
                    //önce view i drop etme
                    //drop sql  DROP VIEW [IF EXISTS] schema_name.view_name;
                    if ((bool)row.Cells["TABLE_CHECK"].Value != true)
                    {
                        //hedef içerisinde yok
                        var TABLE = Compare_ViewTABLEs.Where(m => m.SOURCE_TABLE_NAME == row.Cells["SOURCE_TABLE_NAME"].Value.ToString()).FirstOrDefault();
                        if (TABLE != null)
                        {
                            string createkomutu = "";
                            using (SqlConnection connection = new SqlConnection(prepare_Models.ConnectionString_SOURCE))
                            {
                                string qString = "SELECt c.TEXT FROM sysobjects o join syscomments c ON c.id = o.id WHERE o.NAME = '"+ TABLE.SOURCE_TABLE_NAME+ "' and o.type = 'V'";
                                SqlCommand command = new SqlCommand(qString, connection);
                                connection.Open();
                                SqlDataReader reader = command.ExecuteReader();
                                while (reader.Read())
                                {
                                    createkomutu = (string)reader[0];
                                }
                                connection.Close();
                            }
                            if(createkomutu!="")
                            {
                                BIGSQL += " \n\r EXECUTE('" + createkomutu+ "') ";
                            }
                            
                        }
                    }
                    else
                    {
                        //tablo sistemde açık önce drop sonra ekleme
                        var TABLE = Compare_ViewTABLEs.Where(m => m.SOURCE_TABLE_NAME == row.Cells["SOURCE_TABLE_NAME"].Value.ToString()).FirstOrDefault();
                        if(TABLE!=null)
                        {
                            string dropsql = "DROP VIEW "+TABLE.HREF_TABLE_NAME;
                            string createkomutu = "";
                            using (SqlConnection connection = new SqlConnection(prepare_Models.ConnectionString_SOURCE))
                            {
                                string qString = "SELECt c.TEXT FROM sysobjects o join syscomments c ON c.id = o.id WHERE o.NAME = '" + TABLE.SOURCE_TABLE_NAME + "' and o.type = 'V'";
                                SqlCommand command = new SqlCommand(qString, connection);
                                connection.Open();
                                SqlDataReader reader = command.ExecuteReader();
                                while (reader.Read())
                                {
                                    createkomutu = (string)reader[0];
                                }
                                connection.Close();
                            }
                            if (createkomutu != "")
                            {
                                BIGSQL += " \n\r" + dropsql+ " \n\r EXECUTE('" + createkomutu+ "') ";
                            }
                        }
                        
                        
                    }
                }
            }
            if (BIGSQL != "")
            {
                
                if (type == 100)
                {
                    try
                    {
                        //hedef db de güncelleme yap
                        using (SqlConnection connection =
                        new SqlConnection(prepare_Models.ConnectionString_HREF))
                        {
                            // Create the Command and Parameter objects.
                            SqlCommand command = new SqlCommand(BIGSQL, connection);

                            // Create and execute the DataReader..
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                        MessageBox.Show("Viewlar oluşturuldu!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Refresh();
                        Application.DoEvents();
                        return "ok";
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Viewlar oluşturulmadı ! Hata :" + Ex.ToString(), "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return BIGSQL;
                }


            }
            return " ";
        }
        public string StartProcedureCompare(int? type)
        {
            List<string> BIGSQL = new List<string>();
            foreach (DataGridViewRow row in COMPARE_PROCEDURE_GRID.Rows)
            {
                if ((bool)row.Cells["COMPARE_STATUS"].Value == true)
                {
                    //önce view i drop etme
                    //drop sql  DROP VIEW [IF EXISTS] schema_name.view_name;
                    if ((bool)row.Cells["TABLE_CHECK"].Value != true)
                    {
                        //hedef içerisinde yok
                        var TABLE = Compare_Procedures.Where(m => m.SOURCE_TABLE_NAME == row.Cells["SOURCE_TABLE_NAME"].Value.ToString()).FirstOrDefault();
                        if (TABLE != null)
                        {
                            string createkomutu = "";
                            using (SqlConnection connection = new SqlConnection(prepare_Models.ConnectionString_SOURCE))
                            {
                                string qString = "select m.definition,o.name from sys.objects as o inner join sys.sql_modules as m on o.object_id = m.object_id where o.type = 'p' AND o.name='"+ TABLE.SOURCE_TABLE_NAME + "'";
                                SqlCommand command = new SqlCommand(qString, connection);
                                connection.Open();
                                SqlDataReader reader = command.ExecuteReader();
                                while (reader.Read())
                                {
                                    if(reader[0]!=null)
                                    {
                                        if ((string)reader[0] != "")
                                        {
                                            createkomutu = (string)reader[0];
                                        }
                                    }
                                    
                                   
                                }
                                connection.Close();
                            }
                            if (createkomutu != "")
                            {
                                BIGSQL.Add( " \n\r" + createkomutu+" ");
                            }

                        }
                    }
                    else
                    {
                        //tablo sistemde açık önce drop sonra ekleme
                        var TABLE = Compare_Procedures.Where(m => m.SOURCE_TABLE_NAME == row.Cells["SOURCE_TABLE_NAME"].Value.ToString()).FirstOrDefault();
                        if (TABLE != null)
                        {
                            string dropsql = "DROP PROCEDURE " + TABLE.HREF_TABLE_NAME;
                            string createkomutu = "";
                            using (SqlConnection connection = new SqlConnection(prepare_Models.ConnectionString_SOURCE))
                            {
                                string qString = "select m.definition,o.name from sys.objects as o inner join sys.sql_modules as m on o.object_id = m.object_id where o.type = 'p' AND o.name='" + TABLE.SOURCE_TABLE_NAME + "'";
                                SqlCommand command = new SqlCommand(qString, connection);
                                connection.Open();
                                SqlDataReader reader = command.ExecuteReader();
                                while (reader.Read())
                                {
                                    if (reader[0] != null)
                                    {
                                        if ((string)reader[0] != "")
                                        {
                                            createkomutu = (string)reader[0];
                                        }
                                    }
                                        

                                }
                                connection.Close();
                            }
                            if (createkomutu != "")
                            {
                                BIGSQL.Add(" " + dropsql + " \n\r" + createkomutu + " ");
                            }
                        }


                    }
                }
            }
            if (BIGSQL.Count()>0)
            {
                string returnsql = "";
                bool snc = true;
                foreach (string BIGSQLs in BIGSQL)
                {
                    if (type == 100)
                    {
                        try
                        {
                            //hedef db de güncelleme yap
                            using (SqlConnection connection =
                            new SqlConnection(prepare_Models.ConnectionString_HREF))
                            {
                                // Create the Command and Parameter objects.
                                SqlCommand command = new SqlCommand(BIGSQLs, connection);

                                // Create and execute the DataReader..
                                connection.Open();
                                command.ExecuteNonQuery();
                                connection.Close();
                            }
                            
                        }
                        catch (Exception Ex)
                        {
                            snc = false;
                            MessageBox.Show("Procedur'ler oluşturulmadı ! Hata :" + Ex.ToString(), "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        returnsql += " "+ BIGSQLs;
                    }
                }
                if(type!=100)
                {
                    return returnsql;
                }
                else
                {
                    MessageBox.Show("Procedurler oluşturuldu!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Refresh();
                    Application.DoEvents();
                    return "ok";
                }
                //BIGSQL = BIGSQL.Replace("\n", " ").Replace("\r", " ");
                


            }
            return " ";
        }
        public string StartTriggerCompare(int? type)
        {
            List<string> BIGSQL = new List<string>();
            foreach (DataGridViewRow row in COMPARE_TRIGGER_GRID.Rows)
            {
                if ((bool)row.Cells["COMPARE_STATUS"].Value == true)
                {
                    //önce view i drop etme
                    //drop sql  DROP VIEW [IF EXISTS] schema_name.view_name;
                    if ((bool)row.Cells["TABLE_CHECK"].Value != true)
                    {
                        //hedef içerisinde yok
                        var TABLE = Compare_Triggers.Where(m => m.SOURCE_TABLE_NAME == row.Cells["SOURCE_TABLE_NAME"].Value.ToString()).FirstOrDefault();
                        if (TABLE != null)
                        {
                            string createkomutu = "";
                            using (SqlConnection connection = new SqlConnection(prepare_Models.ConnectionString_SOURCE))
                            {
                                string qString = "select [definition],obj.name,'GO' from sys.sql_modules m inner join sys.objects obj on obj.object_id=m.object_id where obj.type = 'TR' AND obj.name='" + TABLE.SOURCE_TABLE_NAME + "'";
                                SqlCommand command = new SqlCommand(qString, connection);
                                connection.Open();
                                SqlDataReader reader = command.ExecuteReader();
                                while (reader.Read())
                                {
                                    if (reader[0] != null)
                                    {
                                        if ((string)reader[0] != "")
                                        {
                                            createkomutu = (string)reader[0];
                                        }
                                    }
                                        

                                }
                                connection.Close();
                            }
                            if (createkomutu != "")
                            {
                                BIGSQL.Add(" \n\r" + createkomutu + " ");
                            }

                        }
                    }
                    else
                    {
                        //tablo sistemde açık önce drop sonra ekleme
                        var TABLE = Compare_Triggers.Where(m => m.SOURCE_TABLE_NAME == row.Cells["SOURCE_TABLE_NAME"].Value.ToString()).FirstOrDefault();
                        if (TABLE != null)
                        {
                            string dropsql = "DROP TRIGGER [IF EXISTS] " + TABLE.HREF_TABLE_NAME + ";";
                            string createkomutu = "";
                            using (SqlConnection connection = new SqlConnection(prepare_Models.ConnectionString_SOURCE))
                            {
                                string qString = "select [definition],obj.name,'GO' from sys.sql_modules m inner join sys.objects obj on obj.object_id=m.object_id where obj.type = 'TR' AND obj.name='" + TABLE.SOURCE_TABLE_NAME + "'";
                                SqlCommand command = new SqlCommand(qString, connection);
                                connection.Open();
                                SqlDataReader reader = command.ExecuteReader();
                                while (reader.Read())
                                {
                                    if (reader[0] != null)
                                    {
                                        if ((string)reader[0] != "")
                                        {
                                            createkomutu = (string)reader[0];
                                        }
                                    }
                                        

                                }
                                connection.Close();
                            }
                            if (createkomutu != "")
                            {
                                BIGSQL.Add(" " + dropsql + " \n\r" + createkomutu + " ");
                            }
                        }


                    }
                }
            }
            if (BIGSQL.Count() > 0)
            {
                string returnsql = "";
                bool snc = true;
                foreach (string BIGSQLs in BIGSQL)
                {
                    if (type == 100)
                    {
                        try
                        {
                            //hedef db de güncelleme yap
                            using (SqlConnection connection =
                            new SqlConnection(prepare_Models.ConnectionString_HREF))
                            {
                                // Create the Command and Parameter objects.
                                SqlCommand command = new SqlCommand(BIGSQLs, connection);

                                // Create and execute the DataReader..
                                connection.Open();
                                command.ExecuteNonQuery();
                                connection.Close();
                            }

                        }
                        catch (Exception Ex)
                        {
                            snc = false;
                            MessageBox.Show("Procedur'ler oluşturulmadı ! Hata :" + Ex.ToString(), "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        returnsql += " " + BIGSQLs;
                    }
                }
                if (type != 100)
                {
                    return returnsql;
                }
                else
                {
                    MessageBox.Show("Procedurler oluşturuldu!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Refresh();
                    Application.DoEvents();
                    return "ok";
                }
            }
            //if (BIGSQL != "")
            //{
            //    BIGSQL = BIGSQL.Replace("\n", " ").Replace("\r", " ");
            //    if (type == 100)
            //    {
            //        try
            //        {
            //            //hedef db de güncelleme yap
            //            using (SqlConnection connection =
            //            new SqlConnection(prepare_Models.ConnectionString_HREF))
            //            {
            //                // Create the Command and Parameter objects.
            //                SqlCommand command = new SqlCommand(BIGSQL, connection);

            //                // Create and execute the DataReader..
            //                connection.Open();
            //                command.ExecuteNonQuery();
            //                connection.Close();
            //            }
            //            MessageBox.Show("Trigger'lar oluşturuldu!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            this.Refresh();
            //            Application.DoEvents();
            //            return "ok";
            //        }
            //        catch (Exception Ex)
            //        {
            //            MessageBox.Show("Trigger'lar oluşturulmadı ! Hata :" + Ex.ToString(), "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    else
            //    {
            //        return BIGSQL;
            //    }


            //}
            return " ";
        }
        private void outsqltextbtn_Click(object sender, EventArgs e)
        {
            sqlouttext.Text = "";
            string sql=StartTableCompare(101);
            if(sql!=null && sql!="")
            {
                sqlouttext.Text +=" " + sql;
            }
            string sql2 = StartViewCompare(101);
            if (sql2 != null && sql2 != "")
            {
                sqlouttext.Text += " " + sql2;
            }
            string sql3 = StartProcedureCompare(101);
            if (sql3 != null && sql3 != "")
            {
                sqlouttext.Text += " " + sql3;
            }
            string sql4=StartTriggerCompare(101);
            if (sql4 != null && sql4 != "")
            {
                sqlouttext.Text += " " + sql4;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadingtxt3.Visible = true;
            MessageBox.Show("Hedef ve Kaynak Veritabanı Karşılaştırılacak bu işlem birkaç dakika sürecektir!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PrepareDatabasesProcedure(prepare_Models);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadingtxt4.Visible = true;
            MessageBox.Show("Hedef ve Kaynak Veritabanı Karşılaştırılacak bu işlem birkaç dakika sürecektir!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PrepareDatabasesTrigger(prepare_Models);
        }

        private void COMPARE_TABLES_GRID_sec_Click(object sender, EventArgs e)
        {
            COMPARE_TABLES_GRID_kaldir.Visible = true;
            COMPARE_TABLES_GRID_sec.Visible = false;
            foreach (DataGridViewRow row in COMPARE_TABLES_GRID.Rows)
            {
                row.Cells["COMPARE_STATUS"].Value = true;
            }
        }

        private void COMPARE_VIEWS_GRID_sec_Click(object sender, EventArgs e)
        {
            COMPARE_VIEWS_GRID_kaldir.Visible = true;
            COMPARE_VIEWS_GRID_sec.Visible = false;
            foreach (DataGridViewRow row in COMPARE_VIEWS_GRID.Rows)
            {
                row.Cells["COMPARE_STATUS"].Value = true;
            }
        }

        private void COMPARE_PROCEDURE_GRID_sec_Click(object sender, EventArgs e)
        {
            COMPARE_PROCEDURE_GRID_kaldir.Visible = true;
            COMPARE_PROCEDURE_GRID_sec.Visible = false;
            foreach (DataGridViewRow row in COMPARE_PROCEDURE_GRID.Rows)
            {
                row.Cells["COMPARE_STATUS"].Value = true;
            }
        }

        private void COMPARE_TRIGGER_GRID_sec_Click(object sender, EventArgs e)
        {
            COMPARE_TRIGGER_GRID_kaldir.Visible = true;
            COMPARE_TRIGGER_GRID_sec.Visible = false;
            foreach (DataGridViewRow row in COMPARE_TRIGGER_GRID.Rows)
            {
                row.Cells["COMPARE_STATUS"].Value = true;
            }
        }

        private void COMPARE_TABLES_GRID_kaldir_Click(object sender, EventArgs e)
        {
            COMPARE_TABLES_GRID_kaldir.Visible = false;
            COMPARE_TABLES_GRID_sec.Visible = true;
            foreach (DataGridViewRow row in COMPARE_TABLES_GRID.Rows)
            {
                row.Cells["COMPARE_STATUS"].Value = false;
            }
        }

        private void COMPARE_VIEWS_GRID_kaldir_Click(object sender, EventArgs e)
        {
            COMPARE_VIEWS_GRID_kaldir.Visible = false;
            COMPARE_VIEWS_GRID_sec.Visible = true;
            foreach (DataGridViewRow row in COMPARE_VIEWS_GRID.Rows)
            {
                row.Cells["COMPARE_STATUS"].Value = false;
            }
        }

        private void COMPARE_PROCEDURE_GRID_kaldir_Click(object sender, EventArgs e)
        {
            COMPARE_PROCEDURE_GRID_kaldir.Visible = false;
            COMPARE_PROCEDURE_GRID_sec.Visible = true;
            foreach (DataGridViewRow row in COMPARE_PROCEDURE_GRID.Rows)
            {
                row.Cells["COMPARE_STATUS"].Value = false;
            }
        }

        private void COMPARE_TRIGGER_GRID_kaldir_Click(object sender, EventArgs e)
        {
            COMPARE_TRIGGER_GRID_kaldir.Visible = false;
            COMPARE_TRIGGER_GRID_sec.Visible = true;
            foreach (DataGridViewRow row in COMPARE_TRIGGER_GRID.Rows)
            {
                row.Cells["COMPARE_STATUS"].Value = false;
            }
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
