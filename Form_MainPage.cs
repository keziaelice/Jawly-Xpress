using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jawly_Design4
{
    public partial class Form_MainPage : Form
    {
        Form1 form1 = Application.OpenForms["form1"] as Form1;
        First_Form firstform = Application.OpenForms["firstform"] as First_Form;
        Form_OrderShipping form_OrderShipping = Application.OpenForms["form_OrderShipping"] as Form_OrderShipping;

        Form_ResiTransaksi fromtran = Application.OpenForms["formtran"] as Form_ResiTransaksi;

        public DataTable dtHistory;

        public Form_MainPage()
        {
            InitializeComponent();
            form1.sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=db_jawly");
            form1.sqlConnect.Open();
        }

        private void pictureBox_Menu_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox_Menu_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox_OrderShipping_Click(object sender, EventArgs e)
        {
            form1.panel_Main.Controls.Clear();
            Form_OrderShipping form_OrderShipping = new Form_OrderShipping();
            form_OrderShipping.Dock = DockStyle.Fill;
            form_OrderShipping.TopLevel = false;
            form_OrderShipping.ControlBox = false;
            form_OrderShipping.FormBorderStyle = FormBorderStyle.None;
            form1.panel_Main.Controls.Clear();
            form1.panel_Main.Controls.Add(form_OrderShipping);
            form_OrderShipping.Show();
        }

        private void pictureBox_ShippingRates_Click(object sender, EventArgs e)
        {
            form1.panel_Main.Controls.Clear();
            Form_ShippingRates shippingrates = new Form_ShippingRates();
            shippingrates.Dock = DockStyle.Fill;
            shippingrates.TopLevel = false;
            shippingrates.ControlBox = false;
            shippingrates.FormBorderStyle = FormBorderStyle.None;
            form1.panel_Main.Controls.Add(shippingrates);
            shippingrates.Show();
        }

        private void pictureBox_Tracking_Click(object sender, EventArgs e)
        {
            form1.panel_Main.Controls.Clear();
            Form_Tracking trackingpage = new Form_Tracking();
            trackingpage.Dock = DockStyle.Fill;
            trackingpage.TopLevel = false;
            trackingpage.ControlBox = false;
            trackingpage.FormBorderStyle = FormBorderStyle.None;
            form1.panel_Main.Controls.Add(trackingpage);
            trackingpage.Show();        
        }

        private void pictureBox_History_Click(object sender, EventArgs e)
        {
            dtHistory = new DataTable();
            try
            {
                form1.sqlQuery = $"SELECT * FROM (SELECT t.nomor_resi, t.tanggal_transaksi, a.nama_pemilik as 'Nama Pengirim', l1.kode_gateway as 'Gateaway Asal', a2.nama_pemilik as 'Nama Penerima', l2.kode_gateway as 'Gateway Tujuan', t.jenis_layanan, t.status_pengiriman\r\nFROM transaksi t, list_kota l1, alamat_user a, alamat_user a2, list_kota l2\r\nWHERE t.id_alamat_asal = a.id_alamat AND a.kota_alamat = l1.nama_kota\r\nAND t.id_alamat_tujuan = a2.id_alamat AND a2.kota_alamat = l2.nama_kota AND t.nama_username2 = '{form1.usernamenya}' GROUP BY 1,2,3,4, 5,6\nORDER BY 2 ASC) as a ;";
                form1.sqlCommand = new MySqlCommand(form1.sqlQuery, form1.sqlConnect);
                form1.sqlAdapter = new MySqlDataAdapter(form1.sqlCommand);
                form1.sqlAdapter.Fill(dtHistory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (dtHistory.Rows.Count > 0)
            {

                form1.panel_Main.Controls.Clear();
                Form_History historypage = new Form_History();
                historypage.Dock = DockStyle.Fill;
                historypage.TopLevel = false;
                historypage.ControlBox = false;
                historypage.FormBorderStyle = FormBorderStyle.None;
                form1.panel_Main.Controls.Add(historypage);
                historypage.Show();
            }
            else
            {

                form1.panel_Main.Controls.Clear();
                History_Page historypage = new History_Page();
                historypage.Dock = DockStyle.Fill;
                historypage.TopLevel = false;
                historypage.ControlBox = false;
                historypage.FormBorderStyle = FormBorderStyle.None;
                form1.panel_Main.Controls.Add(historypage);
                historypage.Show();
            }

        }

        private void pictureBox_Voucher_Click(object sender, EventArgs e)
        {
            form1.panel_Main.Controls.Clear();
            Form_Vouchers form_Vouchers = new Form_Vouchers();
            form_Vouchers.Dock = DockStyle.Fill;
            form_Vouchers.TopLevel = false;
            form_Vouchers.ControlBox = false;
            form_Vouchers.FormBorderStyle = FormBorderStyle.None;
            form1.panel_Main.Controls.Clear();
            form1.panel_Main.Controls.Add(form_Vouchers);
            form_Vouchers.Show();
        }

        private void pictureBox_Address_Click(object sender, EventArgs e)
        {
            form1.panel_Main.Controls.Clear();
            Form_SavedAddress_Main formaddress = new Form_SavedAddress_Main();
            formaddress.Dock = DockStyle.Fill;
            formaddress.TopLevel = false;
            formaddress.ControlBox = false;
            formaddress.FormBorderStyle = FormBorderStyle.None;
            form1.panel_Main.Controls.Clear();
            form1.panel_Main.Controls.Add(formaddress);
            formaddress.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void editAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1.panel_Main.Controls.Clear();
            Form_EditAccount editacc = new Form_EditAccount();
            editacc.Dock = DockStyle.Fill;
            editacc.TopLevel = false;
            editacc.ControlBox = false;
            editacc.FormBorderStyle = FormBorderStyle.None;
            form1.panel_Main.Controls.Clear();
            form1.panel_Main.Controls.Add(editacc);
            editacc.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Logout Account of " + form1.usernamenya + "?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                form1.Close();
                if (Form_OrderShipping.cek == "ada")
                {
                    form_OrderShipping.Close();
                }
               First_Form firstform = new First_Form();
                firstform.Show();
            }
        }

        private void pictureBox_settings_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox_settings_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox_Address_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox_Address_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
