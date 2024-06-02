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
    public partial class Form_EditAccount : Form
    {
        public Form_EditAccount()
        {
            InitializeComponent();
            form1.sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=db_jawly");
        }
        Form1 form1 = Application.OpenForms["form1"] as Form1;
        DataTable dtakun = new DataTable();
        DataTable notelp = new DataTable();
        DataTable dtpass= new DataTable();
        bool passlamabener = false;
        private void Form_EditAccount_Load(object sender, EventArgs e)
        {
            try
            {
                dtakun = new DataTable();
                form1.sqlQuery = "SELECT * FROM LIST_AKUN WHERE nama_username = '" + form1.usernamenya + "';";
                form1.sqlCommand = new MySqlCommand(form1.sqlQuery, form1.sqlConnect);
                form1.sqlAdapter = new MySqlDataAdapter(form1.sqlCommand);
                form1.sqlAdapter.Fill(dtakun);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string passw = dtakun.Rows[0][3].ToString();
            //DECRYPT PASSWORD
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
                System.Text.Decoder utf8Decode = encoder.GetDecoder();
                byte[] todecode_byte = Convert.FromBase64String(passw);
                int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
                char[] decoded_char = new char[charCount];
                utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
                string result = new String(decoded_char);
            

            textBox_Username.Text = form1.usernamenya;
            textBox_Yourname.Text = dtakun.Rows[0][1].ToString();
            textBox_Phone.Text = dtakun.Rows[0][2].ToString();
            //textBox2_OLDPassword.Text = result;
        }

        private void textBox2_PasswordSignIn_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2_OLDPassword.Text) && !string.IsNullOrEmpty(textBox_NEWPass.Text))
            {
                button_EDITPASS.Enabled = true;
            }
            else
            {
                button_EDITPASS.Enabled = false;
            }
            if (textBox2_OLDPassword.Text.Length > 7)
            {
                label_passx.Visible = false;

            }
            else
            {
                label_passx.Visible = true;
                button_EDITPASS.Enabled = false;
                button_EDITPASS.Visible = true;
            }
        }
        bool cek = true;
        private void pictureBox_passoff_Click(object sender, EventArgs e)
        {
            if (cek == true)
            {
                textBox2_OLDPassword.UseSystemPasswordChar = false;
                pictureBox_pass.Image = Jawly_Design4.Properties.Resources.Untitled_design__3_;
                cek = false;
            }
            else
            {
                textBox2_OLDPassword.UseSystemPasswordChar = true;
                pictureBox_pass.Image = Jawly_Design4.Properties.Resources.Untitled_design__2_;
                cek = true;
            }

        }

        private void button_EditAcc_Click(object sender, EventArgs e)
        {
            //UPDATE ACCOUNT
            if (textBox_Username.Text == form1.usernamenya &&
            textBox_Yourname.Text == dtakun.Rows[0][1].ToString() &&
            textBox_Phone.Text == dtakun.Rows[0][2].ToString())
            {
                MessageBox.Show("You haven't changed anything!");
            }
            else
            {
                form1.sqlConnect.Open();
                string MysQlCommand = "UPDATE LIST_AKUN SET nama_username = '" + textBox_Username.Text + "', nama_panggilan ='" + textBox_Yourname.Text + "', notelp_user = '" + textBox_Phone.Text + "' WHERE nama_username ='" + form1.usernamenya + "';";
                try
                {
                    form1.sqlCommand = new MySqlCommand(MysQlCommand, form1.sqlConnect);
                    form1.sqlReader = form1.sqlCommand.ExecuteReader();
                    MessageBox.Show("Account Successfully Edited!");
                    form1.usernamenya = textBox_Username.Text;
                    form1.loginpage.name_user = textBox_Yourname.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Username/Phone Number has been used, please try entering other");
                    form1.sqlConnect.Close();
                }
                finally
                {
                    form1.sqlConnect.Close();
                }
            }
        }

        private void button_EDITPASS_Click(object sender, EventArgs e)
        {
            if (textBox2_OLDPassword.Text != textBox_NEWPass.Text)
            {
                string passold = textBox2_OLDPassword.Text;

                MD5 md5 = new MD5CryptoServiceProvider();
                md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(passold));
                byte[] result = md5.Hash;

                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < result.Length; i++)
                {
                    //change it into 2 hexadecimal digits
                    //for each byte
                    stringBuilder.Append(result[i].ToString("x2"));
                }
                string encryptedPass = stringBuilder.ToString();

                if (encryptedPass != dtakun.Rows[0][3].ToString())
                {
                    MessageBox.Show("Incorrect Old Password");
                    textBox2_OLDPassword.Text = "";
                }
                else
                {
                    passlamabener = true;
                    string passnew = textBox_NEWPass.Text;
                    MD5 md5s = new MD5CryptoServiceProvider();
                    md5s.ComputeHash(ASCIIEncoding.ASCII.GetBytes(passnew));
                    byte[] result2 = md5s.Hash;

                    StringBuilder stringBuilder2 = new StringBuilder();
                    for (int i = 0; i < result2.Length; i++)
                    {
                        //change it into 2 hexadecimal digits
                        //for each byte
                        stringBuilder2.Append(result2[i].ToString("x2"));
                    }
                    string encryptedPass2 = stringBuilder2.ToString();


                    string MysQlCommand = $"UPDATE LIST_AKUN SET password_user = '{encryptedPass2}'WHERE nama_username = '{form1.usernamenya}'; ";
                    try
                    {
                        form1.sqlConnect.Open();
                        form1.sqlCommand = new MySqlCommand(MysQlCommand, form1.sqlConnect);
                        form1.sqlReader = form1.sqlCommand.ExecuteReader();
                        MessageBox.Show("Account Password successfully changed!");
                        textBox2_OLDPassword.Text = "";
                        textBox_NEWPass.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        form1.sqlConnect.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("Old password and new password cannot be the same! Please check again.");
            }

        }

        private void textBox_NEWPass_TextChanged(object sender, EventArgs e)
        {
            if (textBox_NEWPass.Text.Length > 7)
            {
                label_passy.Visible = false;
                button_EDITPASS.Enabled = true;
                button_EDITPASS.Visible = true;
            }
            else
            {
                label_passy.Visible = true;
                button_EDITPASS.Enabled = false;
                button_EDITPASS.Visible = true;
            }
            if (!string.IsNullOrEmpty(textBox2_OLDPassword.Text) && !string.IsNullOrEmpty(textBox_NEWPass.Text))
            {
                button_EDITPASS.Enabled = true;
            }
            else
            {
                button_EDITPASS.Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cek == true)
            {
                textBox_NEWPass.UseSystemPasswordChar = false;
                pictureBox_passy.Image = Jawly_Design4.Properties.Resources.Untitled_design__3_;
                cek = false;
            }
            else
            {
                textBox_NEWPass.UseSystemPasswordChar = true;
                pictureBox_passy.Image = Jawly_Design4.Properties.Resources.Untitled_design__2_;
                cek = true;
            }
        }

        private void textBox_Yourname_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_Phone.Text) && !string.IsNullOrEmpty(textBox_Username.Text)
                && !string.IsNullOrEmpty(textBox_Yourname.Text))
            {
                button_EditAcc.Enabled = true;
            }
            else
            {
                button_EditAcc.Enabled = false;
            }
        }

        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_Phone.Text) && !string.IsNullOrEmpty(textBox_Username.Text)
                && !string.IsNullOrEmpty(textBox_Yourname.Text))
            {
                button_EditAcc.Enabled = true;
            }
            else
            {
                button_EditAcc.Enabled = false;
            }
        }

        private void textBox_Phone_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_Phone.Text) && !string.IsNullOrEmpty(textBox_Username.Text)
                && !string.IsNullOrEmpty(textBox_Yourname.Text))
            {
                button_EditAcc.Enabled = true;
            }
            else
            {
                button_EditAcc.Enabled = false;
            }
        }

        private void textBox_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void button_DeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete Account of " + form1.usernamenya + ", You Sure?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string query = $"DELETE FROM LIST_AKUN WHERE nama_username = '{form1.usernamenya}'";

                try
                {
                    form1.sqlConnect.Open();
                    form1.sqlCommand = new MySqlCommand(query, form1.sqlConnect);
                    form1.sqlReader = form1.sqlCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    MessageBox.Show("Account " + form1.usernamenya + " deleted!");
                    form1.sqlConnect.Close();
                    form1.Close();
                    First_Form firstform = new First_Form();
                    firstform.Show();
                }
            }
        }
    }
}
