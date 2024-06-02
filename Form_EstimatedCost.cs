using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jawly_Design4
{
    public partial class Form_PickUpTime : Form
    {

        public Form_OrderShipping formship = Application.OpenForms["formship"] as Form_OrderShipping;

        string noresi;
        string alsend;
        string alrecip;
        string berat;
        string ongkir;
        string jenis;
        public static string tgl;
        public static string jam;
        public Form_PickUpTime(string _noresi, string _alsend, string _alrecip, string _berat, string _ongkir, string _jenis)
        {
            InitializeComponent();
             noresi = _noresi;
             alsend = _alsend;
             alrecip = _alrecip;
             berat = _berat;
             ongkir = _ongkir;
             jenis = _jenis;
        }
        DateTime tanggal = DateTime.Now;
        
        private void Form_EstimatedCost_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(255, 255, 206, 201);

            //tanggal = DateTime.Now.ToLongDateString();
            for (int i = 1; i < 6; i++)
            {
                tanggal = tanggal.AddDays(1);
                comboBox1.Items.Add(tanggal.ToString("yyyy-MM-dd"));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tgl = comboBox1.Text;
            string[] jam2 = comboBox2.Text.Split(':');
            jam = jam2[0] + jam2[1];
            Form_ResiTransaksi resi = new Form_ResiTransaksi( noresi, alsend, alrecip, berat,  ongkir,  jenis);
            this.Close();
            resi.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrEmpty(comboBox2.Text))
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrEmpty(comboBox2.Text))
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }
    }
}
