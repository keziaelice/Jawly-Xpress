using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Jawly_Design4
{
    public partial class Form_SavedAddresses : Form
    {
        public Login_Page loginpage2 = Application.OpenForms["loginpage2"] as Login_Page;
        Form1 form1 = Application.OpenForms["form1"] as Form1;
        Form_OrderShipping form_OrderShipping = Application.OpenForms["form_OrderShipping"] as Form_OrderShipping;
        public DataTable dtAddress;
        public List<Button> buttonSelect = new List<Button>();
        public string edit { get; set; }


        public Form_SavedAddresses()
        {
            InitializeComponent();
            form1.sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=db_jawly");
            form1.sqlConnect.Open();
        }

        First_Form firstform = Application.OpenForms["firstform"] as First_Form;
        string username;
        private void Form_SavedAddresses_Load(object sender, EventArgs e)
        {
            username = form1.usernamenya;
            dtAddress = new DataTable();
            try
            {
                form1.sqlQuery = "SELECT id_alamat, nama_pemilik, alamat_lengkap, kec_alamat, kota_alamat, prov_alamat, kodepos_alamat, notelp_pemilik FROM alamat_user WHERE status_del1 = '1' AND nama_usern = '"+ username +"' ORDER BY 1;";
                form1.sqlCommand = new MySqlCommand(form1.sqlQuery, form1.sqlConnect);
                form1.sqlAdapter = new MySqlDataAdapter(form1.sqlCommand);
                form1.sqlAdapter.Fill(dtAddress);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (dtAddress.Rows.Count > 0)
            {
                Label label1 = new Label();
                label1.AutoSize = true;
                label1.MaximumSize = new Size(550, 0);
                label1.Text = $"{dtAddress.Rows[0][1]}\n{dtAddress.Rows[0][2]}, {dtAddress.Rows[0][3]}, {dtAddress.Rows[0][4]}, {dtAddress.Rows[0][5]}, {dtAddress.Rows[0][6]}\n{dtAddress.Rows[0][7]}";
                label1.Font = new Font("Ebrima", 10);
                label1.Location = new Point(12, 45);
                this.Controls.Add(label1);

                Button button_Select1 = new Button();
                button_Select1.Text = "SELECT";
                button_Select1.Font = new Font("Ebrima", 10, FontStyle.Bold);
                button_Select1.BackColor = Color.FromArgb(255, 240, 128, 128);
                button_Select1.ForeColor = Color.Linen;
                button_Select1.Size = new Size(80, 30);
                button_Select1.Location = new Point(label1.Left, label1.Bottom + 5);
                button_Select1.Tag = dtAddress.Rows[0][0].ToString();
                button_Select1.Click += button_Select_Click;
                buttonSelect.Add(button_Select1);
                this.Controls.Add(button_Select1);

                //Button button_Edit1 = new Button();
                //button_Edit1.Text = "EDIT";
                //button_Edit1.Font = new Font("Ebrima", 10, FontStyle.Bold);
                //button_Edit1.BackColor = Color.Linen;
                //button_Edit1.ForeColor = Color.FromArgb(255, 240, 128, 128);
                //button_Edit1.Size = new Size(80, 30);
                //button_Edit1.Location = new Point(button_Select1.Right + 5, label1.Bottom + 5);
                //button_Edit1.Tag = dtAddress.Rows[0][0].ToString();
                //button_Edit1.Click += button_Edit_Click;
                //this.Controls.Add(button_Edit1);

                if (dtAddress.Rows.Count > 1)
                {
                    for (int i = 1; i < dtAddress.Rows.Count; i++)
                    {
                        Panel panel_Line = new Panel();
                        panel_Line.Size = new Size(550, 1);
                        panel_Line.Location = new Point(buttonSelect[i - 1].Left, buttonSelect[i - 1].Bottom + 10);
                        panel_Line.BackColor = Color.FromArgb(255, 240, 128, 128);
                        this.Controls.Add(panel_Line);

                        Label label = new Label();
                        label.AutoSize = true;
                        label.MaximumSize = new Size(550, 0);
                        label.Text = $"{dtAddress.Rows[i][1]}\n{dtAddress.Rows[i][2]}, {dtAddress.Rows[i][3]}, {dtAddress.Rows[i][4]}, {dtAddress.Rows[i][5]}, {dtAddress.Rows[i][6]}\n{dtAddress.Rows[i][7]}";
                        label.Font = new Font("Ebrima", 10);
                        label.Location = new Point(12, panel_Line.Bottom + 10);
                        this.Controls.Add(label);

                        Button button_Select = new Button();
                        button_Select.Text = "SELECT";
                        button_Select.Font = new Font("Ebrima", 10, FontStyle.Bold);
                        button_Select.BackColor = Color.FromArgb(255, 240, 128, 128);
                        button_Select.ForeColor = Color.Linen;
                        button_Select.Size = new Size(80, 30);
                        button_Select.Location = new Point(label.Left, label.Bottom + 5);
                        button_Select.Tag = dtAddress.Rows[i][0].ToString();
                        button_Select.Click += button_Select_Click;
                        buttonSelect.Add(button_Select);
                        this.Controls.Add(button_Select);

                        //Button button_Edit = new Button();
                        //button_Edit.Text = "EDIT";
                        //button_Edit.Font = new Font("Ebrima", 10, FontStyle.Bold);
                        //button_Edit.BackColor = Color.Linen;
                        //button_Edit.ForeColor = Color.FromArgb(255, 240, 128, 128);
                        //button_Edit.Size = new Size(80, 30);
                        //button_Edit.Location = new Point(button_Select.Right + 5, label.Bottom + 5);
                        //button_Edit.Tag = dtAddress.Rows[i][0].ToString();
                        //button_Edit.Click += button_Edit_Click;
                        //this.Controls.Add(button_Edit);
                    }
                }
            }
        }

        //private void button_Edit_Click(object sender, EventArgs e)
        //{
        //    Button button = sender as Button;
        //    edit = button.Tag.ToString();
        //    this.Hide();
        //    Form_EditAddress form_EditAddress = new Form_EditAddress();
        //    form_EditAddress.Dock = DockStyle.Fill;
        //    form_EditAddress.TopLevel = false;
        //    form_EditAddress.ControlBox = false;
        //    form_EditAddress.FormBorderStyle = FormBorderStyle.None;
        //    form1.panel_Main.Controls.Add(form_EditAddress);
        //    form_EditAddress.Show();

        //    dtAddress = new DataTable();
        //    try
        //    {
        //        form1.sqlQuery = $"SELECT id_alamat, nama_pemilik, alamat_lengkap, kec_alamat, kota_alamat, prov_alamat, kodepos_alamat, notelp_pemilik\r\nFROM db_jawly.alamat_user\r\nWHERE status_del1 = '1' AND nama_usern = '{username}' AND id_alamat = '{button.Tag}'\r\nORDER BY 1;";
        //        form1.sqlCommand = new MySqlCommand(form1.sqlQuery, form1.sqlConnect);
        //        form1.sqlAdapter = new MySqlDataAdapter(form1.sqlCommand);
        //        form1.sqlAdapter.Fill(dtAddress);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }


        //    form_EditAddress.textBox_Name.Text = dtAddress.Rows[0][1].ToString();
        //    form_EditAddress.textBox_AddressDetail.Text = dtAddress.Rows[0][2].ToString();
        //    form_EditAddress.comboBox_Province.Text = dtAddress.Rows[0][5].ToString();
        //    form_EditAddress.comboBox_City.Text = dtAddress.Rows[0][4].ToString();
        //    form_EditAddress.textBox_PostCode.Text = dtAddress.Rows[0][6].ToString();
        //    form_EditAddress.textBox_Phonenum.Text = dtAddress.Rows[0][7].ToString();
        //    //MessageBox.Show(button.Tag.ToString());
        //}

        private void button_Select_Click(object sender, EventArgs e)
        {
            if (form_OrderShipping.select == "Sender")
            {
                Button button = sender as Button;
                //MessageBox.Show(button.Tag.ToString());
                this.Close();
                form_OrderShipping.Show();

                dtAddress = new DataTable();
                try
                {
                    form1.sqlQuery = $"SELECT id_alamat, nama_pemilik, alamat_lengkap, kec_alamat, kota_alamat, prov_alamat, kodepos_alamat, notelp_pemilik\r\nFROM db_jawly.alamat_user\r\nWHERE status_del1 = '1' AND nama_usern = '{username}' AND id_alamat = '{button.Tag}'\r\nORDER BY 1;";
                    form1.sqlCommand = new MySqlCommand(form1.sqlQuery, form1.sqlConnect);
                    form1.sqlAdapter = new MySqlDataAdapter(form1.sqlCommand);
                    form1.sqlAdapter.Fill(dtAddress);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                form_OrderShipping.textBox_Sender_Name.Text = dtAddress.Rows[0][1].ToString();
                form_OrderShipping.textBox_Sender_AddressDetail.Text = dtAddress.Rows[0][2].ToString();
                form_OrderShipping.textBox_Sender_Subdistrict.Text = dtAddress.Rows[0][3].ToString();
                form_OrderShipping.comboBox_Sender_Province.Text = dtAddress.Rows[0][5].ToString();
                form_OrderShipping.comboBox_Sender_City.Text = dtAddress.Rows[0][4].ToString();
                form_OrderShipping.textBox_Sender_PostCode.Text = dtAddress.Rows[0][6].ToString();
                form_OrderShipping.textBox_Sender_Phonenum.Text = dtAddress.Rows[0][7].ToString(); 
            }
            else if (form_OrderShipping.select == "Recipient")
            {
                Button button = sender as Button;
                //MessageBox.Show(button.Tag.ToString());
                this.Close();
                form_OrderShipping.Show();

                dtAddress = new DataTable();
                try
                {
                    form1.sqlQuery = $"SELECT id_alamat, nama_pemilik, alamat_lengkap, kec_alamat, kota_alamat, prov_alamat, kodepos_alamat, notelp_pemilik\r\nFROM db_jawly.alamat_user\r\nWHERE status_del1 = '1' AND nama_usern = '{username}' AND id_alamat = '{button.Tag}'\r\nORDER BY 1;";
                    form1.sqlCommand = new MySqlCommand(form1.sqlQuery, form1.sqlConnect);
                    form1.sqlAdapter = new MySqlDataAdapter(form1.sqlCommand);
                    form1.sqlAdapter.Fill(dtAddress);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                form_OrderShipping.textBox_Recipient_Name.Text = dtAddress.Rows[0][1].ToString();
                form_OrderShipping.textBox_Recipient_AddressDetail.Text = dtAddress.Rows[0][2].ToString();
                form_OrderShipping.comboBox_Recipient_Province.Text = dtAddress.Rows[0][5].ToString();
                form_OrderShipping.comboBox_Recipient_City.Text = dtAddress.Rows[0][4].ToString();
                form_OrderShipping.textBox_Recipient_Subdistrict.Text = dtAddress.Rows[0][3].ToString();
                form_OrderShipping.textBox_Recipient_PostCode.Text = dtAddress.Rows[0][6].ToString();
                form_OrderShipping.textBox_Recipient_Phonenum.Text = dtAddress.Rows[0][7].ToString();
            }
        }

        private void back_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.panel_Main.Controls.Add(form_OrderShipping);
            form_OrderShipping.Show();
        }

        private void back_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
