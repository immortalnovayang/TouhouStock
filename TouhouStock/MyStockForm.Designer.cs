
namespace TouhouStock
{
    partial class MyStockForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumOfStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NowPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfitRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyName,
            this.NumOfStock,
            this.OriPrice,
            this.NowPrice,
            this.Profit,
            this.ProfitRatio});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(973, 335);
            this.dataGridView.TabIndex = 0;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "名稱";
            this.CompanyName.MinimumWidth = 6;
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            this.CompanyName.Width = 125;
            // 
            // NumOfStock
            // 
            this.NumOfStock.DataPropertyName = "NumOfStock";
            this.NumOfStock.HeaderText = "庫存張數";
            this.NumOfStock.MinimumWidth = 6;
            this.NumOfStock.Name = "NumOfStock";
            this.NumOfStock.ReadOnly = true;
            // 
            // OriPrice
            // 
            this.OriPrice.DataPropertyName = "OriPrice";
            this.OriPrice.HeaderText = "持有成本";
            this.OriPrice.MinimumWidth = 6;
            this.OriPrice.Name = "OriPrice";
            this.OriPrice.ReadOnly = true;
            // 
            // NowPrice
            // 
            this.NowPrice.DataPropertyName = "NowPrice";
            this.NowPrice.HeaderText = "現價";
            this.NowPrice.MinimumWidth = 6;
            this.NowPrice.Name = "NowPrice";
            this.NowPrice.ReadOnly = true;
            // 
            // Profit
            // 
            this.Profit.DataPropertyName = "Profit";
            this.Profit.HeaderText = "損益";
            this.Profit.MinimumWidth = 6;
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            // 
            // ProfitRatio
            // 
            this.ProfitRatio.DataPropertyName = "ProfitRatio";
            this.ProfitRatio.HeaderText = "損益率";
            this.ProfitRatio.MinimumWidth = 6;
            this.ProfitRatio.Name = "ProfitRatio";
            this.ProfitRatio.ReadOnly = true;
            // 
            // MyStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.dataGridView);
            this.Name = "MyStockForm";
            this.Text = "持股一覽(目前買的股票)";
            this.Load += new System.EventHandler(this.MyStockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOfStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn NowPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfitRatio;
    }
}