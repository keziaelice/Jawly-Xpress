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
using System.Xml;

namespace Jawly_Design4
{
    public partial class Form_ResiTransaksi : Form
    {
        public Form_PickUpTime formship = Application.OpenForms["formship"] as Form_PickUpTime;
        public Form1 form1 = Application.OpenForms["form1"] as Form1;

        string noresi;
        string alsend;
        string alrecip;
        string berat;
        string ongkir;
        string jenis;
        public Form_ResiTransaksi(string _noresi, string _alsend, string _alrecip, string _berat, string _ongkir, string _jenis)
        {
            InitializeComponent(); 
             noresi = _noresi;
             alsend = _alsend;
             alrecip = _alrecip;
             berat = _berat;
             ongkir = _ongkir;
             jenis = _jenis;
        }

        private void label_alamatsender_Click(object sender, EventArgs e)
        {

        }
        string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
        private void Form_ResiTransaksi_Load(object sender, EventArgs e)
        {
            label_alamatrecipient.Text = alrecip;
            label_alamatsender.Text = alsend;
            label_noresi.Text = noresi;
            label_jenisbarang.Text = jenis;
            label_weightandlayanan.Text = berat;
            label_harga.Text = ongkir;


            string MysQlCommand2 = $"INSERT INTO ALAMAT_USER VALUE ('{Form_OrderShipping.id_asal}', '{Form_OrderShipping.namasender}', '{form1.usernamenya}', '{Form_OrderShipping.notelpsender}', '{Form_OrderShipping.prov_alamat_sender}', '{Form_OrderShipping.kota_alamat_sender}', '{Form_OrderShipping.kec_alamat_sender}', '{Form_OrderShipping.kodepos_alamat_sender}', '{Form_OrderShipping.alamat_lengkap_sender}', 1);";
            try
            {
                form1.sqlCommand = new MySqlCommand(MysQlCommand2, form1.sqlConnect);
                form1.sqlReader = form1.sqlCommand.ExecuteReader();

            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                form1.sqlConnect.Close();
            }

            string MysQlCommand3 = $"INSERT INTO ALAMAT_USER VALUE ('{Form_OrderShipping.id_tujuan}', '{Form_OrderShipping.namareci}', '{form1.usernamenya}', '{Form_OrderShipping.notelpreci}', '{Form_OrderShipping.prov_alamat_reci}', '{Form_OrderShipping.kota_alamat_reci}', '{Form_OrderShipping.kec_alamat_reci}', " +
                $"'{Form_OrderShipping.kodepos_alamat_reci}', '{Form_OrderShipping.alamat_lengkap_reci}', 1);";
            try
            {
                form1.sqlConnect.Open();
                form1.sqlCommand = new MySqlCommand(MysQlCommand3, form1.sqlConnect);
                form1.sqlReader = form1.sqlCommand.ExecuteReader();

            }
            catch (Exception ex)
            {
       
            }
            finally
            {
                form1.sqlConnect.Close();
            }

            string MysQlCommand = $"INSERT INTO TRANSAKSI VALUE ('{noresi}', '{form1.usernamenya}', '{currentDate}', '{Form_OrderShipping.id_asal}', '{Form_OrderShipping.id_tujuan}', " +
                $"'{jenis}', '{Form_OrderShipping.berat}', '{Form_OrderShipping.volume_barang}', '{Form_OrderShipping.jenis_layanan}', '{Form_OrderShipping.idstatus_pengiriman}', '{Form_PickUpTime.tgl}', '{Form_PickUpTime.jam}', '{Form_OrderShipping.id_voucher}'," +
                $"'{Form_OrderShipping.ongkos_kirim}', '{Form_OrderShipping.notes_utk_kurir}', 1);";
            try
            {
                form1.sqlConnect.Open();
                form1.sqlCommand = new MySqlCommand(MysQlCommand, form1.sqlConnect);
                form1.sqlReader = form1.sqlCommand.ExecuteReader();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                form1.sqlConnect.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.panel_Main.Controls.Clear();
            Form_MainPage ha = new Form_MainPage();
            ha.TopLevel = false;
            ha.Dock = DockStyle.Fill;
            ha.FormBorderStyle = FormBorderStyle.None;
            form1.panel_Main.Controls.Add(ha);
            ha.Show();
        }
    }
}
