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
    public partial class History : Form
    {
        double total;
        double deliveryTotal;
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=IPC;Integrated Security=True;");
        public History()
        {
            InitializeComponent();
            
        }

        private void History_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iPCDataSet1.ItemInCart' table. You can move, or remove it, as needed.
            this.itemInCartTableAdapter.Fill(this.iPCDataSet1.ItemInCart);
            conn.Open();
            string query = "Select * from WarehouseReceipt full join WarehouseReceiptItem on WarehouseReceipt.ID = WarehouseReceiptItem.WarehouseReceiptID";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            historyGridView.DataSource = dt;
            setVisible();
            total = 0;
            deliveryTotal = 0;
            //Console.WriteLine(historyGridView.Rows[historyGridView.Rows.Count -1].Cells[1].Value);
            for (int i = 0; i < historyGridView.Rows.Count - 1; i++)
            {
                double price = (double) historyGridView.Rows[i].Cells[2].Value;
                total += price;
            }
            query = "Select * from ItemInCart";
            cmd = new SqlCommand(query, conn);
            adapter = new SqlDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            adapter.Fill(dt2);
            deliveryGridView.DataSource = dt2;
            costAmount.Text = total.ToString();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                int id = dt2.Rows[i].Field<int>("ProductID");
                int quantity = dt2.Rows[i].Field<int>("Quantity");
                query = "Select DeliveryPrice from Product where ID = @ID";
                cmd = new SqlCommand (query, conn);
                cmd.Parameters.Add("@ID", id);
                DataTable price = new DataTable();
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill (price);
                double productPrice = price.Rows[0].Field<double>("DeliveryPrice");
                deliveryTotal += productPrice * quantity;
            }
            inComeTXT.Text = deliveryTotal.ToString();
            conn.Close();
        }
        private void setVisible()
        {
            if (historyGridView.Rows.Count > 1)
            {
                historyGridView.Columns["ID"].Visible = false;
            }
        }

        

        private void historyGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.historyGridView.Rows[e.RowIndex];
            int ID = int.Parse(row.Cells[0].Value.ToString());
            Console.WriteLine("ID = " + row.Cells[0].Value.ToString());
            ImportReceipt frm = new ImportReceipt(ID, 0);
            frm.Text = "Import Receipt";
            frm.ShowDialog();
        }

        private void deliveryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.deliveryGridView.Rows[e.RowIndex];
            int ID = int.Parse(row.Cells[1].Value.ToString());
            Console.WriteLine("ID = " + row.Cells[1].Value.ToString());
            ImportReceipt frm = new ImportReceipt(ID, 1);
            frm.Text = "Delivery Receipt";
            frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
