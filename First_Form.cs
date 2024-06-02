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
    public partial class First_Form : Form
    {
        public string connectionString = "server=localhost;uid=root;pwd=root;database=db_jawly";
        public MySqlConnection sqlConnect;
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public MySqlDataReader sqlDataReader;
        public string sqlQuery;
        public MySqlDataReader sqlReader;
        public First_Form()
        {
            InitializeComponent();

        }
        public Panel LoginSigninPanel
        {
            get { return panel_Login_Signin; }
            set { panel_Login_Signin = value; }
        }


        private void First_Form_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConnect = new MySqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            Login_Page loginPage = new Login_Page();
            loginPage.TopLevel = false;
            loginPage.Dock = DockStyle.Fill;
            loginPage.FirstForm = this; // Pass the reference of First_Form to Login_Page
            panel_Login_Signin.Controls.Add(loginPage);
            loginPage.Show();


            SignUp_Page signinpage = new SignUp_Page();
            signinpage.TopLevel = false;
            signinpage.Dock = DockStyle.Fill;
            signinpage.FirstForm2 = this;
            panel_Login_Signin.Controls.Add(signinpage);
            signinpage.Show();
        }
        public void LoadSigninPage()
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
