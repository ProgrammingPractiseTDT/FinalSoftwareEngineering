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
    public partial class GoodsReceiveReceipt : Form
    {
        double total;
        int importReceiptID;
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=IPC;Integrated Security=True;");
        public GoodsReceiveReceipt()
        {
            InitializeComponent();
        }

        private void addGoodsImportButton_Click(object sender, EventArgs e)
        {
            addProductImport frm = new addProductImport(importReceiptID);
            frm.ShowDialog();
            conn.Open();
            string query = "select WarehouseReceiptItem.ID, WarehouseReceiptItem.ProductID, Product.Name, Product.Brand, Product.ImportPrice, WarehouseReceiptItem.ProductQuantity  from WarehouseReceiptItem  full join Product on WarehouseReceiptItem.ProductID = Product.ID where WarehouseReceiptID = @ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@ID", importReceiptID);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            adapter.Fill(dt2);
            chosenProductGrid.DataSource = dt2;
            totalPriceImport.Text = totalUpdate(dt2);
            conn.Close();
            setVisible();
        }

        
        private void GoodsReceiveReceipt_Load(object sender, EventArgs e)
        {
            conn.Open();

            DateTime today = DateTime.Today;
            string day = today.ToString("yyyyMMdd");
            SqlCommand cmd = new SqlCommand("insert into WarehouseReceipt(Date, Price) values(@Day,0)", conn);
            cmd.Parameters.Add("@Day", day);
            int result = cmd.ExecuteNonQuery();
            string query = "select id from WarehouseReceipt order by ID desc";
            cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter (cmd);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            importReceiptID = ds.Rows[0].Field<int>("ID");
            conn.Close ();
        }

        private void deleteGoodsImportButton_Click(object sender, EventArgs e)
        {
            if (chosenProductGrid.Rows.Count < 1)
            {
                MessageBox.Show("Nothing to delete", "Nothing in here can be delete", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                DialogResult dr = MessageBox.Show(
                  "Are you sure", "Product Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int rowIndex = this.chosenProductGrid.CurrentCell.RowIndex;
                    conn.Open();
                    int ID = (int)this.chosenProductGrid.Rows[rowIndex].Cells[0].Value;
                    string query = "delete from WarehouseReceiptItem where ID = @ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("@ID", ID);
                    Console.WriteLine(ID);
                    Console.WriteLine(cmd.ExecuteNonQuery());
                    query = "select WarehouseReceiptItem.ID, WarehouseReceiptItem.ProductID, Product.Name, Product.Brand, Product.ImportPrice, WarehouseReceiptItem.ProductQuantity  from WarehouseReceiptItem  full join Product on WarehouseReceiptItem.ProductID = Product.ID where WarehouseReceiptID = @ID";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("@ID", importReceiptID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt2 = new DataTable();
                    adapter.Fill(dt2);
                    chosenProductGrid.DataSource = dt2;
                    totalPriceImport.Text = totalUpdate(dt2);
                    conn.Close();
                }
            }
            
        
        }

        private void confirmReceiveButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "update WarehouseReceipt set Price=@Total where id=@ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@Total", total);
            cmd.Parameters.Add("@ID", importReceiptID);
            cmd.ExecuteNonQuery();
            conn.Close();
            this.Close();
        }

        private string totalUpdate(DataTable dt)
        {
            total = 0;
            string getPriceQuery = "Select ImportPrice from Product where ID = @ProductID";
            if (dt.Rows.Count == 0)
            {
                return "0";
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int productID = dt.Rows[i].Field<int>("ProductID");
                int quantity = dt.Rows[i].Field<int>("ProductQuantity");
                SqlCommand cmd = new SqlCommand(getPriceQuery, conn);
                cmd.Parameters.Add("@ProductID", productID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt3 = new DataTable();
                adapter.Fill(dt3);
                double price = dt3.Rows[0].Field<double>("ImportPrice");
                total += price * (double)quantity;
            }
            return total.ToString();
        }

        private void cancelReceiveButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            string queryDeleteItem = "Delete from WarehouseReceiptItem where WarehouseReceiptID = @ID";
            SqlCommand cmd = new SqlCommand(queryDeleteItem, conn);
            cmd.Parameters.Add("@ID", importReceiptID);
            cmd.ExecuteNonQuery();
            string queryDeleteReceipt = "Delete from WarehouseReceipt where ID= @ID";
            cmd = new SqlCommand(queryDeleteReceipt, conn);
            cmd.Parameters.Add("@ID",importReceiptID);
            cmd.ExecuteNonQuery();
            this.Close();
        }

        private void setVisible()
        {
            if (chosenProductGrid.Rows.Count > 1)
            {
                chosenProductGrid.Columns["ID"].Visible = false;
            }
        }
    }
}
