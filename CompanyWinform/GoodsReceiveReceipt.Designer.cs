namespace CompanyWinform
{
    partial class GoodsReceiveReceipt
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
            this.chosenProductGrid = new System.Windows.Forms.DataGridView();
            this.deleteGoodsImportButton = new System.Windows.Forms.Button();
            this.addGoodsImportButton = new System.Windows.Forms.Button();
            this.cancelReceiveButton = new System.Windows.Forms.Button();
            this.confirmReceiveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalPriceImport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chosenProductGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // chosenProductGrid
            // 
            this.chosenProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chosenProductGrid.Location = new System.Drawing.Point(12, 101);
            this.chosenProductGrid.Name = "chosenProductGrid";
            this.chosenProductGrid.RowHeadersWidth = 51;
            this.chosenProductGrid.RowTemplate.Height = 24;
            this.chosenProductGrid.Size = new System.Drawing.Size(521, 214);
            this.chosenProductGrid.TabIndex = 0;
            // 
            // deleteGoodsImportButton
            // 
            this.deleteGoodsImportButton.Location = new System.Drawing.Point(395, 27);
            this.deleteGoodsImportButton.Name = "deleteGoodsImportButton";
            this.deleteGoodsImportButton.Size = new System.Drawing.Size(138, 41);
            this.deleteGoodsImportButton.TabIndex = 1;
            this.deleteGoodsImportButton.Text = "Delete";
            this.deleteGoodsImportButton.UseVisualStyleBackColor = true;
            this.deleteGoodsImportButton.Click += new System.EventHandler(this.deleteGoodsImportButton_Click);
            // 
            // addGoodsImportButton
            // 
            this.addGoodsImportButton.Location = new System.Drawing.Point(12, 27);
            this.addGoodsImportButton.Name = "addGoodsImportButton";
            this.addGoodsImportButton.Size = new System.Drawing.Size(138, 41);
            this.addGoodsImportButton.TabIndex = 2;
            this.addGoodsImportButton.Text = "Add";
            this.addGoodsImportButton.UseVisualStyleBackColor = true;
            this.addGoodsImportButton.Click += new System.EventHandler(this.addGoodsImportButton_Click);
            // 
            // cancelReceiveButton
            // 
            this.cancelReceiveButton.Location = new System.Drawing.Point(395, 446);
            this.cancelReceiveButton.Name = "cancelReceiveButton";
            this.cancelReceiveButton.Size = new System.Drawing.Size(138, 41);
            this.cancelReceiveButton.TabIndex = 3;
            this.cancelReceiveButton.Text = "Cancel";
            this.cancelReceiveButton.UseVisualStyleBackColor = true;
            this.cancelReceiveButton.Click += new System.EventHandler(this.cancelReceiveButton_Click);
            // 
            // confirmReceiveButton
            // 
            this.confirmReceiveButton.Location = new System.Drawing.Point(251, 446);
            this.confirmReceiveButton.Name = "confirmReceiveButton";
            this.confirmReceiveButton.Size = new System.Drawing.Size(138, 41);
            this.confirmReceiveButton.TabIndex = 4;
            this.confirmReceiveButton.Text = "Confirm";
            this.confirmReceiveButton.UseVisualStyleBackColor = true;
            this.confirmReceiveButton.Click += new System.EventHandler(this.confirmReceiveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total";
            // 
            // totalPriceImport
            // 
            this.totalPriceImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPriceImport.AutoSize = true;
            this.totalPriceImport.Location = new System.Drawing.Point(56, 359);
            this.totalPriceImport.Name = "totalPriceImport";
            this.totalPriceImport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalPriceImport.Size = new System.Drawing.Size(14, 16);
            this.totalPriceImport.TabIndex = 6;
            this.totalPriceImport.Text = "0";
            this.totalPriceImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GoodsReceiveReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 512);
            this.Controls.Add(this.totalPriceImport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmReceiveButton);
            this.Controls.Add(this.cancelReceiveButton);
            this.Controls.Add(this.addGoodsImportButton);
            this.Controls.Add(this.deleteGoodsImportButton);
            this.Controls.Add(this.chosenProductGrid);
            this.Name = "GoodsReceiveReceipt";
            this.Text = "GoodsReceiveReceipt";
            this.Load += new System.EventHandler(this.GoodsReceiveReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chosenProductGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView chosenProductGrid;
        private System.Windows.Forms.Button deleteGoodsImportButton;
        private System.Windows.Forms.Button addGoodsImportButton;
        private System.Windows.Forms.Button cancelReceiveButton;
        private System.Windows.Forms.Button confirmReceiveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalPriceImport;
    }
}