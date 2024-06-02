using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Jawly_Design4
{
    public partial class Login_Page : Form
    {
        public First_Form FirstForm { get; set; }
        public Form1 form1 = Application.OpenForms["form1"] as Form1;
        public Form_SavedAddresses formsavedaddress = Application.OpenForms["formsavedaddress"] as Form_SavedAddresses;
        DataTable dtusername = new DataTable();
        private string User_Name;
        public string name_user
        {
            get { return this.User_Name; }
            set { this.User_Name = value; }
        }

        private string usernamesimpan;
        public string UsernameSimpan
        {
            get { return this.usernamesimpan; }
            set { this.usernamesimpan = value; }
        }
        public Login_Page()
        {
            InitializeComponent();

        }
        private void Login_Page_Load(object sender, EventArgs e)
        {

        }

        private void label_signup_Click(object sender, EventArgs e)
        {
            if (FirstForm != null)
            {
                SignUp_Page signUpPage = new SignUp_Page();
                signUpPage.TopLevel = false;
                signUpPage.Dock = DockStyle.Fill;
                signUpPage.FirstForm2 = FirstForm;
                FirstForm.LoginSigninPanel.Controls.Clear();
                FirstForm.LoginSigninPanel.Controls.Add(signUpPage);
                signUpPage.Show();
            }
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            UpdateLoginButton();

            dtusername = new DataTable();
            try
            {
                FirstForm.sqlQuery = "SELECT * FROM LIST_AKUN WHERE nama_username = '"+ textBox_UsernameLogin.Text +"' OR notelp_user = '"+ textBox_UsernameLogin.Text +"';";
                FirstForm.sqlCommand = new MySqlCommand(FirstForm.sqlQuery, FirstForm.sqlConnect);
                FirstForm.sqlAdapter = new MySqlDataAdapter(FirstForm.sqlCommand);
                FirstForm.sqlAdapter.Fill(dtusername);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (dtusername.Rows.Count > 0)
            {
                string pass = textBox2_PasswordLogin.Text;

                MD5 md5 = new MD5CryptoServiceProvider();
                md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(pass));
                byte[] result = md5.Hash;

                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < result.Length; i++)
                {
                    //change it into 2 hexadecimal digits
                    //for each byte
                    stringBuilder.Append(result[i].ToString("x2"));
                }
                string encryptedPass = stringBuilder.ToString();


                if (encryptedPass == dtusername.Rows[0][3].ToString())
                {
                    //LOGIN BERHASIL MASUK !!!!!

                    usernamesimpan = dtusername.Rows[0][0].ToString();
                    User_Name = dtusername.Rows[0][1].ToString();
                    MessageBox.Show("Welcome to Jawly Xpress, " + User_Name + "!");

                    label_LoginFailed.Visible = false;
                    Form1 form1 = new Form1();
                    form1.Show();
                    FirstForm.Hide();
                    form1.loginpage = this;
                    form1.usernamenya = usernamesimpan;
                }
                else
                {
                    label_LoginFailed.Visible = true;
                }
            }
            else
            {
                label_LoginFailed.Visible = true;
            }
        }

        private void UpdateLoginButton()
        {
            if (!string.IsNullOrEmpty(textBox2_PasswordLogin.Text)
                && !string.IsNullOrEmpty(textBox_UsernameLogin.Text)
                && textBox2_PasswordLogin.Text.Length > 7)
            {
                button_Login.Enabled = true;
            }
            else
            {
                button_Login.Enabled = false;
            }
        }

        private void textBox_UsernameLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_PasswordLogin_TextChanged(object sender, EventArgs e)
        {
            UpdateLoginButton();
        }
        bool cek = true;
        private void pictureBox_passon_Click(object sender, EventArgs e)
        {
            if (cek == true)
            {
                textBox2_PasswordLogin.UseSystemPasswordChar = false;
                pictureBox_passon.Image = Jawly_Design4.Properties.Resources.Untitled_design__3_;
                cek = false;
            }
            else
            {
                textBox2_PasswordLogin.UseSystemPasswordChar = true;
                pictureBox_passon.Image = Jawly_Design4.Properties.Resources.Untitled_design__2_;
                cek = true;
            }
        }
    }
}
