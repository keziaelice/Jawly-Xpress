using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Jawly_Design4
{
    public partial class Form_OrderShipping : Form
    {
       public Form1 firstforma = Application.OpenForms["form1"] as Form1;
        public Form1 firstform = new Form1();
        public First_Form firstform2 = Application.OpenForms["firstform"] as First_Form;
        public DataTable dtProvince_Sender;
        public DataTable dtCity_Sender;
        public DataTable dtProvince_Recipient;
        public DataTable dtCity_Recipient;
        public DataTable dtVoucher;

        public string nomorresi;
        public string alamat_sender;
        public string alamat_recip;
        public string nama_sender;
        public string nama_recip;
        public string beratbarang;
        public string totalbiaya;
        public string jenisbarang;
        public static string id_asal;
        public static string id_tujuan;
        public static string berat;
        public static string volume_barang;
        public static string idstatus_pengiriman;
        public static string id_voucher = "";
        public static string ongkos_kirim;
        public static string notes_utk_kurir;
        public static string jenis_layanan;
        public static string cek;

        public static string prov_alamat_sender;
        public static string kota_alamat_sender;
        public static string kec_alamat_sender;
        public static string kodepos_alamat_sender;
        public static string alamat_lengkap_sender;

        public static string prov_alamat_reci;
        public static string kota_alamat_reci;
        public static string kec_alamat_reci;
        public static string kodepos_alamat_reci;
        public static string alamat_lengkap_reci;

        public string select { get; set; }
        public Form_OrderShipping()
        {
            InitializeComponent();
            firstform.sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=db_jawly");
            firstform.sqlConnect.Open();
        }

        private void Form_OrderShipping_Load(object sender, EventArgs e)
        {
            cek = "ada";
            select = "";

            label_Required.ForeColor = Color.FromArgb(255, 244, 115, 126);
            panel_Line_Sender.BackColor = Color.FromArgb(255, 255, 206, 201);
            panel_Line_Recipient.BackColor = Color.FromArgb(255, 255, 206, 201);
            panel_Line_Package.BackColor = Color.FromArgb(255, 255, 206, 201);

            dtProvince_Sender = new DataTable();
            try
            {
                firstform.sqlQuery = "SELECT provinsi AS `Province`\r\nFROM db_jawly.list_kota\r\nGROUP BY provinsi;";
                firstform.sqlCommand = new MySqlCommand(firstform.sqlQuery, firstform.sqlConnect);
                firstform.sqlAdapter = new MySqlDataAdapter(firstform.sqlCommand);
                firstform.sqlAdapter.Fill(dtProvince_Sender);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            comboBox_Sender_Province.DataSource = dtProvince_Sender;
            comboBox_Sender_Province.DisplayMember = "Province";
            comboBox_Sender_Province.ValueMember = "Province";
            comboBox_Sender_Province.SelectedItem = null;

            dtProvince_Recipient = new DataTable();
            try
            {
                firstform.sqlQuery = "SELECT provinsi AS `Province`\r\nFROM list_kota\r\nGROUP BY provinsi;";
                firstform.sqlCommand = new MySqlCommand(firstform.sqlQuery, firstform.sqlConnect);
                firstform.sqlAdapter = new MySqlDataAdapter(firstform.sqlCommand);
                firstform.sqlAdapter.Fill(dtProvince_Recipient);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            comboBox_Recipient_Province.DataSource = dtProvince_Recipient;
            comboBox_Recipient_Province.DisplayMember = "Province";
            comboBox_Recipient_Province.ValueMember = "Province";
            comboBox_Recipient_Province.SelectedItem = null;
        }

        private void label_Sender_SavedAddresses_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void label_Sender_SavedAddresses_Click(object sender, EventArgs e)
        {
            select = "Sender";
            this.Hide();
            //form1.panel_Main.Controls.Clear();
            Form_SavedAddresses form_SavedAddresses = new Form_SavedAddresses();
            form_SavedAddresses.Dock = DockStyle.Fill;
            form_SavedAddresses.TopLevel = false;
            form_SavedAddresses.ControlBox = false;
            form_SavedAddresses.FormBorderStyle = FormBorderStyle.None;
            //firstform.panel_Main.Controls.Clear();
            firstforma.panel_Main.Controls.Add(form_SavedAddresses);
            form_SavedAddresses.Show();
        }

        private void label_Sender_SavedAddresses_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void label_Recipient_SavedAddresses_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void label_Recipient_SavedAddresses_Click(object sender, EventArgs e)
        {
            select = "Recipient";
            this.Hide();
            //form1.panel_Main.Controls.Clear();
            Form_SavedAddresses form_SavedAddresses = new Form_SavedAddresses();
            form_SavedAddresses.Dock = DockStyle.Fill;
            form_SavedAddresses.TopLevel = false;
            form_SavedAddresses.ControlBox = false;
            form_SavedAddresses.FormBorderStyle = FormBorderStyle.None;
            //form1.panel_Main.Controls.Clear();
            firstforma.panel_Main.Controls.Add(form_SavedAddresses);
            form_SavedAddresses.Show();
        }

        private void label_Recipient_SavedAddresses_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
        int berapakilo;
        int hasil;
        int hargaongkir;
        string currentDate = DateTime.Now.ToString("yyMMdd");
        Form_PickUpTime formpickup = Application.OpenForms["formpickup"] as Form_PickUpTime;
        int harga;
        public static string namasender;
        public static string namareci;
        public static string notelpsender;
        public static string notelpreci;
        private void button_Next_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_Sender_Name.Text) ||
                !string.IsNullOrEmpty(textBox_Sender_Subdistrict.Text) ||
                !string.IsNullOrEmpty(textBox_Sender_Phonenum.Text) ||
                !string.IsNullOrEmpty(textBox_Sender_AddressDetail.Text) ||
                !string.IsNullOrEmpty(comboBox_Sender_Province.Text) ||
                !string.IsNullOrEmpty(comboBox_Sender_City.Text) ||
                !string.IsNullOrEmpty(textBox_Sender_PostCode.Text) ||
                !string.IsNullOrEmpty(textBox_Recipient_Name.Text) ||
                !string.IsNullOrEmpty(textBox_Recipient_Subdistrict.Text) ||
                !string.IsNullOrEmpty(textBox_Recipient_Phonenum.Text) ||
                !string.IsNullOrEmpty(textBox_Recipient_AddressDetail.Text) ||
                !string.IsNullOrEmpty(comboBox_Recipient_Province.Text) ||
                !string.IsNullOrEmpty(comboBox_Recipient_City.Text) ||
                !string.IsNullOrEmpty(textBox_Recipient_PostCode.Text) ||
                !string.IsNullOrEmpty(comboBox_Package_ItemType.Text) ||
                !string.IsNullOrEmpty(textBox_Package_Weight.Text) ||
                !string.IsNullOrEmpty(textBox_Package_Length.Text) ||
                !string.IsNullOrEmpty(textBox_Package_Width.Text) ||
                !string.IsNullOrEmpty(textBox_Package_Height.Text) ||
                !string.IsNullOrEmpty(comboBox_Package_ServiceType.Text))
            {
                //QUERY BUAT CEK NOMOR URUT RESI
                try
                {
                    dtProvince_Recipient = new DataTable();
                    firstform.sqlQuery = $"SELECT nomor_resi FROM TRANSAKSI WHERE nomor_resi = '%{comboBox_Package_ServiceType.Text.Substring(0, 1) + currentDate}%'";
                    firstform.sqlCommand = new MySqlCommand(firstform.sqlQuery, firstform.sqlConnect);
                    firstform.sqlAdapter = new MySqlDataAdapter(firstform.sqlCommand);
                    firstform.sqlAdapter.Fill(dtProvince_Recipient);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                int rows = dtProvince_Recipient.Rows.Count + 1;

                string nomorFormat = rows.ToString("D4");
             

                //KELUAR ESTIMASI HARGA 
                dtProvince_Sender = new DataTable();
                firstform.sqlQuery = "SELECT harga FROM BIAYA_ONGKIR WHERE prov_asal = '" + comboBox_Sender_Province.SelectedValue + "' AND prov_tujuan = '" + comboBox_Recipient_Province.SelectedValue + "' AND jenis_layanan = '" + comboBox_Package_ServiceType.Text.Substring(0,3) + "';";
                firstform.sqlCommand = new MySqlCommand(firstform.sqlQuery, firstform.sqlConnect);
                firstform.sqlAdapter = new MySqlDataAdapter(firstform.sqlCommand);
                firstform.sqlAdapter.Fill(dtProvince_Sender);

                hasil = (Convert.ToInt32(textBox_Package_Height.Text) * Convert.ToInt32(textBox_Package_Length.Text) * Convert.ToInt32(textBox_Package_Width.Text)) / 6000;
                
                if (hasil > Convert.ToInt32(textBox_Package_Weight.Text))
                {
                    int cek = Convert.ToInt32(hasil) + 1;
                    berapakilo = cek;
                }
                else
                {
                    berapakilo = Convert.ToInt32(textBox_Package_Weight.Text);
                }
                harga = berapakilo * Convert.ToInt32(dtProvince_Sender.Rows[0][0].ToString());
                hargaongkir = berapakilo * Convert.ToInt32(dtProvince_Sender.Rows[0][0].ToString());

                //VOUCHERRRRRRRRRR
                if (!string.IsNullOrEmpty(textBox_Package_Voucher.Text))
                {
                    try
                    {
                        dtVoucher = new DataTable();
                        firstform.sqlQuery = $"SELECT * FROM VOUCHER_DISKON WHERE kode_voucher = '{textBox_Package_Voucher.Text}'";
                        firstform.sqlCommand = new MySqlCommand(firstform.sqlQuery, firstform.sqlConnect);
                        firstform.sqlAdapter = new MySqlDataAdapter(firstform.sqlCommand);
                        firstform.sqlAdapter.Fill(dtVoucher);

                        id_voucher = dtVoucher.Rows[0][0].ToString();
                        int diskonpersen = Convert.ToInt32(dtVoucher.Rows[0][2]);

                        int makspot = Convert.ToInt32(dtVoucher.Rows[0][3]);

                        int diskon = harga * diskonpersen / 100;
                        if (diskon > makspot)
                        {
                            diskon = makspot;
                        }

                        hargaongkir = harga - diskon;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid Voucher!");
                    }

                }
                //NGISI DATA BUAT RESI
                nomorresi = comboBox_Package_ServiceType.Text.Substring(0, 1) + currentDate + nomorFormat;
                alamat_sender = textBox_Sender_Name.Text + "  |  " + textBox_Sender_Phonenum.Text + "\n" + textBox_Sender_AddressDetail.Text + " ," + textBox_Sender_Subdistrict.Text + " ," + comboBox_Sender_City.Text
                     + " ," + comboBox_Sender_Province.Text + " ," + textBox_Sender_PostCode.Text;
                alamat_recip = textBox_Recipient_Name.Text + "  |  " + textBox_Sender_Phonenum.Text + "\n" + textBox_Recipient_AddressDetail.Text + " ," + textBox_Recipient_Subdistrict.Text + " ," + comboBox_Recipient_City.Text
                     + " ," + comboBox_Recipient_Province.Text + " ," + textBox_Recipient_PostCode.Text;

                beratbarang = berapakilo.ToString() + " KG";
                totalbiaya = "Rp. " + hargaongkir;
                jenisbarang = comboBox_Package_ItemType.Text;
                jenis_layanan = comboBox_Package_ServiceType.Text.Substring(0, 3);


                //QUERY BUAT CEK NOMOR URUT ALAMAT
                try
                {
                    dtProvince_Recipient = new DataTable();
                    firstform.sqlQuery = $"SELECT id_alamat FROM ALAMAT_USER WHERE id_alamat = '%{textBox_Sender_Name.Text.Substring(0,2).ToUpper()}%'";
                    firstform.sqlCommand = new MySqlCommand(firstform.sqlQuery, firstform.sqlConnect);
                    firstform.sqlAdapter = new MySqlDataAdapter(firstform.sqlCommand);
                    firstform.sqlAdapter.Fill(dtProvince_Recipient);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                int rows2 = dtProvince_Recipient.Rows.Count + 1;

                string nomorFormat2 = rows2.ToString("D3");
                id_asal = textBox_Sender_Name.Text.Substring(0, 2).ToUpper ()+ nomorFormat2.ToString();


                try
                {
                    dtProvince_Recipient = new DataTable();
                    firstform.sqlQuery = $"SELECT id_alamat FROM ALAMAT_USER WHERE id_alamat = '%{textBox_Recipient_Name.Text.Substring(0, 2).ToUpper()}%'";
                    firstform.sqlCommand = new MySqlCommand(firstform.sqlQuery, firstform.sqlConnect);
                    firstform.sqlAdapter = new MySqlDataAdapter(firstform.sqlCommand);
                    firstform.sqlAdapter.Fill(dtProvince_Recipient);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                int rows3 = dtProvince_Recipient.Rows.Count + 1;

                string nomorFormat3 = rows3.ToString("D3");
                id_tujuan = textBox_Recipient_Name.Text.Substring(0, 2).ToUpper() + nomorFormat3.ToString();
                berat = berapakilo.ToString();

                int nomer = Convert.ToInt32(textBox_Package_Height.Text) * Convert.ToInt32(textBox_Package_Length.Text) * Convert.ToInt32(textBox_Package_Width.Text);

                volume_barang = nomer.ToString();
                idstatus_pengiriman = "S1";
                ongkos_kirim = hargaongkir.ToString();
                notes_utk_kurir = textBox_Package_Remarks.Text;

                prov_alamat_sender = comboBox_Sender_Province.Text;
                kota_alamat_sender = comboBox_Sender_City.Text;
                kec_alamat_sender = textBox_Sender_Subdistrict.Text;
                kodepos_alamat_sender = textBox_Sender_PostCode.Text;
                alamat_lengkap_sender = textBox_Sender_AddressDetail.Text;

                prov_alamat_reci = comboBox_Recipient_Province.Text;
                kota_alamat_reci = comboBox_Recipient_City.Text;
                kec_alamat_reci = textBox_Recipient_Subdistrict.Text;
                kodepos_alamat_reci = textBox_Recipient_PostCode.Text;
                alamat_lengkap_reci = textBox_Recipient_AddressDetail.Text;

                namareci = textBox_Recipient_Name.Text;
                namasender = textBox_Sender_Name.Text;

                notelpsender = textBox_Sender_Phonenum.Text;
                notelpreci = textBox_Recipient_Phonenum.Text;

                //IF YES PICK UP JAM & TANGGAL
                DialogResult result = MessageBox.Show("Total Weight : " + berapakilo.ToString() + " KG\nShipment rate per KG : Rp." 
                    + dtProvince_Sender.Rows[0][0].ToString() + "\nVoucher Used : " + textBox_Package_Voucher.Text + "\nTotal Shipment Fee : Rp. " + hargaongkir.ToString(), "Estimated Cost", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Form_PickUpTime pickup = new Form_PickUpTime(nomorresi, alamat_sender, alamat_recip, beratbarang, totalbiaya, jenisbarang);
                    pickup.Show();
                }    
    }
            else
            {
                MessageBox.Show("There is field that is still empty, Please Re-check!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // KELUAR RESI
        }
        private void textBox_Package_Remarks_TextChanged(object sender, EventArgs e)
        {
            label_Remarks_Length.Text = textBox_Package_Remarks.Text.Length.ToString() + "/100";
        }
        private void textBox_Sender_Phonenum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void textBox_Sender_PostCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void textBox_Recipient_Phonenum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void textBox_Recipient_PostCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void comboBox_Sender_Province_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Sender_Province.SelectedItem != null)
            {
                string province = comboBox_Sender_Province.Text.ToString();
                dtCity_Sender = new DataTable();
                try
                {
                    firstform.sqlQuery = $"SELECT nama_kota AS `City`\r\nFROM db_jawly.list_kota\r\nWHERE provinsi = '{province}';";
                    firstform.sqlCommand = new MySqlCommand(firstform.sqlQuery, firstform.sqlConnect);
                    firstform.sqlAdapter = new MySqlDataAdapter(firstform.sqlCommand);
                    firstform.sqlAdapter.Fill(dtCity_Sender);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                comboBox_Sender_City.DataSource = dtCity_Sender;
                comboBox_Sender_City.DisplayMember = "City";
                comboBox_Sender_City.ValueMember = "City";
                comboBox_Sender_City.SelectedItem = null;
            }
        }

        private void comboBox_Recipient_Province_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Recipient_Province.SelectedItem != null)
            {
                string province = comboBox_Recipient_Province.Text.ToString();
                dtCity_Recipient = new DataTable();
                try
                {
                    firstform.sqlQuery = $"SELECT id_kota AS `ID`, nama_kota AS `City`\r\nFROM db_jawly.list_kota\r\nWHERE provinsi = '{province}';";
                    firstform.sqlCommand = new MySqlCommand(firstform.sqlQuery, firstform.sqlConnect);
                    firstform.sqlAdapter = new MySqlDataAdapter(firstform.sqlCommand);
                    firstform.sqlAdapter.Fill(dtCity_Recipient);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                comboBox_Recipient_City.DataSource = dtCity_Recipient;
                comboBox_Recipient_City.DisplayMember = "City";
                comboBox_Recipient_City.ValueMember = "ID";
                comboBox_Recipient_City.SelectedItem = null;
            }
        }

        private void textBox_Package_Weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void textBox_Package_Length_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void textBox_Package_Width_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void textBox_Package_Height_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }
    }
}
