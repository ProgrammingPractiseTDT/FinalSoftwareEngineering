namespace CompanyWinform
{
    partial class addProductImport
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
            this.amountInput = new System.Windows.Forms.NumericUpDown();
            this.addProduct2Receipt = new System.Windows.Forms.Button();
            this.cancelAddProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountInput)).BeginInit();
            this.SuspendLayout();
            // 
            // productGridView
            // 
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(12, 78);
            this.productGridView.Name = "productGridView";
            this.productGridView.RowHeadersWidth = 51;
            this.productGridView.RowTemplate.Height = 24;
            this.productGridView.Size = new System.Drawing.Size(697, 218);
            this.productGridView.TabIndex = 0;
            this.productGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGridView_CellClick);
            // 
            // amountInput
            // 
            this.amountInput.Location = new System.Drawing.Point(589, 349);
            this.amountInput.Name = "amountInput";
            this.amountInput.Size = new System.Drawing.Size(120, 22);
            this.amountInput.TabIndex = 1;
            // 
            // addProduct2Receipt
            // 
            this.addProduct2Receipt.Location = new System.Drawing.Point(467, 440);
            this.addProduct2Receipt.Name = "addProduct2Receipt";
            this.addProduct2Receipt.Size = new System.Drawing.Size(116, 49);
            this.addProduct2Receipt.TabIndex = 2;
            this.addProduct2Receipt.Text = "Add";
            this.addProduct2Receipt.UseVisualStyleBackColor = true;
            this.addProduct2Receipt.Click += new System.EventHandler(this.addProduct2Receipt_Click);
            // 
            // cancelAddProduct
            // 
            this.cancelAddProduct.Location = new System.Drawing.Point(589, 440);
            this.cancelAddProduct.Name = "cancelAddProduct";
            this.cancelAddProduct.Size = new System.Drawing.Size(116, 49);
            this.cancelAddProduct.TabIndex = 3;
            this.cancelAddProduct.Text = "Cancel";
            this.cancelAddProduct.UseVisualStyleBackColor = true;
            this.cancelAddProduct.Click += new System.EventHandler(this.cancelAddProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(661, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Amount";
            // 
            // addProductImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelAddProduct);
            this.Controls.Add(this.addProduct2Receipt);
            this.Controls.Add(this.amountInput);
            this.Controls.Add(this.productGridView);
            this.Name = "addProductImport";
            this.Text = "Choose Product";
            this.Load += new System.EventHandler(this.addProductImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.NumericUpDown amountInput;
        private System.Windows.Forms.Button addProduct2Receipt;
        private System.Windows.Forms.Button cancelAddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}