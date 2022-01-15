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
    public partial class DeliveryManagement : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=IPC;Integrated Security=True;");
        public DeliveryManagement()
        {
            InitializeComponent();
        }

        private void DeliveryManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iPCDataSet.DeliverySlip' table. You can move, or remove it, as needed.
            this.deliverySlipTableAdapter.Fill(this.iPCDataSet.DeliverySlip);

        }

        private void confirmChangeButton_Click(object sender, EventArgs e)
        {
            int row = deliverySlipGridView.CurrentCell.RowIndex;
            int status = 0;
            if (chuaGiaoButton.Checked)
            {
                status = 0;
            }
            else if (dangGiaoButton.Checked)
            {
                status = 1;
            }
            else if (dagiaoButton.Checked)
            {
                status = 2;
            }
            conn.Open();
            int ID = (int) deliverySlipGridView.Rows[row].Cells[0].Value;
            string query = "update DeliverySlip set Status = @status where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@status", status);
            cmd.Parameters.Add("@ID", ID);
            cmd.ExecuteNonQuery();
            this.deliverySlipTableAdapter.Fill(this.iPCDataSet.DeliverySlip);
            conn.Close();

        }

        private void deliverySlipGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataGridViewRow = deliverySlipGridView.Rows[e.RowIndex];
            int status = (int) dataGridViewRow.Cells[3].Value;
            if (status == 0)
            {
                chuaGiaoButton.Checked = true;
            }
            else if (status == 1)
            {
                dangGiaoButton.Checked = true;
            }
            else if (status == 2)
            {
                dagiaoButton.Checked = true;
            }
        }
    }
}
