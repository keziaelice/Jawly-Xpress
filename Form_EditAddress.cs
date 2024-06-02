using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Jawly_Design4
{
    public partial class Form_EditAddress : Form
    {
        Form1 form1 = Application.OpenForms["form1"] as Form1;
        First_Form firstform = Application.OpenForms["firstform"] as First_Form;
        Form_SavedAddresses form_SavedAddresses = Application.OpenForms["form_SavedAddresses"] as Form_SavedAddresses;
        public DataTable dtProvince;
        public DataTable dtCity;
        public Form_EditAddress()
        {
            InitializeComponent();
        }

        private void executeSQL(string command)
        {
            try
            {
                firstform.sqlConnect.Open();
                firstform.sqlCommand = new MySqlCommand(command, firstform.sqlConnect);
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
        }

        private void back_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            form_SavedAddresses.Show();
        }

        private void back_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void Form_EditAddress_Load(object sender, EventArgs e)
        {
            button_Save.BackColor = Color.FromArgb(255, 240, 128, 128);
            button_Save.ForeColor = Color.Linen;

            dtProvince = new DataTable();
            try
            {
                firstform.sqlQuery = "SELECT provinsi AS `Province`\r\nFROM db_jawly.list_kota\r\nGROUP BY provinsi;";
                firstform.sqlCommand = new MySqlCommand(firstform.sqlQuery, firstform.sqlConnect);
                firstform.sqlAdapter = new MySqlDataAdapter(firstform.sqlCommand);
                firstform.sqlAdapter.Fill(dtProvince);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            comboBox_Province.DataSource = dtProvince;
            comboBox_Province.DisplayMember = "Province";
            comboBox_Province.SelectedItem = null;
        }

        private void comboBox_Province_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Province.SelectedItem != null)
            {
                //MessageBox.Show(comboBox_Sender_Province.SelectedIndex.ToString());
                string province = comboBox_Province.Text.ToString();
                dtCity = new DataTable();
                try
                {
                    firstform.sqlQuery = $"SELECT nama_kota AS `City`\r\nFROM db_jawly.list_kota\r\nWHERE provinsi = '{province}';";
                    firstform.sqlCommand = new MySqlCommand(firstform.sqlQuery, firstform.sqlConnect);
                    firstform.sqlAdapter = new MySqlDataAdapter(firstform.sqlCommand);
                    firstform.sqlAdapter.Fill(dtCity);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                comboBox_City.DataSource = dtCity;
                comboBox_City.DisplayMember = "City";
                comboBox_City.ValueMember = "City";
                comboBox_City.SelectedItem = null;
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(form_SavedAddresses.edit.ToString());

            //form1.sqlQuery = $"UPDATE alamat_user\r\nSET nama_pemilik = '{textBox_Name.Text}', notelp_pemilik = '{textBox_Phonenum.Text}', prov_alamat = '{comboBox_Province.Text}', kota_alamat = '{comboBox_City.Text}', kec_alamat = 'Coblong', kodepos_alamat = '12345', alamat_lengkap = 'Jalan Raya Menganti No. 45', status_del1 = 1\r\nWHERE id_alamat = 'AB001';";
            //executeSQL(form1.sqlQuery);

            //form1.panel_Main.Controls.Clear();
            //Form_SavedAddresses form_SavedAddresses = new Form_SavedAddresses();
            //form_SavedAddresses.Dock = DockStyle.Fill;
            //form_SavedAddresses.TopLevel = false;
            //form_SavedAddresses.ControlBox = false;
            //form_SavedAddresses.FormBorderStyle = FormBorderStyle.None;
            //form1.panel_Main.Controls.Clear();
            //form1.panel_Main.Controls.Add(form_SavedAddresses);
            //form_SavedAddresses.Show();


        }
    }
}
