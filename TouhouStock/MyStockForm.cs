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
    public partial class MyStockForm : Form
    {
        public MyStockForm()
        {
            InitializeComponent();
            Thread t = new Thread(new ThreadStart(ThreadProc));
            t.Start();
        }

        public void setDataSource()
        {
            dataGridView.DataSource = GameData.myStockArray;
        }

        private void MyStockForm_Load(object sender, EventArgs e)
        {
            Form.CheckForIllegalCrossThreadCalls = false;
        }

        public void ThreadProc()
        {


            while (true)
            {
                update();

                Thread.Sleep(1000);
            }
        }

        public void update()
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (Convert.ToDouble(row.Cells[4].Value) > 0)
                {
                    row.Cells[4].Style.ForeColor = Color.Red;
                }
                else if (Convert.ToDouble(row.Cells[4].Value) < 0)
                {
                    row.Cells[4].Style.ForeColor = Color.Green;
                }
                else
                {
                    row.Cells[4].Style.ForeColor = Color.Black;
                }

                if (Convert.ToDouble(row.Cells[4].Value) > 0)
                {
                    row.Cells[5].Style.ForeColor = Color.Red;
                }
                else if (Convert.ToDouble(row.Cells[4].Value) < 0)
                {
                    row.Cells[5].Style.ForeColor = Color.Green;
                }
                else
                {

                    row.Cells[5].Style.ForeColor = Color.Black;
                }
            }
         

            dataGridView.Update();
            dataGridView.Refresh();
        }
    }
}
