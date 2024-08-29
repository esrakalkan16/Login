using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Web.Configuration;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkinExample.FUNCTIONS.Models;
using MaterialSkinExample.RDSPORTAL_Model;

namespace MaterialSkinExample
{
    public partial class PrepareData : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private static readonly FUNCTIONS.Models.Prepare_Model prepare_Model = new FUNCTIONS.Models.Prepare_Model();
        public PrepareData()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Prepare_Model model = GetDBConnectionTxt();
            kaynaksrv.Text = model.SOURCE_SERVER;
            kaynakuser.Text = model.SOURCE_USER;
            kaynakpass.Text = model.SOURCE_PASS;
            kaynakdb.Text = model.SOURCE_DB;
            hedefsrv.Text = model.HREF_SERVER;
            hedefuser.Text = model.HREF_USER;
            hedefpass.Text = model.HREF_PASS;
            hedefdb.Text = model.HREF_DB;
            this.Text = "Kaynak ve Hedef Belirleme";
        }
        public Prepare_Model GetDBConnectionTxt()
        {
            try
            {
                Prepare_Model model = new Prepare_Model();
                string path = AppDomain.CurrentDomain.BaseDirectory + "SqlTemplate.txt";
                if(File.Exists(path))
                {
                    string[] lines = System.IO.File.ReadAllLines(path);
                    foreach (string line in lines)
                    {
                        string alan = line.Split('=')[0];
                        string translatefield = line.Split('=')[1];
                        if (alan == "SOURCE_SERVER")
                        {
                            model.SOURCE_SERVER = translatefield;
                        }
                        else if(alan == "SOURCE_USER")
                        {
                            model.SOURCE_USER = translatefield;
                        }
                        else if (alan == "SOURCE_PASS")
                        {
                            model.SOURCE_PASS = translatefield;
                        }
                        else if (alan == "SOURCE_DB")
                        {
                            model.SOURCE_DB = translatefield;
                        }
                        else if (alan == "HREF_SERVER")
                        {
                            model.HREF_SERVER = translatefield;
                        }
                        else if (alan == "HREF_USER")
                        {
                            model.HREF_USER = translatefield;
                        }
                        else if (alan == "HREF_PASS")
                        {
                            model.HREF_PASS = translatefield;
                        }
                        else if (alan == "HREF_DB")
                        {
                            model.HREF_DB = translatefield;
                        }
                    }
                    return model;
                }
                return model;
            }
            catch
            {
                return new Prepare_Model();
            }
        }
        public void SetDBConnectionTxt(Prepare_Model model)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "SqlTemplate.txt";
            if(File.Exists(path))
            {
                //dosya mevcut
                File.Delete(path);
                //dosya oluştur
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine("SOURCE_SERVER=" + model.SOURCE_SERVER);
                    tw.WriteLine("SOURCE_USER=" + model.SOURCE_USER);
                    tw.WriteLine("SOURCE_PASS=" + model.SOURCE_PASS);
                    tw.WriteLine("SOURCE_DB=" + model.SOURCE_DB);
                    tw.WriteLine("HREF_SERVER=" + model.HREF_SERVER);
                    tw.WriteLine("HREF_USER=" + model.HREF_USER);
                    tw.WriteLine("HREF_PASS=" + model.HREF_PASS);
                    tw.WriteLine("HREF_DB=" + model.HREF_DB);
                }
            }
            else
            {
                //dosya oluştur
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine("SOURCE_SERVER=" + model.SOURCE_SERVER);
                    tw.WriteLine("SOURCE_USER=" + model.SOURCE_USER);
                    tw.WriteLine("SOURCE_PASS=" + model.SOURCE_PASS);
                    tw.WriteLine("SOURCE_DB=" + model.SOURCE_DB);
                    tw.WriteLine("HREF_SERVER=" + model.HREF_SERVER);
                    tw.WriteLine("HREF_USER=" + model.HREF_USER);
                    tw.WriteLine("HREF_PASS=" + model.HREF_PASS);
                    tw.WriteLine("HREF_DB=" + model.HREF_DB);
                }
            }
        }
        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void WaitIconActivePassive(bool okey)
        {
            pictureBox1.Visible = okey;
        }
        private void KaynakDogrula_Click(object sender, EventArgs e)
        {
            WaitIconActivePassive(true);
            RDSPORTALEntities rDSPORTALEntities = new RDSPORTALEntities();
            kaynakbool.Text = "0";
            if (kaynakexemodel.Checked==true)
            {

                kaynaksnc.Text = "Program (V1.00) DataModel kullanılıcak!";
                kaynakbool.Text = "1";
                prepare_Model.ConnectionString_SOURCE = rDSPORTALEntities.Database.Connection.ConnectionString;
                prepare_Model.SOURCE_TYPE = 100;
                MessageBox.Show("Kaynak Doğrulama Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(kaynakmanuel.Checked==true)
            {
                kaynaksnc.Text = "Sql Server'a bağlanılıyor!...";
                using (SqlConnection connection = new SqlConnection("Server=" + kaynaksrv.Text + ";Database=" + kaynakdb.Text + ";User Id=" + kaynakuser.Text + ";Password=" + kaynakpass.Text + ";"))
                {
                    try
                    {
                        connection.Open();
                        kaynakbool.Text = "1";
                        kaynaksnc.Text = "Bağlantı Başarılı!";
                        prepare_Model.ConnectionString_SOURCE = "Server=" + kaynaksrv.Text + ";Database=" + kaynakdb.Text + ";User Id=" + kaynakuser.Text + ";Password=" + kaynakpass.Text + ";";
                        prepare_Model.SOURCE_TYPE = 200;
                        MessageBox.Show("Kaynak Doğrulama Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException Ex)
                    {
                        kaynakbool.Text = "0";
                        kaynaksnc.Text = "Bağlantı Başarısız!";
                        prepare_Model.ConnectionString_SOURCE = "";
                        MessageBox.Show("Bağlantı başarısız! Detay :"+Ex.ToString(), "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veri tipi seçiniz!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            WaitIconActivePassive(false);
        }

        private void HedefDogrula_Click(object sender, EventArgs e)
        {
            WaitIconActivePassive(true);
            hedefbool.Text = "0";
            if (hedefwebconfig.Checked == true)
            {
                hedefsnc.Text = "Web.Config Doğrulama başlatıldı!...";
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "/Web.config"))
                {
                    var filePath = AppDomain.CurrentDomain.BaseDirectory + "/Web.config";
                    var map = new ExeConfigurationFileMap { ExeConfigFilename = filePath };
                    var configFile = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);
                    var section = (ConnectionStringsSection)configFile.GetSection("connectionStrings");
                    
                    hedefsnc.Text = "Web.Config bulundu ve okunuyor...";
                    if (section.ConnectionStrings.Count>0)
                    {
                        foreach(ConnectionStringSettings cnstr in section.ConnectionStrings)
                        {
                            if (cnstr.Name == "RDSPORTALEntities")
                            {
                                string cnstringlast= cnstr.ConnectionString.Substring(cnstr.ConnectionString.IndexOf("connection string=")).Replace("connection string=", "").Replace("App=EntityFramework", "").Replace("MultipleActiveResultSets=True;", "").Replace("\"","");
                                using (SqlConnection connection = new SqlConnection(cnstringlast))
                                {
                                    try
                                    {
                                        
                                        connection.Open();                                       
                                        hedefbool.Text = "1";
                                        hedefsnc.Text = "Bağlantı Başarılı!";
                                        prepare_Model.ConnectionString_HREF = cnstringlast;
                                        MessageBox.Show("Kaynak Doğrulama Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    catch (SqlException Ex)
                                    {
                                        hedefbool.Text = "0";
                                        hedefsnc.Text = "Bağlantı Başarısız!";
                                        prepare_Model.ConnectionString_HREF = "";
                                        MessageBox.Show("Bağlantı başarısız! Detay :" + Ex.ToString(), "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Web.Config dosyası bulunamadı!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (hedefmanuel.Checked == true)
            {
                hedefsnc.Text = "Sql Server'a bağlanılıyor!...";
                System.Threading.Thread.Sleep(1000);
                using (SqlConnection connection = new SqlConnection("Server=" + hedefsrv.Text + ";Database=" + hedefdb.Text + ";User Id=" + hedefuser.Text + ";Password=" + hedefpass.Text + ";"))
                {
                    try
                    {
                        connection.Open();
                        hedefbool.Text = "1";
                        hedefsnc.Text = "Bağlantı Başarılı!";
                        prepare_Model.ConnectionString_HREF = "Server=" + hedefsrv.Text + ";Database=" + hedefdb.Text + ";User Id=" + hedefuser.Text + ";Password=" + hedefpass.Text + ";";
                        MessageBox.Show("Hedef Doğrulama Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException Ex)
                    {
                        hedefbool.Text = "0";
                        hedefsnc.Text = "Bağlantı Başarısız!";
                        prepare_Model.ConnectionString_HREF = "";
                        MessageBox.Show("Bağlantı başarısız! Detay :" + Ex.ToString(), "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veri tipi seçiniz!", "Dikkat",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            WaitIconActivePassive(false);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            WaitIconActivePassive(true);
            if (kaynakbool.Text!="1")
            {
                MessageBox.Show("Kaynak doğrulanmamış!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(hedefbool.Text!="1")
            {
                MessageBox.Show("Hedef doğrulanmamış!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //diğer safya
                if(eslesensatir.Checked==true)
                {
                    prepare_Model.ESLESENSATIRLAR = true;
                }
                if(fazladansatir.Checked==true)
                {
                    prepare_Model.FAZLASATIRLAR = true;
                }
                prepare_Model.SOURCE_SERVER = kaynaksrv.Text;
                prepare_Model.SOURCE_USER = kaynakuser.Text;
                prepare_Model.SOURCE_PASS = kaynakpass.Text;
                prepare_Model.SOURCE_DB = kaynakdb.Text;
                prepare_Model.HREF_SERVER = hedefsrv.Text;
                prepare_Model.HREF_USER = hedefuser.Text;
                prepare_Model.HREF_PASS = hedefpass.Text;
                prepare_Model.HREF_DB = hedefdb.Text;
                SetDBConnectionTxt(prepare_Model);

                var m = new CompareScreen(prepare_Model);
                m.Show();
                this.Hide();

            }
            WaitIconActivePassive(false);
        }

        private void kaynakmanuel_CheckedChanged(object sender, EventArgs e)
        {
            if(kaynakmanuel.Checked==true)
            {
                hidekaynak.Visible = false;
            }
            else
            {
                hidekaynak.Visible = true;
            }
        }

        private void kaynakexemodel_CheckedChanged(object sender, EventArgs e)
        {
            if (kaynakmanuel.Checked == true)
            {
                hidekaynak.Visible = false;
            }
            else
            {
                hidekaynak.Visible = true;
            }
        }

        private void hedefmanuel_CheckedChanged(object sender, EventArgs e)
        {
            if (hedefmanuel.Checked == true)
            {
                hidehedef.Visible = false;
            }
            else
            {
                hidehedef.Visible = true;
            }
        }

        private void hedefwebconfig_CheckedChanged(object sender, EventArgs e)
        {
            if (hedefmanuel.Checked == true)
            {
                hidehedef.Visible = false;
            }
            else
            {
                hidehedef.Visible = true;
            }
        }

        private void PrepareData_Load(object sender, EventArgs e)
        {
            Rectangle resolutionRect = System.Windows.Forms.Screen.FromControl(this).Bounds;
            if (this.Width >= resolutionRect.Width || this.Height >= resolutionRect.Height)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        //view create code
        //SELECt c.TEXT FROM sysobjects o join syscomments c ON c.id = o.id WHERE o.NAME = 'VE_STOCK' and o.type = 'V'

        //trigger create code
        // select [definition],'GO' from sys.sql_modules m inner join sys.objects obj on obj.object_id=m.object_id where obj.type = 'TR'

        //procedure create code 
        // select m.definition,o.name from sys.objects as o inner join sys.sql_modules as m on o.object_id = m.object_id where o.type = 'p'
    }
}
