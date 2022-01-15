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
    public partial class addProductImport : Form
    {
        int receipt;
        string productId;
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=IPC;Integrated Security=True;");
        public addProductImport(int receiptId)
        {
            InitializeComponent();
            receipt = receiptId;
        }

        private void addProductImport_Load(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select * from Product";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            productGridView.DataSource = dt;
        }

        private void productGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex == -1)
            {
                return;
            }
           DataGridViewRow row = this.productGridView.Rows[e.RowIndex];
           productId = row.Cells[0].Value.ToString();
            
        }

        private void addProduct2Receipt_Click(object sender, EventArgs e)
        {
            conn.Open();
            int value = (int) amountInput.Value;
            string query = "insert into WarehouseReceiptItem(ProductID, ProductQuantity, WarehouseReceiptID) values(@ProductID, @Quantity, @ReceiptID)";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add("@ProductID", productId);
            command.Parameters.Add("@Quantity", value);
            command.Parameters.Add("@ReceiptID", receipt);
            command.ExecuteNonQuery();
            this.Close();
        }

        private void cancelAddProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
