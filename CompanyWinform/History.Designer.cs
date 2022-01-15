namespace CompanyWinform
{
    partial class History
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
            this.historyGridView = new System.Windows.Forms.DataGridView();
            this.costAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deliveryGridView = new System.Windows.Forms.DataGridView();
            this.iPCDataSet = new CompanyWinform.IPCDataSet();
            this.iPCDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPCDataSet1 = new CompanyWinform.IPCDataSet1();
            this.itemInCartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemInCartTableAdapter = new CompanyWinform.IPCDataSet1TableAdapters.ItemInCartTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.inComeTXT = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.historyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPCDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPCDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemInCartBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // historyGridView
            // 
            this.historyGridView.BackgroundColor = System.Drawing.Color.Brown;
            this.historyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyGridView.Location = new System.Drawing.Point(18, 64);
            this.historyGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.historyGridView.Name = "historyGridView";
            this.historyGridView.RowHeadersWidth = 51;
            this.historyGridView.RowTemplate.Height = 24;
            this.historyGridView.Size = new System.Drawing.Size(652, 516);
            this.historyGridView.TabIndex = 0;
            this.historyGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historyGridView_CellClick);
            // 
            // costAmount
            // 
            this.costAmount.AutoSize = true;
            this.costAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costAmount.ForeColor = System.Drawing.Color.Red;
            this.costAmount.Location = new System.Drawing.Point(14, 673);
            this.costAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.costAmount.Name = "costAmount";
            this.costAmount.Size = new System.Drawing.Size(36, 39);
            this.costAmount.TabIndex = 2;
            this.costAmount.Text = "0";
            this.costAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 617);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Outcome";
            // 
            // deliveryGridView
            // 
            this.deliveryGridView.BackgroundColor = System.Drawing.Color.Lime;
            this.deliveryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deliveryGridView.Location = new System.Drawing.Point(746, 64);
            this.deliveryGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deliveryGridView.Name = "deliveryGridView";
            this.deliveryGridView.RowHeadersWidth = 51;
            this.deliveryGridView.RowTemplate.Height = 24;
            this.deliveryGridView.Size = new System.Drawing.Size(662, 516);
            this.deliveryGridView.TabIndex = 4;
            this.deliveryGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deliveryGridView_CellClick);
            // 
            // iPCDataSet
            // 
            this.iPCDataSet.DataSetName = "IPCDataSet";
            this.iPCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iPCDataSetBindingSource
            // 
            this.iPCDataSetBindingSource.DataSource = this.iPCDataSet;
            this.iPCDataSetBindingSource.Position = 0;
            // 
            // iPCDataSet1
            // 
            this.iPCDataSet1.DataSetName = "IPCDataSet1";
            this.iPCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemInCartBindingSource
            // 
            this.itemInCartBindingSource.DataMember = "ItemInCart";
            this.itemInCartBindingSource.DataSource = this.iPCDataSet1;
            // 
            // itemInCartTableAdapter
            // 
            this.itemInCartTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(741, 617);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Income";
            // 
            // inComeTXT
            // 
            this.inComeTXT.AutoSize = true;
            this.inComeTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inComeTXT.ForeColor = System.Drawing.Color.Lime;
            this.inComeTXT.Location = new System.Drawing.Point(738, 673);
            this.inComeTXT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inComeTXT.Name = "inComeTXT";
            this.inComeTXT.Size = new System.Drawing.Size(36, 39);
            this.inComeTXT.TabIndex = 6;
            this.inComeTXT.Text = "0";
            this.inComeTXT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(745, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(600, 24);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Click row to see Export Receipt";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(19, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(600, 24);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Click row to see Import Receipt";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 781);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.inComeTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deliveryGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.costAmount);
            this.Controls.Add(this.historyGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPCDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPCDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemInCartBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView historyGridView;
        private System.Windows.Forms.Label costAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView deliveryGridView;
        private IPCDataSet iPCDataSet;
        private System.Windows.Forms.BindingSource iPCDataSetBindingSource;
        private IPCDataSet1 iPCDataSet1;
        private System.Windows.Forms.BindingSource itemInCartBindingSource;
        private IPCDataSet1TableAdapters.ItemInCartTableAdapter itemInCartTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label inComeTXT;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}