using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MaterialSkinExample
{
    public partial class Login : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Login()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Text = "RADUS - Giriş";
        }

	   

        private void materialButton1_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
        }
        private void LoginBtn2_Click(object sender, EventArgs e)
        {
            if(username.Text=="Admin" && pass.Text=="Rds123.")
            {
                pictureBox1.Visible = true;
                //login başarılı
                errormsg.Text = "Giriş Yapılıyor...";
                var m = new PrepareData();
                m.Show();
                this.Hide();
            }
            else
            {
                errormsg.Text = "Hatalı Giriş Bilgileri!";
            }
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pass_GotFocus(object sender, EventArgs e)
        {
            this.AcceptButton = LoginBtn2;
        }
    }
}
