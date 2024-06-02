using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Jawly_Design4
{
    public partial class Form_HistoryDetails : Form
    {
        Form1 form1 = Application.OpenForms["form1"] as Form1;
        Form_History form_History = Application.OpenForms["form_History"] as Form_History;
        string resi;
        public DataTable dtHistory;
        public DataTable dtStatus;
        public DataTable dtAlamatAsal;
        public DataTable dtAlamatTujuan;
        int weight;

        public Form_HistoryDetails(string _resi)
        {
            resi = _resi;
            InitializeComponent();
        }

        public static string ToRupiah(int num)
        {
            return String.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", num);
        }

        private void Form_HistoryDetails_Load(object sender, EventArgs e)
        {
            panel_Line1.BackColor = Color.Black;
            panel_Line2.BackColor = Color.Black;
            //MessageBox.Show(resi);
            dtHistory = new DataTable();
            try
            {
                form1.sqlQuery = $"SELECT nomor_resi, tanggal_transaksi, id_alamat_asal, id_alamat_tujuan, jenis_barang, berat_barang, volume_barang, jenis_layanan, status_pengiriman, ongkos_kirim\r\nFROM transaksi\r\nWHERE nomor_resi = '{resi}';";
                form1.sqlCommand = new MySqlCommand(form1.sqlQuery, form1.sqlConnect);
                form1.sqlAdapter = new MySqlDataAdapter(form1.sqlCommand);
                form1.sqlAdapter.Fill(dtHistory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dtStatus = new DataTable();
            try
            {
                form1.sqlQuery = $"SELECT keterangan FROM db_jawly.status_barang WHERE id_status = '{dtHistory.Rows[0][8]}';";
                form1.sqlCommand = new MySqlCommand(form1.sqlQuery, form1.sqlConnect);
                form1.sqlAdapter = new MySqlDataAdapter(form1.sqlCommand);
                form1.sqlAdapter.Fill(dtStatus);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if ((Convert.ToInt32(dtHistory.Rows[0][6]) / 6000) > Convert.ToInt32(dtHistory.Rows[0][5]))
            {
                weight = Convert.ToInt32(dtHistory.Rows[0][6]) / 6000;
            }
            else
            {
                weight = Convert.ToInt32(dtHistory.Rows[0][5]);
            }
            label_Waybills.Text = ": " + dtHistory.Rows[0][0].ToString();
            DateTime tgl = Convert.ToDateTime(dtHistory.Rows[0][1]);
            string tanggal = tgl.ToString("dd/MM/yyyy");
            label_OrderDate.Text = ": " + tanggal.Substring(0, 10);
            label_ServiceType.Text = ": " + dtHistory.Rows[0][7].ToString();
            label_Status.Text = ": " + dtStatus.Rows[0][0].ToString();
            label_Item.Text = ": " + dtHistory.Rows[0][4].ToString() + " (" + weight.ToString() + " kg)";
            label_ShippingCost.Text = ": " + ToRupiah(Convert.ToInt32(dtHistory.Rows[0][9]));

            string idAsal = dtHistory.Rows[0][2].ToString();
            string idTujuan = dtHistory.Rows[0][3].ToString();
            dtAlamatAsal = new DataTable();
            try
            {
                form1.sqlQuery = $"SELECT nama_pemilik, notelp_pemilik, prov_alamat, kota_alamat, kec_alamat, kodepos_alamat, alamat_lengkap\r\nFROM alamat_user\r\nWHERE id_alamat = '{idAsal}';";
                form1.sqlCommand = new MySqlCommand(form1.sqlQuery, form1.sqlConnect);
                form1.sqlAdapter = new MySqlDataAdapter(form1.sqlCommand);
                form1.sqlAdapter.Fill(dtAlamatAsal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dtAlamatTujuan = new DataTable();
            try
            {
                form1.sqlQuery = $"SELECT nama_pemilik, notelp_pemilik, prov_alamat, kota_alamat, kec_alamat, kodepos_alamat, alamat_lengkap\r\nFROM alamat_user\r\nWHERE id_alamat = '{idTujuan}';";
                form1.sqlCommand = new MySqlCommand(form1.sqlQuery, form1.sqlConnect);
                form1.sqlAdapter = new MySqlDataAdapter(form1.sqlCommand);
                form1.sqlAdapter.Fill(dtAlamatTujuan);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            label_Sender_Name.Text = dtAlamatAsal.Rows[0][0].ToString();
            label_Sender_PhoneNum.Text = dtAlamatAsal.Rows[0][1].ToString();
            label_Sender_Address.Text = $"{dtAlamatAsal.Rows[0][6]}, {dtAlamatAsal.Rows[0][4]}, {dtAlamatAsal.Rows[0][3]}, {dtAlamatAsal.Rows[0][2]}, {dtAlamatAsal.Rows[0][5]}";
            label_Recipient_Name.Text = dtAlamatTujuan.Rows[0][0].ToString();
            label_Recipient_PhoneNum.Text = dtAlamatTujuan.Rows[0][1].ToString();
            label_Recipient_Address.Text = $"{dtAlamatTujuan.Rows[0][6]}, {dtAlamatTujuan.Rows[0][4]}, {dtAlamatTujuan.Rows[0][3]}, {dtAlamatTujuan.Rows[0][2]}, {dtAlamatTujuan.Rows[0][5]}";

        }

        private void back_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_History form_History = new Form_History();
            form_History.Dock = DockStyle.Fill;
            form_History.TopLevel = false;
            form_History.ControlBox = false;
            form_History.FormBorderStyle = FormBorderStyle.None;
            form1.panel_Main.Controls.Clear();
            form1.panel_Main.Controls.Add(form_History);
            form_History.Show();
        }

        private void back_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
