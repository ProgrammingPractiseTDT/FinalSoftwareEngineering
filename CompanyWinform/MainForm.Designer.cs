namespace CompanyWinform
{
    partial class MainForm
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
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.receiveProduct = new System.Windows.Forms.Button();
            this.deliveryProduct = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productGridView
            // 
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(44, 58);
            this.productGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productGridView.Name = "productGridView";
            this.productGridView.RowHeadersWidth = 51;
            this.productGridView.RowTemplate.Height = 24;
            this.productGridView.Size = new System.Drawing.Size(969, 738);
            this.productGridView.TabIndex = 0;
            // 
            // receiveProduct
            // 
            this.receiveProduct.Location = new System.Drawing.Point(1154, 58);
            this.receiveProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.receiveProduct.Name = "receiveProduct";
            this.receiveProduct.Size = new System.Drawing.Size(404, 127);
            this.receiveProduct.TabIndex = 1;
            this.receiveProduct.Text = "Create Goods Receives";
            this.receiveProduct.UseVisualStyleBackColor = true;
            this.receiveProduct.Click += new System.EventHandler(this.receiveProduct_Click);
            // 
            // deliveryProduct
            // 
            this.deliveryProduct.Location = new System.Drawing.Point(1154, 356);
            this.deliveryProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deliveryProduct.Name = "deliveryProduct";
            this.deliveryProduct.Size = new System.Drawing.Size(404, 127);
            this.deliveryProduct.TabIndex = 2;
            this.deliveryProduct.Text = "Manage Goods Delivery";
            this.deliveryProduct.UseVisualStyleBackColor = true;
            this.deliveryProduct.Click += new System.EventHandler(this.deliveryProduct_Click);
            // 
            // historyButton
            // 
            this.historyButton.Location = new System.Drawing.Point(1154, 669);
            this.historyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(404, 127);
            this.historyButton.TabIndex = 3;
            this.historyButton.Text = "Revenue and Import/Export Receipt";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1688, 828);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.deliveryProduct);
            this.Controls.Add(this.receiveProduct);
            this.Controls.Add(this.productGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.Button receiveProduct;
        private System.Windows.Forms.Button deliveryProduct;
        private System.Windows.Forms.Button historyButton;
    }
}