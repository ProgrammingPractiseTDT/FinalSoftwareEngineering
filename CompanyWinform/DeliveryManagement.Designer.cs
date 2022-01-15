namespace CompanyWinform
{
    partial class DeliveryManagement
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
            this.components = new System.ComponentModel.Container();
            this.deliverySlipGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deliverySlipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPCDataSet = new CompanyWinform.IPCDataSet();
            this.deliverySlipTableAdapter = new CompanyWinform.IPCDataSetTableAdapters.DeliverySlipTableAdapter();
            this.dangGiaoButton = new System.Windows.Forms.RadioButton();
            this.chuaGiaoButton = new System.Windows.Forms.RadioButton();
            this.dagiaoButton = new System.Windows.Forms.RadioButton();
            this.statusBox = new System.Windows.Forms.GroupBox();
            this.confirmChangeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deliverySlipGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliverySlipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPCDataSet)).BeginInit();
            this.statusBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // deliverySlipGridView
            // 
            this.deliverySlipGridView.AutoGenerateColumns = false;
            this.deliverySlipGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deliverySlipGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.cartIDDataGridViewTextBoxColumn,
            this.shipAdressDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.paymentDataGridViewCheckBoxColumn});
            this.deliverySlipGridView.DataSource = this.deliverySlipBindingSource;
            this.deliverySlipGridView.Location = new System.Drawing.Point(33, 27);
            this.deliverySlipGridView.Name = "deliverySlipGridView";
            this.deliverySlipGridView.RowHeadersWidth = 51;
            this.deliverySlipGridView.RowTemplate.Height = 24;
            this.deliverySlipGridView.Size = new System.Drawing.Size(683, 247);
            this.deliverySlipGridView.TabIndex = 0;
            this.deliverySlipGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deliverySlipGridView_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cartIDDataGridViewTextBoxColumn
            // 
            this.cartIDDataGridViewTextBoxColumn.DataPropertyName = "CartID";
            this.cartIDDataGridViewTextBoxColumn.HeaderText = "CartID";
            this.cartIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cartIDDataGridViewTextBoxColumn.Name = "cartIDDataGridViewTextBoxColumn";
            this.cartIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // shipAdressDataGridViewTextBoxColumn
            // 
            this.shipAdressDataGridViewTextBoxColumn.DataPropertyName = "ShipAdress";
            this.shipAdressDataGridViewTextBoxColumn.HeaderText = "ShipAdress";
            this.shipAdressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shipAdressDataGridViewTextBoxColumn.Name = "shipAdressDataGridViewTextBoxColumn";
            this.shipAdressDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentDataGridViewCheckBoxColumn
            // 
            this.paymentDataGridViewCheckBoxColumn.DataPropertyName = "Payment";
            this.paymentDataGridViewCheckBoxColumn.HeaderText = "Payment";
            this.paymentDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.paymentDataGridViewCheckBoxColumn.Name = "paymentDataGridViewCheckBoxColumn";
            this.paymentDataGridViewCheckBoxColumn.Width = 125;
            // 
            // deliverySlipBindingSource
            // 
            this.deliverySlipBindingSource.DataMember = "DeliverySlip";
            this.deliverySlipBindingSource.DataSource = this.iPCDataSet;
            // 
            // iPCDataSet
            // 
            this.iPCDataSet.DataSetName = "IPCDataSet";
            this.iPCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deliverySlipTableAdapter
            // 
            this.deliverySlipTableAdapter.ClearBeforeFill = true;
            // 
            // dangGiaoButton
            // 
            this.dangGiaoButton.AutoSize = true;
            this.dangGiaoButton.Location = new System.Drawing.Point(186, 36);
            this.dangGiaoButton.Name = "dangGiaoButton";
            this.dangGiaoButton.Size = new System.Drawing.Size(89, 20);
            this.dangGiaoButton.TabIndex = 1;
            this.dangGiaoButton.TabStop = true;
            this.dangGiaoButton.Text = "Delivering";
            this.dangGiaoButton.UseVisualStyleBackColor = true;
            // 
            // chuaGiaoButton
            // 
            this.chuaGiaoButton.AutoSize = true;
            this.chuaGiaoButton.Location = new System.Drawing.Point(6, 36);
            this.chuaGiaoButton.Name = "chuaGiaoButton";
            this.chuaGiaoButton.Size = new System.Drawing.Size(139, 20);
            this.chuaGiaoButton.TabIndex = 2;
            this.chuaGiaoButton.TabStop = true;
            this.chuaGiaoButton.Text = "Prepairing Product";
            this.chuaGiaoButton.UseVisualStyleBackColor = true;
            // 
            // dagiaoButton
            // 
            this.dagiaoButton.AutoSize = true;
            this.dagiaoButton.Location = new System.Drawing.Point(339, 36);
            this.dagiaoButton.Name = "dagiaoButton";
            this.dagiaoButton.Size = new System.Drawing.Size(98, 20);
            this.dagiaoButton.TabIndex = 3;
            this.dagiaoButton.TabStop = true;
            this.dagiaoButton.Text = "Delieveried";
            this.dagiaoButton.UseVisualStyleBackColor = true;
            // 
            // statusBox
            // 
            this.statusBox.Controls.Add(this.dangGiaoButton);
            this.statusBox.Controls.Add(this.dagiaoButton);
            this.statusBox.Controls.Add(this.chuaGiaoButton);
            this.statusBox.Location = new System.Drawing.Point(156, 310);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(443, 72);
            this.statusBox.TabIndex = 4;
            this.statusBox.TabStop = false;
            this.statusBox.Text = "Status";
            // 
            // confirmChangeButton
            // 
            this.confirmChangeButton.Location = new System.Drawing.Point(579, 388);
            this.confirmChangeButton.Name = "confirmChangeButton";
            this.confirmChangeButton.Size = new System.Drawing.Size(137, 50);
            this.confirmChangeButton.TabIndex = 6;
            this.confirmChangeButton.Text = "Confirm";
            this.confirmChangeButton.UseVisualStyleBackColor = true;
            this.confirmChangeButton.Click += new System.EventHandler(this.confirmChangeButton_Click);
            // 
            // DeliveryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.confirmChangeButton);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.deliverySlipGridView);
            this.Name = "DeliveryManagement";
            this.Text = "DeliveryManagement";
            this.Load += new System.EventHandler(this.DeliveryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deliverySlipGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliverySlipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPCDataSet)).EndInit();
            this.statusBox.ResumeLayout(false);
            this.statusBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView deliverySlipGridView;
        private IPCDataSet iPCDataSet;
        private System.Windows.Forms.BindingSource deliverySlipBindingSource;
        private IPCDataSetTableAdapters.DeliverySlipTableAdapter deliverySlipTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn paymentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.RadioButton dangGiaoButton;
        private System.Windows.Forms.RadioButton chuaGiaoButton;
        private System.Windows.Forms.RadioButton dagiaoButton;
        private System.Windows.Forms.GroupBox statusBox;
        private System.Windows.Forms.Button confirmChangeButton;
    }
}