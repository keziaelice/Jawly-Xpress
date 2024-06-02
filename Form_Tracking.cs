using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jawly_Design4
{
    public partial class Form_Tracking : Form
    {

        public DataTable dtcekresi = new DataTable();
        Form1 form1 = Application.OpenForms["form1"] as Form1;

        public Form_Tracking()
        {
            InitializeComponent();

            form1.sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=db_jawly");
            form1.sqlConnect.Open();
        }

        private void Form_Tracking_Load(object sender, EventArgs e)
        {

        }

        private void button_CheckRate_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            dtcekresi = new DataTable();
            form1.sqlConnect = new MySqlConnection(form1.connectionString);
            try
            {
                form1.sqlQuery = "SELECT status_pengiriman FROM TRANSAKSI WHERE nomor_resi = '" + textBox_cekresi.Text + "';";
                form1.sqlCommand = new MySqlCommand(form1.sqlQuery, form1.sqlConnect);
                form1.sqlAdapter = new MySqlDataAdapter(form1.sqlCommand);
                form1.sqlAdapter.Fill(dtcekresi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Waybill Number is not found! Please recheck your waybill", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (dtcekresi.Rows.Count > 0)
            {
                try
                {
                    form1.sqlQuery = "SELECT keterangan FROM STATUS_BARANG WHERE id_status BETWEEN 'S1' AND '" + dtcekresi.Rows[0][0] + "';";
                    form1.sqlCommand = new MySqlCommand(form1.sqlQuery, form1.sqlConnect);
                    form1.sqlAdapter = new MySqlDataAdapter(form1.sqlCommand);

                    dtcekresi = new DataTable();
                    form1.sqlAdapter.Fill(dtcekresi);

                    for (int i = 0; i < dtcekresi.Rows.Count; i++)
                    {
                        label1.Text += dtcekresi.Rows[i][0].ToString() + "\n\n\n";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Waybill Number is not found! Please recheck your waybill", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_cekresi_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_cekresi.Text))
            {
                button_CheckRate.Enabled = true;
            }
        }
    }
}
