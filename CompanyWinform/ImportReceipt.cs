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
    public partial class ImportReceipt : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=IPC;Integrated Security=True;");
        int receiptID;
        int status;
        public ImportReceipt(int id, int status)
        {
            InitializeComponent();
            this.receiptID = id;
            this.status = status;
        }

        private void ImportReceipt_Load(object sender, EventArgs e)
        {
            conn.Open();
            string query;
            if (status == 0) { 
                query = "Select WarehouseReceipt.Price, WarehouseReceipt.ID, Product.Name, Product.ImportPrice, WarehouseReceiptItem.ProductQuantity from WarehouseReceipt full join WarehouseReceiptItem on WarehouseReceipt.ID = WarehouseReceiptItem.WarehouseReceiptID full join Product on WarehouseReceiptItem.ProductID = Product.ID where WarehouseReceipt.ID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@ID", receiptID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                ItemDataGridView.DataSource = dt;
                import_Price.Text = ItemDataGridView.Rows[0].Cells[0].Value.ToString();
                ItemDataGridView.Columns["Price"].Visible = false;
            }
            else
            {
                query = "select ItemInCart.ProductID, Product.Name, ItemInCart.Quantity, Product.DeliveryPrice, DeliverySlip.Status, DeliverySlip.Payment, DeliverySlip.ShipAdress from Cart full join ItemInCart on ItemInCart.CartID = Cart.ID full join DeliverySlip on DeliverySlip.CartID = Cart.ID full join Product on Product.ID = ItemInCart.ProductID where Cart.ID = 3 ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@ID", receiptID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                ItemDataGridView.DataSource = dt;
                int price = 0;
                for (int i = 0; i < ItemDataGridView.Rows.Count - 1; i++)
                {
                    String data = ItemDataGridView.Rows[i].Cells[3].Value.ToString();
                    string quantity = ItemDataGridView.Rows[i].Cells[2].Value.ToString();
                    price += int.Parse(data)* int.Parse(quantity);
                }
                import_Price.Text = price.ToString();
            }
            conn.Close();
            
        }
        
    }
}
