using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Jawly_Design4
{
    public partial class SignUp_Page : Form
    {
        public First_Form FirstForm2 { get; set; }
        public Form1 firstform = new Form1();
        DataTable dtusern = new DataTable();
        DataTable dtnotelp = new DataTable();
        public SignUp_Page()
        {
            InitializeComponent();
        }

        private void SignUp_Page_Load(object sender, EventArgs e)
        {

        }
        string cekaja;
        private void button_SignUp_Click(object sender, EventArgs e)
        {
            label_passx.Visible = false;
            label_usernamex.Visible = false;
            label_phonenumberx.Visible = false;

            //CHECK USERNAME AVAILABLE
            try
            {
                dtusern = new DataTable();
                FirstForm2.sqlQuery = "SELECT * FROM LIST_AKUN WHERE nama_username = '" + textBox_UsernameSignIn.Text + "';";
                FirstForm2.sqlCommand = new MySqlCommand(FirstForm2.sqlQuery, FirstForm2.sqlConnect);
                FirstForm2.sqlAdapter = new MySqlDataAdapter(FirstForm2.sqlCommand);
                FirstForm2.sqlAdapter.Fill(dtusern);

                //CHECK NO TELP AVAILABLE
                dtnotelp = new DataTable();
                FirstForm2.sqlQuery = "SELECT * FROM LIST_AKUN WHERE notelp_user = '" + textBox_PhoneSignin.Text + "';";
                FirstForm2.sqlCommand = new MySqlCommand(FirstForm2.sqlQuery, FirstForm2.sqlConnect);
                FirstForm2.sqlAdapter = new MySqlDataAdapter(FirstForm2.sqlCommand);
                FirstForm2.sqlAdapter.Fill(dtnotelp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (dtusern.Rows.Count > 0 && dtnotelp.Rows.Count > 0)
            {
                textBox_UsernameSignIn.Text = "";
                label_usernamex.Visible = true;

                textBox_PhoneSignin.Text = "";
                label_phonenumberx.Visible = true;

            }
            else
            {
                if (dtusern.Rows.Count < 1)
                {
                    if (dtnotelp.Rows.Count < 1)
                    {
                        MessageBox.Show("Thank you " + textBox_YournameSIgnIn.Text + " for signing up on Jawly Xpress!\nYou can now Log In", "Account created!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        string notelp = textBox_PhoneSignin.Text;
                        string username = textBox_UsernameSignIn.Text;
                        string passw = textBox2_PasswordSignIn.Text;
                        string yourname = textBox_YournameSIgnIn.Text;

                        //ENCRYPT PASS

                        MD5 md5 = new MD5CryptoServiceProvider();
                        md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(passw));
                        byte[] result = md5.Hash;

                        StringBuilder stringBuilder = new StringBuilder();
                        for (int i = 0; i < result.Length; i++)
                        {
                            //change it into 2 hexadecimal digits
                            //for each byte
                            stringBuilder.Append(result[i].ToString("x2"));
                        }
                        string encryptedPass = stringBuilder.ToString();


                        string MysQlCommand = $"insert into list_akun value ('{username}','{yourname}','{notelp}', '{encryptedPass}')";
                        try
                        {
                            firstform.sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=db_jawly");
                            firstform.sqlConnect.Open();
                            firstform.sqlCommand = new MySqlCommand(MysQlCommand, firstform.sqlConnect);
                            firstform.sqlDataReader = firstform.sqlCommand.ExecuteReader();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            firstform.sqlConnect.Close();
                        }

                        FirstForm2.LoginSigninPanel.Controls.Clear();
                        Login_Page loginn = new Login_Page();
                        loginn.TopLevel = false;
                        loginn.Dock = DockStyle.Fill;
                        loginn.FirstForm = FirstForm2;
                        FirstForm2.LoginSigninPanel.Controls.Add(loginn);
                        loginn.Show();

                        label_passx.Visible = false;
                        label_usernamex.Visible = false;
                        label_phonenumberx.Visible = false;
                        textBox2_PasswordSignIn.Text = "";
                        textBox_PhoneSignin.Text = "";
                        textBox_UsernameSignIn.Text = "";
                        textBox_YournameSIgnIn.Text = "";
                    }
                    else
                    {
                        textBox_PhoneSignin.Text = "";
                        label_phonenumberx.Visible = true;
                    }
                }
                else
                {
                    textBox_UsernameSignIn.Text = "";
                    label_usernamex.Visible = true;
                }
            }
        }


        private void UpdateButtonSigunUp()
        {
            if (!string.IsNullOrEmpty(textBox2_PasswordSignIn.Text) && !string.IsNullOrEmpty(textBox_PhoneSignin.Text)
                 && !string.IsNullOrEmpty(textBox_UsernameSignIn.Text) && !string.IsNullOrEmpty(textBox_YournameSIgnIn.Text)
                 && textBox2_PasswordSignIn.Text.Length > 7)
            {
                button_SignUp.Enabled = true;
            }
            else
            {
                button_SignUp.Enabled = false;
            }
        }
        private void textBox_PhoneSignin_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonSigunUp();
        }

        private void textBox_YournameSIgnIn_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonSigunUp();
        }

        private void textBox_UsernameSignIn_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonSigunUp();
        }

        private void textBox2_PasswordSignIn_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonSigunUp();
            if (textBox2_PasswordSignIn.Text.Length > 7)
            {
                label_passx.Visible = false;
            }
            else
            {
                label_passx.Visible = true;
            }
        }

        private void textBox_PhoneSignin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        bool cek = true;
        private void pictureBox_passoff_Click(object sender, EventArgs e)
        {
            if (cek == true)
            {
                textBox2_PasswordSignIn.UseSystemPasswordChar = false;
                pictureBox_passoff.Image = Jawly_Design4.Properties.Resources.Untitled_design__3_;
                cek = false;
            }
            else
            {
                textBox2_PasswordSignIn.UseSystemPasswordChar = true;
                pictureBox_passoff.Image = Jawly_Design4.Properties.Resources.Untitled_design__2_;
                cek = true;
            }
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            FirstForm2.LoginSigninPanel.Controls.Clear();
            Login_Page loginn = new Login_Page();
            loginn.TopLevel = false;
            loginn.Dock = DockStyle.Fill;
            loginn.FirstForm = FirstForm2;
            FirstForm2.LoginSigninPanel.Controls.Add(loginn);
            loginn.Show();
        }
    }
}
