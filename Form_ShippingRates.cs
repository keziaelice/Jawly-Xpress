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
    public partial class Form_ShippingRates : Form
    {
        DataTable shippingfrom = new DataTable();
        public Form1 firstform = new Form1();
        public Form_ShippingRates()
        {
            InitializeComponent();

            firstform.sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=db_jawly");
            firstform.sqlConnect.Open();
        }

        private void Form_ShippingRates_Load(object sender, EventArgs e)
        {
            //ISI COMBOBOX FROM
            shippingfrom = new DataTable();
            firstform.sqlQuery = "SELECT nama_kota, provinsi FROM LIST_KOTA;";
            firstform.sqlCommand = new MySqlCommand(firstform.sqlQuery, firstform.sqlConnect);
            firstform.sqlAdapter = new MySqlDataAdapter(firstform.sqlCommand);
            firstform.sqlAdapter.Fill(shippingfrom);
            combobox_cityfrom.DataSource = shippingfrom;
            combobox_cityfrom.DisplayMember = "nama_kota";
            combobox_cityfrom.ValueMember = "provinsi";

            //ISI COMBOBOX TO
            shippingfrom = new DataTable();
            firstform.sqlQuery = "SELECT nama_kota, provinsi FROM LIST_KOTA;";
            firstform.sqlCommand = new MySqlCommand(firstform.sqlQuery, firstform.sqlConnect);
            firstform.sqlAdapter = new MySqlDataAdapter(firstform.sqlCommand);
            firstform.sqlAdapter.Fill(shippingfrom);
            comboBox_cityto.DataSource = shippingfrom;
            comboBox_cityto.DisplayMember = "nama_kota";
            comboBox_cityto.ValueMember = "provinsi";

            combobox_cityfrom.Text = "";
            comboBox_cityto.Text = string.Empty;
        }

        private void textBox4_height_TextChanged(object sender, EventArgs e)
        {
            CheckDimensionalKG();
            UpdateButtonShippingRates();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sometimes a packages with less weight can occupy more space regarding of the size. " +
                "That's being said, the shipping rates is determined according to the weight or size of the packages. " +
                "Furthermore, the packages with volumetric size will be calculated by the weight, length, width, and the " +
                "height of the packages. So, if the dimensional weight is greater than the original weight, then we will take the highest which is dimensional weight.", 
                "Dimension Explanation", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void textBox3_weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void textBox4_height_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void textBox5_width_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void textBox6_length_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void textBox6_length_TextChanged(object sender, EventArgs e)
        {
            CheckDimensionalKG();
            UpdateButtonShippingRates();
        }


        double hasil;
        private void CheckDimensionalKG()
        {
            if (!string.IsNullOrEmpty(textBox4_height.Text) && !string.IsNullOrEmpty(textBox5_width.Text) &&
                !string.IsNullOrEmpty(textBox6_length.Text))
            {
                double t = Convert.ToDouble(textBox4_height.Text);
                double p = Convert.ToDouble(textBox6_length.Text);
                double l = Convert.ToDouble(textBox5_width.Text);
                hasil = (p * l * t) / 6000;
                if (hasil <= 50)
                {
                    label_DimensionKG.Text = hasil.ToString()+ " KG";
                }
                else
                {
                    MessageBox.Show("The dimensional weight cannot be more than 50 KG!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    textBox4_height.Text = "";
                    textBox5_width.Text = "";
                    textBox6_length.Text = "";
                }
            }
            else
            {
                label_DimensionKG.Text = "0.0 KG";
            }
        }

        private void textBox5_width_TextChanged(object sender, EventArgs e)
        {
            CheckDimensionalKG();
            UpdateButtonShippingRates();
        }

        private void textBox3_weight_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox3_weight.Text))
            {
                if (Convert.ToInt32(textBox3_weight.Text) > 50)
                {
                    MessageBox.Show("The weight cannot be more than 50 KG!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    textBox3_weight.Text = "0";
                }
            }
        }

        private void UpdateButtonShippingRates()
        {
            if (!string.IsNullOrEmpty(textBox3_weight.Text) && !string.IsNullOrEmpty(textBox4_height.Text)
                && !string.IsNullOrEmpty(textBox5_width.Text) && !string.IsNullOrEmpty(textBox6_length.Text)
                && !string.IsNullOrEmpty(combobox_cityfrom.Text) && !string.IsNullOrEmpty(comboBox_cityto.Text))
            {
                button_CheckRate.Enabled = true;
            }
            else
            {
                button_CheckRate.Enabled = false;
            }
        }

        private void combobox_cityfrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonShippingRates();
        }

        private void comboBox_cityto_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonShippingRates();
        }

        int shippingratejaw;
        int shippingratewly;
        private void button_CheckRate_Click(object sender, EventArgs e)
        {
            label_service1.Text = "Service";
            label_weight1.Text = "Weight";
            label_shipping1.Text = "Shipping Rate";
            string weightbarang;
            shippingfrom = new DataTable();
            firstform.sqlQuery = "SELECT b.prov_asal, b.prov_tujuan, b.jenis_layanan, b.harga FROM BIAYA_ONGKIR b WHERE prov_asal = '" + combobox_cityfrom.SelectedValue + "' AND prov_tujuan = '" + comboBox_cityto.SelectedValue+ "';";
            firstform.sqlCommand = new MySqlCommand(firstform.sqlQuery, firstform.sqlConnect);
            firstform.sqlAdapter = new MySqlDataAdapter(firstform.sqlCommand);
            firstform.sqlAdapter.Fill(shippingfrom);

            label_service1.Text += "\n\n" + shippingfrom.Rows[0][2].ToString() + " (3 - 5 Days)\n\n" + shippingfrom.Rows[1][2].ToString() + " (1 - 3 Days)";
            
            if(hasil > Convert.ToInt32(textBox3_weight.Text))
            {
                weightbarang = hasil.ToString();

                int cek = Convert.ToInt32(hasil) + 1;

                shippingratejaw = Convert.ToInt32(shippingfrom.Rows[0][3]) * Convert.ToInt32(cek);
                shippingratewly = Convert.ToInt32(shippingfrom.Rows[1][3]) * Convert.ToInt32(cek);
            }
            else
            {
                weightbarang = textBox3_weight.Text;
                shippingratejaw = Convert.ToInt32(shippingfrom.Rows[0][3]) * Convert.ToInt32(weightbarang);
                shippingratewly = Convert.ToInt32(shippingfrom.Rows[1][3]) * Convert.ToInt32(weightbarang);
            }

            label_weight1.Text += " \n\n" + weightbarang + " KG\n\n" + weightbarang + " KG";
            label_shipping1.Text += "\n\nRp. " + shippingratejaw.ToString() + "\n\nRp. " + shippingratewly.ToString();
        }
    }
}
