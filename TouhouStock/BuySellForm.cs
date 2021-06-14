using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouhouStock
{
    public partial class BuySellForm : Form
    {
        public GameData gameData;

        public DataGridView dataGridView1;

        public int buyOrSell = 1;

        public int stockIndex = 0;
        public BuySellForm()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numOfBuySellLabel.Text = numOfBuySellTrackBar.Value + "";
        }

        internal void setPrice(double currentPrice)
        {
            priceLabel.Text = currentPrice + "";
        }

        public void SetBuyChecked()
        {

            radioButton1.Checked = true;
            radioButton2.Checked = false;
        }

        public void SetSellChecked()
        {
            radioButton2.Checked = true;
            radioButton1.Checked = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
           


            //Console.WriteLine("index=" + index);

            int value = numOfBuySellTrackBar.Value;

            //double price = GameData.companyArray[index].ClosingPrice;
            double price = Double.Parse(priceLabel.Text);

            if (radioButton1.Checked)
            {
                //Console.WriteLine(price * (1 + GameData.TransactionFees));
                //錢夠才能買
                if (GameData.money >= price * (1 + GameData.TransactionFees))
                    gameData.buyStock(stockIndex, value, price);
                else
                    MessageBox.Show("錢不夠");
                
            }
            else
            {
                //有這張股票並且張數夠才可以賣
                if (GameData.holdStockMap.ContainsKey(stockIndex))
                {
                    HoldStock holdStock = (HoldStock)GameData.holdStockMap[stockIndex];
                    if (holdStock.numOfHold >= value)
                        gameData.sellStock(stockIndex, value, price);
                    else
                        MessageBox.Show("張數不夠");
                }
            }
              

            Hide();
        }

        private void radioButton1_VisibleChanged(object sender, EventArgs e)
        {
            if (buyOrSell == 1)
                SetBuyChecked();
            else
                SetSellChecked();
        }
    }
}
