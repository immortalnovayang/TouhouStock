using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouhouStock
{
    public partial class CompanyForm : Form
    {
        //public CompanyData[] companies;
        BuySellForm buySellForm;
        public GameData gameData;
        DataTable table;
        public CompanyForm()
        {
            InitializeComponent();
            DataTable table = new DataTable();
            //string[] row1 = new string[] { "column1 value", "column2 value" };
            //dataGridView1.Rows.Add(row1);
            //table.Columns.Add("CompanyName");
            //table.Columns.Add("IssuedShares");
            /*
            DataRow row;
            for (int i = 0; i < 10; i++)
            {
                row = table.NewRow();
                row["CompanyName"] = i;
                row["IssuedShares"] = "item " + i.ToString();
                table.Rows.Add(row);
            }

            dataGridView1.DataSource = table;*/
            //Console.WriteLine("1"+companies);


            //Console.WriteLine(companies[0].CompanyName);
            Thread t = new Thread(new ThreadStart(ThreadProc));
            t.Start();
        }

        public void setDataSource()
        {
            dataGridView1.DataSource = GameData.companyArray;
        }

        public void update()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToDouble(row.Cells[5].Value) > 0)
                {
                    row.Cells[6].Style.ForeColor = Color.Red;
                }
                else if (Convert.ToDouble(row.Cells[5].Value) < 0)
                {
                    row.Cells[6].Style.ForeColor = Color.Green;
                }
                else
                {
                    row.Cells[6].Style.ForeColor = Color.Black;
                }

                if (Convert.ToDouble(row.Cells[5].Value) > 0)
                {
                    row.Cells[5].Style.ForeColor = Color.Red;
                }
                else if (Convert.ToDouble(row.Cells[5].Value) < 0)
                {
                    row.Cells[5].Style.ForeColor = Color.Green;
                }
                else
                {

                    row.Cells[5].Style.ForeColor = Color.Black;
                }
            }

            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        public void ThreadProc()
        {


            while (true)
            {
                update();

                Thread.Sleep(1000);
            }
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            Form.CheckForIllegalCrossThreadCalls = false;
        }

     
    

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string value1 = row.Cells[0].Value.ToString();
                string value2 = row.Cells[1].Value.ToString();
                Console.WriteLine(value1);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GameData.marketOpened)
            {
                if (buySellForm == null)
                {
                    Console.WriteLine("init BuySellForm");
                    buySellForm = new BuySellForm();
                    buySellForm.gameData = gameData;
                    buySellForm.dataGridView1 = dataGridView1;


                }
                buySellForm.buyOrSell = 1;
                buySellForm.SetBuyChecked();
                int stockIndex = getCompanyID();
                buySellForm.stockIndex = stockIndex;
                buySellForm.setPrice(getCompanyPrice(stockIndex));
                //顯示對話框
                buySellForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("還沒開盤");
            }
          
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GameData.marketOpened)
            {
                if (buySellForm == null)
                {
                    Console.WriteLine("init BuySellForm");
                    buySellForm = new BuySellForm();
                    buySellForm.gameData = gameData;
                    buySellForm.dataGridView1 = dataGridView1;


                }
                buySellForm.SetSellChecked();
                buySellForm.buyOrSell = 2;
                int stockIndex = getCompanyID();
                buySellForm.stockIndex = stockIndex;
                buySellForm.setPrice(getCompanyPrice(stockIndex));
                buySellForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("還沒開盤");
            }
       
        }

        public int getCompanyID()
        {
            int index = 0;
            Int32 selectedRowCount = 0;
           

            if (dataGridView1.SelectedCells.Count > 0)
            {
                selectedRowCount = dataGridView1.SelectedCells[0].RowIndex;
    
            }
            else
            {
                //selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            }
            Console.WriteLine("selectedRowCount = " + selectedRowCount);

            /*if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRowCount; i++)
                {

                    index = dataGridView1.SelectedRows[i].Index;


                }

            }*/


        
            return selectedRowCount;
        }

        public double getCompanyPrice(int index)
        {
            double price = GameData.companyArray[index].ClosingPrice;
            return price;
        }
      
    }
}
