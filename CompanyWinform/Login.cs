using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyWinform
{
    public partial class Login : Form
    {
        public static string AccountantEmail;
        SqlConnection sqlconn = new SqlConnection("Data Source=localhost;Initial Catalog=IPC;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

       

        private void confirmLoginButton_Click(object sender, EventArgs e)
        {
            string email = emailLogin.Text;
            string password = passwordLogin.Text;
            if (email.Length == 0)
            {
                MessageBox.Show("Please enter the email");
            }
            else if(password.Length == 0)
            {
                MessageBox.Show("Please enter the password");
            }
            else
            {
                sqlconn.Open();
                string command = "SELECT NAME FROM [ACCOUNTANT] WHERE Email= @email and password= @password";
                SqlCommand cmd = new SqlCommand(command, sqlconn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataAdapter datadapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                datadapt.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MainForm frm = new MainForm();
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Email or Password");
                }
                sqlconn.Close();
            }     
        }


        private void createAccountButton_Click(object sender, EventArgs e)
        {
            
            
            Register registerForm = new Register();
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
