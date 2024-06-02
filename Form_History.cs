using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Jawly_Design4
{
    public partial class Form_History : Form
    {
        Form1 form1 = Application.OpenForms["form1"] as Form1;
        Form_MainPage form_MainPage = Application.OpenForms["form_MainPage"] as Form_MainPage;
        public DataTable dtHistory;
        public string status;
        public List<PictureBox> pbBackground = new List<PictureBox>();
        public Form_History()
        {
            InitializeComponent();

            form1.sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=root;database=db_jawly");
            form1.sqlConnect.Open();
        }

        private void showHistory(int _i)
        {
            int i = _i;

            //MessageBox.Show(i.ToString());

            string resi = dtHistory.Rows[i][0].ToString();
            DateTime tgl = Convert.ToDateTime(dtHistory.Rows[i][1]);
            string tanggal = tgl.ToString("dd/MM/yyyy");
            string namaPengirim = dtHistory.Rows[i][2].ToString();
            string gatewayPengirim = dtHistory.Rows[i][3].ToString();
            string namaPenerima = dtHistory.Rows[i][4].ToString();
            string gatewayPenerima = dtHistory.Rows[i][5].ToString();
            string jenisLayanan = dtHistory.Rows[i][6].ToString();
            string idStatus = dtHistory.Rows[i][7].ToString();

            if (idStatus == "S5")
            {
                status = "Completed";
            }
            else
            {
                status = "In Progress";
            }

            PictureBox pb_background = new PictureBox();
            //pb_background.Image = Image.FromFile($@"assets\history_background.png");
            pb_background.Image = Jawly_Design4.Properties.Resources._625__500__11_;
            pb_background.Size = new Size(400, 160);
            pb_background.Location = new Point(18, i * 180 + 50);
            pb_background.SizeMode = PictureBoxSizeMode.StretchImage;
            //pb_background.BorderStyle = BorderStyle.FixedSingle;
            pbBackground.Add(pb_background);
            this.Controls.Add(pb_background);

            Panel panel = new Panel();
            panel.Size = new Size(380, 130);
            panel.Location = new Point(28, i * 180 + 62);
            panel.Parent = pb_background;
            panel.BackColor = Color.Transparent;
            panel.BackColor = Color.FromArgb(255, 255, 177, 183);
            //panel.BackColor = Color.FromArgb(255, 255, 206, 201);
            //panel.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(panel);
            pb_background.SendToBack();

            PictureBox pb_logo = new PictureBox();
            //pb_logo.Image = Image.FromFile($@"assets\jawly_logo.png");
            pb_logo.Image = Jawly_Design4.Properties.Resources.jawly_logo;
            pb_logo.Size = new Size(30, 30);
            pb_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pb_logo.Location = new Point(0, 0);
            panel.Controls.Add(pb_logo);

            Label label_ServiceType = new Label();
            label_ServiceType.BackColor = Color.Linen;
            label_ServiceType.ForeColor = Color.FromArgb(255, 248, 149, 153);
            label_ServiceType.Text = $"{jenisLayanan} - {status}";
            label_ServiceType.Font = new Font("Ebrima", 10);
            label_ServiceType.AutoSize = true;
            label_ServiceType.Location = new Point(pb_logo.Right + 10, 5);
            panel.Controls.Add(label_ServiceType);

            Label label_Date = new Label();
            label_Date.ForeColor = Color.Black;
            label_Date.Text = $"Transaction date: {tanggal}";
            label_Date.Font = new Font("Ebrima", 10);
            label_Date.AutoSize = true;
            label_Date.Location = new Point(label_ServiceType.Right + 5, 5);
            panel.Controls.Add(label_Date);

            PictureBox pb_from = new PictureBox();
            pb_from.Image = Jawly_Design4.Properties.Resources.from_icon;
            //pb_from.Image = Image.FromFile($@"assets\history_from.png");
            pb_from.Size = new Size(20, 20);
            pb_from.SizeMode = PictureBoxSizeMode.Zoom;
            pb_from.Location = new Point(pb_logo.Left + 5, pb_logo.Bottom + 10);
            panel.Controls.Add(pb_from);

            Label label_Sender = new Label();
            label_Sender.Text = namaPengirim;
            label_Sender.Font = new Font("Ebrima", 10, FontStyle.Bold);
            label_Sender.AutoSize = true;
            label_Sender.Location = new Point(38, pb_from.Top);
            panel.Controls.Add(label_Sender);

            Label label_Sender_Gateway = new Label();
            label_Sender_Gateway.Text = $"({gatewayPengirim})";
            label_Sender_Gateway.Font = new Font("Ebrima", 10);
            label_Sender_Gateway.AutoSize = true;
            label_Sender_Gateway.Location = new Point(label_Sender.Right, label_Sender.Top);
            panel.Controls.Add(label_Sender_Gateway);

            Label label_DottedLine = new Label();
            label_DottedLine.Text = ".\n.\n.";
            label_DottedLine.Font = new Font("Ebrima", 4, FontStyle.Bold);
            label_DottedLine.AutoSize = true;
            label_DottedLine.Location = new Point(pb_from.Left + 7, pb_from.Bottom);
            panel.Controls.Add(label_DottedLine);

            PictureBox pb_to = new PictureBox();
            //pb_to.Image = Image.FromFile($@"assets\history_to.png");
            pb_to.Image = Jawly_Design4.Properties.Resources.to_icon;
            pb_to.Size = new Size(28, 28);
            pb_to.SizeMode = PictureBoxSizeMode.Zoom;
            pb_to.Location = new Point(pb_from.Left - 3, label_DottedLine.Bottom + 5);
            panel.Controls.Add(pb_to);

            Label label_Recipient = new Label();
            label_Recipient.Text = namaPenerima;
            label_Recipient.Font = new Font("Ebrima", 10, FontStyle.Bold);
            label_Recipient.AutoSize = true;
            label_Recipient.Location = new Point(38, pb_to.Top + 5);
            panel.Controls.Add(label_Recipient);

            Label label_Recipient_Gateway = new Label();
            label_Recipient_Gateway.Text = $"({gatewayPenerima})";
            label_Recipient_Gateway.Font = new Font("Ebrima", 10);
            label_Recipient_Gateway.AutoSize = true;
            label_Recipient_Gateway.Location = new Point(label_Recipient.Right, label_Recipient.Top);
            panel.Controls.Add(label_Recipient_Gateway);

            Label label_SeeDetails = new Label();
            label_SeeDetails.Text = "See Details";
            label_SeeDetails.Font = new Font("Ebrima", 10, FontStyle.Italic | FontStyle.Underline);
            label_SeeDetails.AutoSize = true;
            label_SeeDetails.Location = new Point(300, 110);
            label_SeeDetails.Tag = resi;
            label_SeeDetails.MouseEnter += label_SeeDetails_MouseEnter;
            label_SeeDetails.Click += label_SeeDetails_Click;
            label_SeeDetails.MouseLeave += label_SeeDetails_MouseLeave;
            panel.Controls.Add(label_SeeDetails);

            if (i > 0)
            {
                pbBackground[i - 1].SendToBack();
            }
        }

        private void label_SeeDetails_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void label_SeeDetails_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Form_History_Load(object sender, EventArgs e)
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
            //MessageBox.Show(dtHistory.Rows.Count.ToString());

            if (dtHistory.Rows.Count > 0)
            {
                showHistory(0);
                if (dtHistory.Rows.Count > 1)
                {
                    for (int i = 1; i < dtHistory.Rows.Count; i++)
                    {
                        showHistory(i);
                    }
                }
                Panel panel = new Panel();
                panel.Location = new Point(0, pbBackground[dtHistory.Rows.Count - 1].Bottom);
                panel.Size = new Size(10, 30);
                this.Controls.Add(panel);
            }
            //else
            //{ 
            //    this.Close();
            //    History_Page history_Page = new History_Page();
            //    history_Page.Dock = DockStyle.Fill;
            //    history_Page.TopLevel = false;
            //    history_Page.ControlBox = false;
            //    history_Page.FormBorderStyle = FormBorderStyle.None;
            //    form1.panel_Main.Controls.Clear();
            //    form1.panel_Main.Controls.Add(history_Page);
            //    history_Page.Show();
            //}
        }

        private void label_SeeDetails_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            //MessageBox.Show(label.Tag.ToString()); 
            string resi = label.Tag.ToString();
            this.Hide();
            //form1.panel_Main.Controls.Clear();
            Form_HistoryDetails form_HistoryDetails = new Form_HistoryDetails(resi);
            form_HistoryDetails.Dock = DockStyle.Fill;
            form_HistoryDetails.TopLevel = false;
            form_HistoryDetails.ControlBox = false;
            form_HistoryDetails.FormBorderStyle = FormBorderStyle.None;
            //form1.panel_Main.Controls.Clear();
            form1.panel_Main.Controls.Add(form_HistoryDetails);
            form_HistoryDetails.Show();
        }
    }
}
