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
    public partial class Form1 : Form
    {
        public string connectionString = "server=localhost;uid=root;pwd=root;database=db_jawly";
        public MySqlConnection sqlConnect;
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public MySqlDataReader sqlDataReader;
        public MySqlDataReader sqlReader;
        public string sqlQuery;
        public string usernamenya { get; set; }


        public Form1()
        {
            InitializeComponent();
        }

        private void showMainPage()
        {
            panel_Main.Controls.Clear();
            Form_MainPage form_MainPage = new Form_MainPage();
            form_MainPage.Dock = DockStyle.Fill;
            form_MainPage.TopLevel = false;
            form_MainPage.ControlBox = false;
            form_MainPage.FormBorderStyle = FormBorderStyle.None;
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(form_MainPage);
            //form_MainPage.form1 = this;
            form_MainPage.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    sqlConnect = new MySqlConnection(connectionString);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            pictureBox_Logo.Parent = pictureBox_Blob_L;
            pictureBox_Logo.BackColor = Color.Transparent;

            label_Date.Parent = pictureBox_Blob_R;
            label_Date.BackColor = Color.Transparent;
            label_Date.AutoSize = false;
            label_Date.Size = new Size(310, 30);
            label_Date.Location = new Point(0, 15);
            label_Date.TextAlign = ContentAlignment.MiddleRight;
            //labeldate.BorderStyle = BorderStyle.FixedSingle;

            label_Username.Parent = pictureBox_Blob_R;
            label_Username.BackColor = Color.Transparent;
            label_Username.Location = new Point(0, 40);
            label_Username.AutoSize = false;
            label_Username.Size = new Size(305, 30);
            label_Username.TextAlign = ContentAlignment.MiddleRight;

            timer1.Start();
            panel_Header.BackColor = Color.FromArgb(255, 255, 206, 201);
            showMainPage();
        }

        private void pictureBox_Logo_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox_Logo_Click(object sender, EventArgs e)
        {
            showMainPage();
        }

        private void pictureBox_Logo_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        public Login_Page loginpage = Application.OpenForms["loginpage"] as Login_Page;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label_Date.Text = DateTime.Now.ToLongDateString();
            //labeldate.Text = "Wednesday, 29 September 2023";


            int hour = DateTime.Now.Hour;
            loginpage.form1 = this;
            if (hour >= 6 && hour < 12)
            {
                label_Username.Text = "Good Morning, " + loginpage.name_user +"!";
            }
            else if (hour >= 12 && hour < 18)
            {
                label_Username.Text = "Good Day, " + loginpage.name_user + "!";
            }
            else if (hour >= 18)
            {
                label_Username.Text = "Good Evening, " + loginpage.name_user + "!";
            }
            else if (hour < 6)
            {
                label_Username.Text = "Sleep Please, " + loginpage.name_user + "!";
            }
        }
    }
}
