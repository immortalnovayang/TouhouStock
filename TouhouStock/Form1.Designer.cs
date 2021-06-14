
namespace TouhouStock
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.moneyValueLabael = new System.Windows.Forms.Label();
            this.stockLabel = new System.Windows.Forms.Label();
            this.myStockButton = new System.Windows.Forms.Button();
            this.dateTimelabel = new System.Windows.Forms.Label();
            this.dateTimeValuelabel = new System.Windows.Forms.Label();
            this.dateTipLabel = new System.Windows.Forms.Label();
            this.nextDayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(17, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "看上市公司";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.moneyLabel.Location = new System.Drawing.Point(12, 54);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(68, 28);
            this.moneyLabel.TabIndex = 1;
            this.moneyLabel.Text = "現金";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "股票市值";
            // 
            // moneyValueLabael
            // 
            this.moneyValueLabael.AutoSize = true;
            this.moneyValueLabael.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.moneyValueLabael.Location = new System.Drawing.Point(154, 54);
            this.moneyValueLabael.Name = "moneyValueLabael";
            this.moneyValueLabael.Size = new System.Drawing.Size(103, 28);
            this.moneyValueLabael.TabIndex = 3;
            this.moneyValueLabael.Text = "1000000";
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stockLabel.Location = new System.Drawing.Point(154, 106);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(25, 28);
            this.stockLabel.TabIndex = 4;
            this.stockLabel.Text = "0";
            // 
            // myStockButton
            // 
            this.myStockButton.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myStockButton.Location = new System.Drawing.Point(196, 468);
            this.myStockButton.Name = "myStockButton";
            this.myStockButton.Size = new System.Drawing.Size(173, 73);
            this.myStockButton.TabIndex = 5;
            this.myStockButton.Text = "持股明細";
            this.myStockButton.UseVisualStyleBackColor = true;
            this.myStockButton.Click += new System.EventHandler(this.myStockButton_Click);
            // 
            // dateTimelabel
            // 
            this.dateTimelabel.AutoSize = true;
            this.dateTimelabel.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimelabel.Location = new System.Drawing.Point(12, 9);
            this.dateTimelabel.Name = "dateTimelabel";
            this.dateTimelabel.Size = new System.Drawing.Size(68, 28);
            this.dateTimelabel.TabIndex = 6;
            this.dateTimelabel.Text = "日期";
            // 
            // dateTimeValuelabel
            // 
            this.dateTimeValuelabel.AutoSize = true;
            this.dateTimeValuelabel.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimeValuelabel.Location = new System.Drawing.Point(154, 9);
            this.dateTimeValuelabel.Name = "dateTimeValuelabel";
            this.dateTimeValuelabel.Size = new System.Drawing.Size(279, 28);
            this.dateTimeValuelabel.TabIndex = 7;
            this.dateTimeValuelabel.Text = "1996/11/1 上午 08:01:00";
            // 
            // dateTipLabel
            // 
            this.dateTipLabel.AutoSize = true;
            this.dateTipLabel.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTipLabel.Location = new System.Drawing.Point(460, 9);
            this.dateTipLabel.Name = "dateTipLabel";
            this.dateTipLabel.Size = new System.Drawing.Size(262, 28);
            this.dateTipLabel.TabIndex = 8;
            this.dateTipLabel.Text = "距離開盤還有60分鐘";
            // 
            // nextDayButton
            // 
            this.nextDayButton.Enabled = false;
            this.nextDayButton.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nextDayButton.Location = new System.Drawing.Point(577, 468);
            this.nextDayButton.Name = "nextDayButton";
            this.nextDayButton.Size = new System.Drawing.Size(193, 73);
            this.nextDayButton.TabIndex = 9;
            this.nextDayButton.Text = "下回合(明天)";
            this.nextDayButton.UseVisualStyleBackColor = true;
            this.nextDayButton.Click += new System.EventHandler(this.nextDayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.nextDayButton);
            this.Controls.Add(this.dateTipLabel);
            this.Controls.Add(this.dateTimeValuelabel);
            this.Controls.Add(this.dateTimelabel);
            this.Controls.Add(this.myStockButton);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.moneyValueLabael);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TouhouStock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label moneyValueLabael;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Button myStockButton;
        private System.Windows.Forms.Label dateTimelabel;
        private System.Windows.Forms.Label dateTimeValuelabel;
        private System.Windows.Forms.Label dateTipLabel;
        private System.Windows.Forms.Button nextDayButton;
    }
}

