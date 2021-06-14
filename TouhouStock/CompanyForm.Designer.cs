
namespace TouhouStock
{
    partial class CompanyForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssuedShares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarketCapitalization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClosingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangePercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TodayPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyName,
            this.IssuedShares,
            this.MarketCapitalization,
            this.ClosingPrice,
            this.NetChange,
            this.ChangePercent,
            this.TodayPrice});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(776, 284);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(610, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "買進";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cancelButton.Location = new System.Drawing.Point(12, 322);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(178, 70);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "公司名稱";
            this.CompanyName.MinimumWidth = 6;
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            this.CompanyName.Width = 125;
            // 
            // IssuedShares
            // 
            this.IssuedShares.DataPropertyName = "IssuedShares";
            this.IssuedShares.HeaderText = "已發行股數";
            this.IssuedShares.MinimumWidth = 6;
            this.IssuedShares.Name = "IssuedShares";
            this.IssuedShares.ReadOnly = true;
            this.IssuedShares.Visible = false;
            this.IssuedShares.Width = 125;
            // 
            // MarketCapitalization
            // 
            this.MarketCapitalization.DataPropertyName = "MarketCapitalization";
            this.MarketCapitalization.HeaderText = "市值";
            this.MarketCapitalization.MinimumWidth = 6;
            this.MarketCapitalization.Name = "MarketCapitalization";
            this.MarketCapitalization.ReadOnly = true;
            this.MarketCapitalization.Visible = false;
            this.MarketCapitalization.Width = 125;
            // 
            // ClosingPrice
            // 
            this.ClosingPrice.DataPropertyName = "ClosingPrice";
            this.ClosingPrice.HeaderText = "成交價";
            this.ClosingPrice.MinimumWidth = 6;
            this.ClosingPrice.Name = "ClosingPrice";
            this.ClosingPrice.ReadOnly = true;
            this.ClosingPrice.Width = 125;
            // 
            // NetChange
            // 
            this.NetChange.DataPropertyName = "NetChange";
            this.NetChange.HeaderText = "漲跌";
            this.NetChange.MinimumWidth = 6;
            this.NetChange.Name = "NetChange";
            this.NetChange.ReadOnly = true;
            this.NetChange.Width = 70;
            // 
            // ChangePercent
            // 
            this.ChangePercent.DataPropertyName = "ChangePercent";
            this.ChangePercent.HeaderText = "漲跌(%)";
            this.ChangePercent.MinimumWidth = 6;
            this.ChangePercent.Name = "ChangePercent";
            this.ChangePercent.ReadOnly = true;
            this.ChangePercent.Width = 70;
            // 
            // TodayPrice
            // 
            this.TodayPrice.DataPropertyName = "TodayPrice";
            this.TodayPrice.HeaderText = "開盤價";
            this.TodayPrice.MinimumWidth = 6;
            this.TodayPrice.Name = "TodayPrice";
            this.TodayPrice.ReadOnly = true;
            this.TodayPrice.Width = 125;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(426, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 70);
            this.button2.TabIndex = 4;
            this.button2.Text = "賣出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "上市公司一覽";
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssuedShares;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarketCapitalization;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClosingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangePercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn TodayPrice;
        private System.Windows.Forms.Button button2;
    }
}