using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MaterialSkinExample
{
    partial class CompareScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompareScreen));
            this.materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            this.TABLES_TAB = new System.Windows.Forms.TabPage();
            this.COMPARE_TABLES_GRID_kaldir = new System.Windows.Forms.Button();
            this.COMPARE_TABLES_GRID_sec = new System.Windows.Forms.Button();
            this.loadingtxt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.COMPARE_COLUMN_GRID = new System.Windows.Forms.DataGridView();
            this.COMPARE_TABLES_GRID = new System.Windows.Forms.DataGridView();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.VIEWS_TAB = new System.Windows.Forms.TabPage();
            this.COMPARE_VIEWS_GRID_kaldir = new System.Windows.Forms.Button();
            this.COMPARE_VIEWS_GRID_sec = new System.Windows.Forms.Button();
            this.loadingtxt2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.materialDivider7 = new MaterialSkin.Controls.MaterialDivider();
            this.COMPARE_VIEWCOLUMN_GRID = new System.Windows.Forms.DataGridView();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider6 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.COMPARE_VIEWS_GRID = new System.Windows.Forms.DataGridView();
            this.FUNCTIONS_TAB = new System.Windows.Forms.TabPage();
            this.COMPARE_TRIGGER_GRID_kaldir = new System.Windows.Forms.Button();
            this.COMPARE_PROCEDURE_GRID_kaldir = new System.Windows.Forms.Button();
            this.COMPARE_TRIGGER_GRID_sec = new System.Windows.Forms.Button();
            this.COMPARE_PROCEDURE_GRID_sec = new System.Windows.Forms.Button();
            this.loadingtxt4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.loadingtxt3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.materialDivider8 = new MaterialSkin.Controls.MaterialDivider();
            this.COMPARE_TRIGGER_GRID = new System.Windows.Forms.DataGridView();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider9 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider10 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.COMPARE_PROCEDURE_GRID = new System.Windows.Forms.DataGridView();
            this.sqlquery = new System.Windows.Forms.TabPage();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Start_Compare = new MaterialSkin.Controls.MaterialRaisedButton();
            this.outsqltextbtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.sqlouttext = new System.Windows.Forms.RichTextBox();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.exit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl2.SuspendLayout();
            this.TABLES_TAB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.COMPARE_COLUMN_GRID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMPARE_TABLES_GRID)).BeginInit();
            this.VIEWS_TAB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.COMPARE_VIEWCOLUMN_GRID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMPARE_VIEWS_GRID)).BeginInit();
            this.FUNCTIONS_TAB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.COMPARE_TRIGGER_GRID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMPARE_PROCEDURE_GRID)).BeginInit();
            this.sqlquery.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl2
            // 
            this.materialTabControl2.Controls.Add(this.TABLES_TAB);
            this.materialTabControl2.Controls.Add(this.VIEWS_TAB);
            this.materialTabControl2.Controls.Add(this.FUNCTIONS_TAB);
            this.materialTabControl2.Controls.Add(this.sqlquery);
            this.materialTabControl2.Depth = 0;
            this.materialTabControl2.Location = new System.Drawing.Point(12, 68);
            this.materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            this.materialTabControl2.Size = new System.Drawing.Size(1052, 591);
            this.materialTabControl2.TabIndex = 0;
            // 
            // TABLES_TAB
            // 
            this.TABLES_TAB.Controls.Add(this.COMPARE_TABLES_GRID_kaldir);
            this.TABLES_TAB.Controls.Add(this.COMPARE_TABLES_GRID_sec);
            this.TABLES_TAB.Controls.Add(this.loadingtxt);
            this.TABLES_TAB.Controls.Add(this.button1);
            this.TABLES_TAB.Controls.Add(this.COMPARE_COLUMN_GRID);
            this.TABLES_TAB.Controls.Add(this.COMPARE_TABLES_GRID);
            this.TABLES_TAB.Controls.Add(this.materialLabel11);
            this.TABLES_TAB.Controls.Add(this.materialDivider4);
            this.TABLES_TAB.Controls.Add(this.materialDivider3);
            this.TABLES_TAB.Controls.Add(this.materialLabel10);
            this.TABLES_TAB.Controls.Add(this.materialDivider2);
            this.TABLES_TAB.Location = new System.Drawing.Point(4, 22);
            this.TABLES_TAB.Name = "TABLES_TAB";
            this.TABLES_TAB.Padding = new System.Windows.Forms.Padding(3);
            this.TABLES_TAB.Size = new System.Drawing.Size(1044, 565);
            this.TABLES_TAB.TabIndex = 0;
            this.TABLES_TAB.Text = "Tablo Karşılaştırması";
            this.TABLES_TAB.UseVisualStyleBackColor = true;
            // 
            // COMPARE_TABLES_GRID_kaldir
            // 
            this.COMPARE_TABLES_GRID_kaldir.Location = new System.Drawing.Point(410, 8);
            this.COMPARE_TABLES_GRID_kaldir.Name = "COMPARE_TABLES_GRID_kaldir";
            this.COMPARE_TABLES_GRID_kaldir.Size = new System.Drawing.Size(90, 25);
            this.COMPARE_TABLES_GRID_kaldir.TabIndex = 21;
            this.COMPARE_TABLES_GRID_kaldir.Text = "Tümünü Kaldır";
            this.COMPARE_TABLES_GRID_kaldir.UseVisualStyleBackColor = true;
            this.COMPARE_TABLES_GRID_kaldir.Visible = false;
            this.COMPARE_TABLES_GRID_kaldir.Click += new System.EventHandler(this.COMPARE_TABLES_GRID_kaldir_Click);
            // 
            // COMPARE_TABLES_GRID_sec
            // 
            this.COMPARE_TABLES_GRID_sec.Location = new System.Drawing.Point(410, 9);
            this.COMPARE_TABLES_GRID_sec.Name = "COMPARE_TABLES_GRID_sec";
            this.COMPARE_TABLES_GRID_sec.Size = new System.Drawing.Size(90, 25);
            this.COMPARE_TABLES_GRID_sec.TabIndex = 20;
            this.COMPARE_TABLES_GRID_sec.Text = "Tümünü Seç";
            this.COMPARE_TABLES_GRID_sec.UseVisualStyleBackColor = true;
            this.COMPARE_TABLES_GRID_sec.Click += new System.EventHandler(this.COMPARE_TABLES_GRID_sec_Click);
            // 
            // loadingtxt
            // 
            this.loadingtxt.AutoSize = true;
            this.loadingtxt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loadingtxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadingtxt.Location = new System.Drawing.Point(200, 274);
            this.loadingtxt.Name = "loadingtxt";
            this.loadingtxt.Padding = new System.Windows.Forms.Padding(20);
            this.loadingtxt.Size = new System.Drawing.Size(111, 53);
            this.loadingtxt.TabIndex = 19;
            this.loadingtxt.Text = "Yükleniyor  ...";
            this.loadingtxt.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Listeyi Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // COMPARE_COLUMN_GRID
            // 
            this.COMPARE_COLUMN_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.COMPARE_COLUMN_GRID.Location = new System.Drawing.Point(527, 50);
            this.COMPARE_COLUMN_GRID.Name = "COMPARE_COLUMN_GRID";
            this.COMPARE_COLUMN_GRID.Size = new System.Drawing.Size(511, 509);
            this.COMPARE_COLUMN_GRID.TabIndex = 6;
            // 
            // COMPARE_TABLES_GRID
            // 
            this.COMPARE_TABLES_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.COMPARE_TABLES_GRID.Location = new System.Drawing.Point(7, 51);
            this.COMPARE_TABLES_GRID.Name = "COMPARE_TABLES_GRID";
            this.COMPARE_TABLES_GRID.Size = new System.Drawing.Size(493, 509);
            this.COMPARE_TABLES_GRID.TabIndex = 5;
            this.COMPARE_TABLES_GRID.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.RowColored);
            this.COMPARE_TABLES_GRID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.COMPARE_TABLES_GRID_MouseClick);
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(726, 9);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(144, 19);
            this.materialLabel11.TabIndex = 4;
            this.materialLabel11.Text = "Alan Karşılaştırması";
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(526, 36);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(512, 10);
            this.materialDivider4.TabIndex = 3;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(6, 37);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(494, 10);
            this.materialDivider3.TabIndex = 2;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(173, 9);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(152, 19);
            this.materialLabel10.TabIndex = 1;
            this.materialLabel10.Text = "Tablo Karşılaştırması";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(506, 47);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(15, 513);
            this.materialDivider2.TabIndex = 0;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // VIEWS_TAB
            // 
            this.VIEWS_TAB.Controls.Add(this.COMPARE_VIEWS_GRID_kaldir);
            this.VIEWS_TAB.Controls.Add(this.COMPARE_VIEWS_GRID_sec);
            this.VIEWS_TAB.Controls.Add(this.loadingtxt2);
            this.VIEWS_TAB.Controls.Add(this.button2);
            this.VIEWS_TAB.Controls.Add(this.materialDivider7);
            this.VIEWS_TAB.Controls.Add(this.COMPARE_VIEWCOLUMN_GRID);
            this.VIEWS_TAB.Controls.Add(this.materialLabel12);
            this.VIEWS_TAB.Controls.Add(this.materialDivider5);
            this.VIEWS_TAB.Controls.Add(this.materialDivider6);
            this.VIEWS_TAB.Controls.Add(this.materialLabel13);
            this.VIEWS_TAB.Controls.Add(this.COMPARE_VIEWS_GRID);
            this.VIEWS_TAB.Location = new System.Drawing.Point(4, 22);
            this.VIEWS_TAB.Name = "VIEWS_TAB";
            this.VIEWS_TAB.Padding = new System.Windows.Forms.Padding(3);
            this.VIEWS_TAB.Size = new System.Drawing.Size(1044, 565);
            this.VIEWS_TAB.TabIndex = 1;
            this.VIEWS_TAB.Text = "Views Karşılaştırması";
            this.VIEWS_TAB.UseVisualStyleBackColor = true;
            // 
            // COMPARE_VIEWS_GRID_kaldir
            // 
            this.COMPARE_VIEWS_GRID_kaldir.Location = new System.Drawing.Point(410, 8);
            this.COMPARE_VIEWS_GRID_kaldir.Name = "COMPARE_VIEWS_GRID_kaldir";
            this.COMPARE_VIEWS_GRID_kaldir.Size = new System.Drawing.Size(90, 25);
            this.COMPARE_VIEWS_GRID_kaldir.TabIndex = 23;
            this.COMPARE_VIEWS_GRID_kaldir.Text = "Tümünü Kaldır";
            this.COMPARE_VIEWS_GRID_kaldir.UseVisualStyleBackColor = true;
            this.COMPARE_VIEWS_GRID_kaldir.Visible = false;
            this.COMPARE_VIEWS_GRID_kaldir.Click += new System.EventHandler(this.COMPARE_VIEWS_GRID_kaldir_Click);
            // 
            // COMPARE_VIEWS_GRID_sec
            // 
            this.COMPARE_VIEWS_GRID_sec.Location = new System.Drawing.Point(409, 8);
            this.COMPARE_VIEWS_GRID_sec.Name = "COMPARE_VIEWS_GRID_sec";
            this.COMPARE_VIEWS_GRID_sec.Size = new System.Drawing.Size(90, 25);
            this.COMPARE_VIEWS_GRID_sec.TabIndex = 22;
            this.COMPARE_VIEWS_GRID_sec.Text = "Tümünü Seç";
            this.COMPARE_VIEWS_GRID_sec.UseVisualStyleBackColor = true;
            this.COMPARE_VIEWS_GRID_sec.Click += new System.EventHandler(this.COMPARE_VIEWS_GRID_sec_Click);
            // 
            // loadingtxt2
            // 
            this.loadingtxt2.AutoSize = true;
            this.loadingtxt2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loadingtxt2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadingtxt2.Location = new System.Drawing.Point(173, 284);
            this.loadingtxt2.Name = "loadingtxt2";
            this.loadingtxt2.Padding = new System.Windows.Forms.Padding(20);
            this.loadingtxt2.Size = new System.Drawing.Size(111, 53);
            this.loadingtxt2.TabIndex = 20;
            this.loadingtxt2.Text = "Yükleniyor  ...";
            this.loadingtxt2.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 13;
            this.button2.Text = "Listeyi Getir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // materialDivider7
            // 
            this.materialDivider7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider7.Depth = 0;
            this.materialDivider7.Location = new System.Drawing.Point(505, 52);
            this.materialDivider7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider7.Name = "materialDivider7";
            this.materialDivider7.Size = new System.Drawing.Size(15, 509);
            this.materialDivider7.TabIndex = 12;
            this.materialDivider7.Text = "materialDivider7";
            // 
            // COMPARE_VIEWCOLUMN_GRID
            // 
            this.COMPARE_VIEWCOLUMN_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.COMPARE_VIEWCOLUMN_GRID.Location = new System.Drawing.Point(525, 52);
            this.COMPARE_VIEWCOLUMN_GRID.Name = "COMPARE_VIEWCOLUMN_GRID";
            this.COMPARE_VIEWCOLUMN_GRID.Size = new System.Drawing.Size(513, 509);
            this.COMPARE_VIEWCOLUMN_GRID.TabIndex = 11;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(725, 9);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(144, 19);
            this.materialLabel12.TabIndex = 10;
            this.materialLabel12.Text = "Alan Karşılaştırması";
            // 
            // materialDivider5
            // 
            this.materialDivider5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider5.Depth = 0;
            this.materialDivider5.Location = new System.Drawing.Point(525, 36);
            this.materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider5.Name = "materialDivider5";
            this.materialDivider5.Size = new System.Drawing.Size(513, 10);
            this.materialDivider5.TabIndex = 9;
            this.materialDivider5.Text = "materialDivider5";
            // 
            // materialDivider6
            // 
            this.materialDivider6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider6.Depth = 0;
            this.materialDivider6.Location = new System.Drawing.Point(5, 36);
            this.materialDivider6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider6.Name = "materialDivider6";
            this.materialDivider6.Size = new System.Drawing.Size(494, 10);
            this.materialDivider6.TabIndex = 8;
            this.materialDivider6.Text = "materialDivider6";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(172, 8);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(147, 19);
            this.materialLabel13.TabIndex = 7;
            this.materialLabel13.Text = "View Karşılaştırması";
            // 
            // COMPARE_VIEWS_GRID
            // 
            this.COMPARE_VIEWS_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.COMPARE_VIEWS_GRID.Location = new System.Drawing.Point(6, 52);
            this.COMPARE_VIEWS_GRID.Name = "COMPARE_VIEWS_GRID";
            this.COMPARE_VIEWS_GRID.Size = new System.Drawing.Size(493, 509);
            this.COMPARE_VIEWS_GRID.TabIndex = 6;
            this.COMPARE_VIEWS_GRID.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.RowColored2);
            this.COMPARE_VIEWS_GRID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.COMPARE_VIEWS_GRID_MouseClick);
            // 
            // FUNCTIONS_TAB
            // 
            this.FUNCTIONS_TAB.Controls.Add(this.COMPARE_TRIGGER_GRID_kaldir);
            this.FUNCTIONS_TAB.Controls.Add(this.COMPARE_PROCEDURE_GRID_kaldir);
            this.FUNCTIONS_TAB.Controls.Add(this.COMPARE_TRIGGER_GRID_sec);
            this.FUNCTIONS_TAB.Controls.Add(this.COMPARE_PROCEDURE_GRID_sec);
            this.FUNCTIONS_TAB.Controls.Add(this.loadingtxt4);
            this.FUNCTIONS_TAB.Controls.Add(this.button4);
            this.FUNCTIONS_TAB.Controls.Add(this.loadingtxt3);
            this.FUNCTIONS_TAB.Controls.Add(this.button3);
            this.FUNCTIONS_TAB.Controls.Add(this.materialDivider8);
            this.FUNCTIONS_TAB.Controls.Add(this.COMPARE_TRIGGER_GRID);
            this.FUNCTIONS_TAB.Controls.Add(this.materialLabel16);
            this.FUNCTIONS_TAB.Controls.Add(this.materialDivider9);
            this.FUNCTIONS_TAB.Controls.Add(this.materialDivider10);
            this.FUNCTIONS_TAB.Controls.Add(this.materialLabel17);
            this.FUNCTIONS_TAB.Controls.Add(this.COMPARE_PROCEDURE_GRID);
            this.FUNCTIONS_TAB.Location = new System.Drawing.Point(4, 22);
            this.FUNCTIONS_TAB.Name = "FUNCTIONS_TAB";
            this.FUNCTIONS_TAB.Padding = new System.Windows.Forms.Padding(3);
            this.FUNCTIONS_TAB.Size = new System.Drawing.Size(1044, 565);
            this.FUNCTIONS_TAB.TabIndex = 2;
            this.FUNCTIONS_TAB.Text = "Fonksiyon Karşılaştırması";
            this.FUNCTIONS_TAB.UseVisualStyleBackColor = true;
            // 
            // COMPARE_TRIGGER_GRID_kaldir
            // 
            this.COMPARE_TRIGGER_GRID_kaldir.Location = new System.Drawing.Point(948, 8);
            this.COMPARE_TRIGGER_GRID_kaldir.Name = "COMPARE_TRIGGER_GRID_kaldir";
            this.COMPARE_TRIGGER_GRID_kaldir.Size = new System.Drawing.Size(90, 25);
            this.COMPARE_TRIGGER_GRID_kaldir.TabIndex = 35;
            this.COMPARE_TRIGGER_GRID_kaldir.Text = "Tümünü Kaldır";
            this.COMPARE_TRIGGER_GRID_kaldir.UseVisualStyleBackColor = true;
            this.COMPARE_TRIGGER_GRID_kaldir.Visible = false;
            this.COMPARE_TRIGGER_GRID_kaldir.Click += new System.EventHandler(this.COMPARE_TRIGGER_GRID_kaldir_Click);
            // 
            // COMPARE_PROCEDURE_GRID_kaldir
            // 
            this.COMPARE_PROCEDURE_GRID_kaldir.Location = new System.Drawing.Point(409, 11);
            this.COMPARE_PROCEDURE_GRID_kaldir.Name = "COMPARE_PROCEDURE_GRID_kaldir";
            this.COMPARE_PROCEDURE_GRID_kaldir.Size = new System.Drawing.Size(90, 25);
            this.COMPARE_PROCEDURE_GRID_kaldir.TabIndex = 34;
            this.COMPARE_PROCEDURE_GRID_kaldir.Text = "Tümünü Kaldır";
            this.COMPARE_PROCEDURE_GRID_kaldir.UseVisualStyleBackColor = true;
            this.COMPARE_PROCEDURE_GRID_kaldir.Visible = false;
            this.COMPARE_PROCEDURE_GRID_kaldir.Click += new System.EventHandler(this.COMPARE_PROCEDURE_GRID_kaldir_Click);
            // 
            // COMPARE_TRIGGER_GRID_sec
            // 
            this.COMPARE_TRIGGER_GRID_sec.Location = new System.Drawing.Point(948, 9);
            this.COMPARE_TRIGGER_GRID_sec.Name = "COMPARE_TRIGGER_GRID_sec";
            this.COMPARE_TRIGGER_GRID_sec.Size = new System.Drawing.Size(90, 25);
            this.COMPARE_TRIGGER_GRID_sec.TabIndex = 33;
            this.COMPARE_TRIGGER_GRID_sec.Text = "Tümünü Seç";
            this.COMPARE_TRIGGER_GRID_sec.UseVisualStyleBackColor = true;
            this.COMPARE_TRIGGER_GRID_sec.Click += new System.EventHandler(this.COMPARE_TRIGGER_GRID_sec_Click);
            // 
            // COMPARE_PROCEDURE_GRID_sec
            // 
            this.COMPARE_PROCEDURE_GRID_sec.Location = new System.Drawing.Point(409, 9);
            this.COMPARE_PROCEDURE_GRID_sec.Name = "COMPARE_PROCEDURE_GRID_sec";
            this.COMPARE_PROCEDURE_GRID_sec.Size = new System.Drawing.Size(90, 25);
            this.COMPARE_PROCEDURE_GRID_sec.TabIndex = 32;
            this.COMPARE_PROCEDURE_GRID_sec.Text = "Tümünü Seç";
            this.COMPARE_PROCEDURE_GRID_sec.UseVisualStyleBackColor = true;
            this.COMPARE_PROCEDURE_GRID_sec.Click += new System.EventHandler(this.COMPARE_PROCEDURE_GRID_sec_Click);
            // 
            // loadingtxt4
            // 
            this.loadingtxt4.AutoSize = true;
            this.loadingtxt4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loadingtxt4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadingtxt4.Location = new System.Drawing.Point(710, 287);
            this.loadingtxt4.Name = "loadingtxt4";
            this.loadingtxt4.Padding = new System.Windows.Forms.Padding(20);
            this.loadingtxt4.Size = new System.Drawing.Size(111, 53);
            this.loadingtxt4.TabIndex = 31;
            this.loadingtxt4.Text = "Yükleniyor  ...";
            this.loadingtxt4.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(525, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 25);
            this.button4.TabIndex = 30;
            this.button4.Text = "Listeyi Getir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // loadingtxt3
            // 
            this.loadingtxt3.AutoSize = true;
            this.loadingtxt3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loadingtxt3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadingtxt3.Location = new System.Drawing.Point(173, 287);
            this.loadingtxt3.Name = "loadingtxt3";
            this.loadingtxt3.Padding = new System.Windows.Forms.Padding(20);
            this.loadingtxt3.Size = new System.Drawing.Size(111, 53);
            this.loadingtxt3.TabIndex = 29;
            this.loadingtxt3.Text = "Yükleniyor  ...";
            this.loadingtxt3.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 28;
            this.button3.Text = "Listeyi Getir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // materialDivider8
            // 
            this.materialDivider8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider8.Depth = 0;
            this.materialDivider8.Location = new System.Drawing.Point(505, 55);
            this.materialDivider8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider8.Name = "materialDivider8";
            this.materialDivider8.Size = new System.Drawing.Size(15, 509);
            this.materialDivider8.TabIndex = 27;
            this.materialDivider8.Text = "materialDivider8";
            // 
            // COMPARE_TRIGGER_GRID
            // 
            this.COMPARE_TRIGGER_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.COMPARE_TRIGGER_GRID.Location = new System.Drawing.Point(525, 55);
            this.COMPARE_TRIGGER_GRID.Name = "COMPARE_TRIGGER_GRID";
            this.COMPARE_TRIGGER_GRID.Size = new System.Drawing.Size(513, 509);
            this.COMPARE_TRIGGER_GRID.TabIndex = 26;
            this.COMPARE_TRIGGER_GRID.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.RowColored4);
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(709, 11);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(161, 19);
            this.materialLabel16.TabIndex = 25;
            this.materialLabel16.Text = "Trigger Karşılaştırması";
            // 
            // materialDivider9
            // 
            this.materialDivider9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider9.Depth = 0;
            this.materialDivider9.Location = new System.Drawing.Point(525, 39);
            this.materialDivider9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider9.Name = "materialDivider9";
            this.materialDivider9.Size = new System.Drawing.Size(513, 10);
            this.materialDivider9.TabIndex = 24;
            this.materialDivider9.Text = "materialDivider9";
            // 
            // materialDivider10
            // 
            this.materialDivider10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider10.Depth = 0;
            this.materialDivider10.Location = new System.Drawing.Point(5, 39);
            this.materialDivider10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider10.Name = "materialDivider10";
            this.materialDivider10.Size = new System.Drawing.Size(494, 10);
            this.materialDivider10.TabIndex = 23;
            this.materialDivider10.Text = "materialDivider10";
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(172, 11);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(174, 19);
            this.materialLabel17.TabIndex = 22;
            this.materialLabel17.Text = "Prosedür Karşılaştırması";
            // 
            // COMPARE_PROCEDURE_GRID
            // 
            this.COMPARE_PROCEDURE_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.COMPARE_PROCEDURE_GRID.Location = new System.Drawing.Point(6, 55);
            this.COMPARE_PROCEDURE_GRID.Name = "COMPARE_PROCEDURE_GRID";
            this.COMPARE_PROCEDURE_GRID.Size = new System.Drawing.Size(493, 509);
            this.COMPARE_PROCEDURE_GRID.TabIndex = 21;
            this.COMPARE_PROCEDURE_GRID.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.RowColored3);
            // 
            // sqlquery
            // 
            this.sqlquery.Controls.Add(this.materialRaisedButton4);
            this.sqlquery.Controls.Add(this.Start_Compare);
            this.sqlquery.Controls.Add(this.outsqltextbtn);
            this.sqlquery.Controls.Add(this.sqlouttext);
            this.sqlquery.Controls.Add(this.materialLabel14);
            this.sqlquery.Location = new System.Drawing.Point(4, 22);
            this.sqlquery.Name = "sqlquery";
            this.sqlquery.Padding = new System.Windows.Forms.Padding(3);
            this.sqlquery.Size = new System.Drawing.Size(1044, 565);
            this.sqlquery.TabIndex = 3;
            this.sqlquery.Text = "Sql Çıktısı ve Eşitleme";
            this.sqlquery.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.AutoSize = true;
            this.materialRaisedButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Icon = null;
            this.materialRaisedButton4.Location = new System.Drawing.Point(6, 523);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(65, 36);
            this.materialRaisedButton4.TabIndex = 5;
            this.materialRaisedButton4.Text = "Kapat";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            this.materialRaisedButton4.Click += new System.EventHandler(this.materialRaisedButton4_Click);
            // 
            // Start_Compare
            // 
            this.Start_Compare.AutoSize = true;
            this.Start_Compare.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Start_Compare.Depth = 0;
            this.Start_Compare.Icon = null;
            this.Start_Compare.Location = new System.Drawing.Point(844, 523);
            this.Start_Compare.MouseState = MaterialSkin.MouseState.HOVER;
            this.Start_Compare.Name = "Start_Compare";
            this.Start_Compare.Primary = true;
            this.Start_Compare.Size = new System.Drawing.Size(185, 36);
            this.Start_Compare.TabIndex = 3;
            this.Start_Compare.Text = "Veritabanlarını Eşitle";
            this.Start_Compare.UseVisualStyleBackColor = true;
            this.Start_Compare.Click += new System.EventHandler(this.Start_Compare_Click);
            // 
            // outsqltextbtn
            // 
            this.outsqltextbtn.AutoSize = true;
            this.outsqltextbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.outsqltextbtn.Depth = 0;
            this.outsqltextbtn.Icon = null;
            this.outsqltextbtn.Location = new System.Drawing.Point(410, 523);
            this.outsqltextbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.outsqltextbtn.Name = "outsqltextbtn";
            this.outsqltextbtn.Primary = true;
            this.outsqltextbtn.Size = new System.Drawing.Size(159, 36);
            this.outsqltextbtn.TabIndex = 8;
            this.outsqltextbtn.Text = "SQL Çıktısı Oluştur";
            this.outsqltextbtn.UseVisualStyleBackColor = true;
            this.outsqltextbtn.Click += new System.EventHandler(this.outsqltextbtn_Click);
            // 
            // sqlouttext
            // 
            this.sqlouttext.Location = new System.Drawing.Point(6, 54);
            this.sqlouttext.Name = "sqlouttext";
            this.sqlouttext.Size = new System.Drawing.Size(1032, 463);
            this.sqlouttext.TabIndex = 1;
            this.sqlouttext.Text = "";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(436, 20);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(132, 19);
            this.materialLabel14.TabIndex = 0;
            this.materialLabel14.Text = "SQL ÇIKTI EKRANI";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(422, 2);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(225, 19);
            this.materialLabel9.TabIndex = 1;
            this.materialLabel9.Text = "Kaynak ve Hedef Karşılaştırması";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exit.Depth = 0;
            this.exit.Icon = null;
            this.exit.Location = new System.Drawing.Point(1007, 26);
            this.exit.MouseState = MaterialSkin.MouseState.HOVER;
            this.exit.Name = "exit";
            this.exit.Primary = true;
            this.exit.Size = new System.Drawing.Size(51, 36);
            this.exit.TabIndex = 2;
            this.exit.Text = "Geri";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = this.materialTabControl2;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Location = new System.Drawing.Point(16, 24);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(975, 34);
            this.materialTabSelector2.TabIndex = 4;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // CompareScreen
            // 
            this.ClientSize = new System.Drawing.Size(1067, 660);
            this.Controls.Add(this.materialTabSelector2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialTabControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompareScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CompareScreen_Load);
            this.materialTabControl2.ResumeLayout(false);
            this.TABLES_TAB.ResumeLayout(false);
            this.TABLES_TAB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.COMPARE_COLUMN_GRID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMPARE_TABLES_GRID)).EndInit();
            this.VIEWS_TAB.ResumeLayout(false);
            this.VIEWS_TAB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.COMPARE_VIEWCOLUMN_GRID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMPARE_VIEWS_GRID)).EndInit();
            this.FUNCTIONS_TAB.ResumeLayout(false);
            this.FUNCTIONS_TAB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.COMPARE_TRIGGER_GRID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMPARE_PROCEDURE_GRID)).EndInit();
            this.sqlquery.ResumeLayout(false);
            this.sqlquery.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckbox1;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckbox2;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckbox3;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckbox4;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialRadioButton materialRadioButton2;
        private MaterialRadioButton materialRadioButton3;
        private MaterialFlatButton materialFlatButton2;
        private MaterialLabel materialLabel1;
        private MaterialRadioButton materialRadioButton4;
        private MaterialDivider materialDivider1;
        private MaterialTabSelector materialTabSelector1;
        private MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialCheckBox materialCheckBox5;
        private MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem disabledItemToolStripMenuItem;
        private MaterialCheckBox materialCheckBox6;
        private MaterialRaisedButton materialRaisedButton1;
        private MaterialSingleLineTextField materialSingleLineTextField3;
        private TabPage tabPage4;
        private MaterialListView materialListView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TabPage tabPage5;
        private MaterialProgressBar materialProgressBar1;
        private MaterialRaisedButton materialRaisedButton2;
        private MaterialFlatButton materialFlatButton3;
        private MaterialFlatButton materialFlatButton4;
        private MaterialLabel materialLabel2;
        private MaterialLabel materialLabel3;
        private MaterialLabel materialLabel4;
        private MaterialLabel materialLabel5;
        private MaterialSingleLineTextField user;
        private MaterialSingleLineTextField password;
        private MaterialFlatButton loginbtn;
        private MaterialLabel materialLabel6;
        private MaterialLabel materialLabel7;
        private MaterialLabel materialLabel8;
        private MaterialSingleLineTextField username;
        private MaterialSingleLineTextField pass;
        private MaterialRaisedButton LoginBtn2;
        private MaterialLabel errormsg;
        private MaterialRaisedButton materialRaisedButton3;
        private MaterialTabControl materialTabControl2;
        private TabPage TABLES_TAB;
        private TabPage VIEWS_TAB;
        private TabPage FUNCTIONS_TAB;
        private DataGridView COMPARE_COLUMN_GRID;
        private DataGridView COMPARE_TABLES_GRID;
        private MaterialLabel materialLabel11;
        private MaterialDivider materialDivider4;
        private MaterialDivider materialDivider3;
        private MaterialLabel materialLabel10;
        private MaterialDivider materialDivider2;
        private MaterialLabel materialLabel9;
        private MaterialRaisedButton exit;
        private MaterialRaisedButton Start_Compare;
        private MaterialTabSelector materialTabSelector2;
        private MaterialDivider materialDivider7;
        private DataGridView COMPARE_VIEWCOLUMN_GRID;
        private MaterialLabel materialLabel12;
        private MaterialDivider materialDivider5;
        private MaterialDivider materialDivider6;
        private MaterialLabel materialLabel13;
        private DataGridView COMPARE_VIEWS_GRID;
        private TabPage sqlquery;
        private MaterialRaisedButton outsqltextbtn;
        private RichTextBox sqlouttext;
        private MaterialLabel materialLabel14;
        private Button button1;
        private Button button2;
        private Label loadingtxt;
        private Label loadingtxt2;
        private Button button4;
        private Label loadingtxt3;
        private Button button3;
        private MaterialDivider materialDivider8;
        private DataGridView COMPARE_TRIGGER_GRID;
        private MaterialLabel materialLabel16;
        private MaterialDivider materialDivider9;
        private MaterialDivider materialDivider10;
        private MaterialLabel materialLabel17;
        private DataGridView COMPARE_PROCEDURE_GRID;
        private Label loadingtxt4;
        private Button COMPARE_TABLES_GRID_sec;
        private Button COMPARE_VIEWS_GRID_sec;
        private Button COMPARE_TRIGGER_GRID_sec;
        private Button COMPARE_PROCEDURE_GRID_sec;
        private Button COMPARE_TABLES_GRID_kaldir;
        private Button COMPARE_VIEWS_GRID_kaldir;
        private Button COMPARE_TRIGGER_GRID_kaldir;
        private Button COMPARE_PROCEDURE_GRID_kaldir;
        private MaterialRaisedButton materialRaisedButton4;
    }
}