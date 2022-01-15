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

namespace CompanyWinform
{
    public partial class MainForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=IPC;Integrated Security=True;");
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn.Open();

            string query = "select Name, Brand, Instock, ImportPrice, DeliveryPrice from Product";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            

            conn.Close();
            productGridView.DataSource = dt;
        }

        private void receiveProduct_Click(object sender, EventArgs e)
        {
            GoodsReceiveReceipt frm = new GoodsReceiveReceipt();
            frm.ShowDialog();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            History frm = new History();
            frm.ShowDialog();
        }

        private void deliveryProduct_Click(object sender, EventArgs e)
        {
            DeliveryManagement frm = new DeliveryManagement();
            frm.Show();
        }
    }
}
