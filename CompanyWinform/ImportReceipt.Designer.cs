namespace CompanyWinform
{
    partial class ImportReceipt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.ItemDataGridView = new System.Windows.Forms.DataGridView();
            this.PriceType = new System.Windows.Forms.Label();
            this.import_Price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(226, 79);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(121, 33);
            this.title.TabIndex = 0;
            this.title.Text = "Receipt";
            // 
            // ItemDataGridView
            // 
            this.ItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemDataGridView.Location = new System.Drawing.Point(12, 145);
            this.ItemDataGridView.Name = "ItemDataGridView";
            this.ItemDataGridView.RowHeadersWidth = 51;
            this.ItemDataGridView.RowTemplate.Height = 24;
            this.ItemDataGridView.Size = new System.Drawing.Size(561, 191);
            this.ItemDataGridView.TabIndex = 2;
            // 
            // PriceType
            // 
            this.PriceType.AutoSize = true;
            this.PriceType.Location = new System.Drawing.Point(22, 374);
            this.PriceType.Name = "PriceType";
            this.PriceType.Size = new System.Drawing.Size(38, 16);
            this.PriceType.TabIndex = 3;
            this.PriceType.Text = "Total";
            // 
            // import_Price
            // 
            this.import_Price.AutoSize = true;
            this.import_Price.Location = new System.Drawing.Point(22, 408);
            this.import_Price.Name = "import_Price";
            this.import_Price.Size = new System.Drawing.Size(14, 16);
            this.import_Price.TabIndex = 4;
            this.import_Price.Text = "0";
            // 
            // ImportReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(585, 532);
            this.Controls.Add(this.import_Price);
            this.Controls.Add(this.PriceType);
            this.Controls.Add(this.ItemDataGridView);
            this.Controls.Add(this.title);
            this.Name = "ImportReceipt";
            this.Text = "ImportReceipt";
            this.Load += new System.EventHandler(this.ImportReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView ItemDataGridView;
        private System.Windows.Forms.Label PriceType;
        private System.Windows.Forms.Label import_Price;
    }
}