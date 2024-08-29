using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MaterialSkinExample
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LoginBtn2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.errormsg = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(92, 66);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(89, 18);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Giriş Bilgileri";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(31, 106);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(70, 18);
            this.materialLabel7.TabIndex = 1;
            this.materialLabel7.Text = "Kullanıcı :";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(57, 135);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(46, 18);
            this.materialLabel8.TabIndex = 2;
            this.materialLabel8.Text = "Şifre :";
            // 
            // username
            // 
            this.username.Depth = 0;
            this.username.Hint = "";
            this.username.Location = new System.Drawing.Point(111, 106);
            this.username.MaxLength = 32767;
            this.username.MouseState = MaterialSkin.MouseState.HOVER;
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.SelectedText = "";
            this.username.SelectionLength = 0;
            this.username.SelectionStart = 0;
            this.username.Size = new System.Drawing.Size(149, 23);
            this.username.TabIndex = 3;
            this.username.TabStop = false;
            this.username.UseSystemPasswordChar = false;
            // 
            // pass
            // 
            this.pass.Depth = 0;
            this.pass.Hint = "";
            this.pass.Location = new System.Drawing.Point(111, 135);
            this.pass.MaxLength = 8;
            this.pass.MouseState = MaterialSkin.MouseState.HOVER;
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.SelectedText = "";
            this.pass.SelectionLength = 0;
            this.pass.SelectionStart = 0;
            this.pass.Size = new System.Drawing.Size(149, 23);
            this.pass.TabIndex = 4;
            this.pass.TabStop = false;
            this.pass.UseSystemPasswordChar = true;
            this.pass.GotFocus += new System.EventHandler(this.pass_GotFocus);
            // 
            // LoginBtn2
            // 
            this.LoginBtn2.AutoSize = true;
            this.LoginBtn2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginBtn2.Depth = 0;
            this.LoginBtn2.Icon = null;
            this.LoginBtn2.Location = new System.Drawing.Point(111, 199);
            this.LoginBtn2.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginBtn2.Name = "LoginBtn2";
            this.LoginBtn2.Primary = true;
            this.LoginBtn2.Size = new System.Drawing.Size(85, 36);
            this.LoginBtn2.TabIndex = 5;
            this.LoginBtn2.Text = "Giriş Yap";
            this.LoginBtn2.UseVisualStyleBackColor = true;
            this.LoginBtn2.Click += new System.EventHandler(this.LoginBtn2_Click);
            // 
            // errormsg
            // 
            this.errormsg.AutoSize = true;
            this.errormsg.Depth = 0;
            this.errormsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.errormsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errormsg.Location = new System.Drawing.Point(89, 167);
            this.errormsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.errormsg.Name = "errormsg";
            this.errormsg.Size = new System.Drawing.Size(0, 18);
            this.errormsg.TabIndex = 6;
            this.errormsg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.AutoSize = true;
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Icon = null;
            this.materialRaisedButton3.Location = new System.Drawing.Point(205, 199);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(55, 36);
            this.materialRaisedButton3.TabIndex = 7;
            this.materialRaisedButton3.Text = "Çıkış";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 55);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(276, 255);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.errormsg);
            this.Controls.Add(this.LoginBtn2);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.username);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private PictureBox pictureBox1;
    }
}