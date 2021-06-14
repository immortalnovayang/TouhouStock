﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouhouStock
{
    public partial class Form1 : Form
    {
        CompanyForm companyForm;
        MyStockForm MyStockForm;
     

       

        GameData gameData;

        public Form1()
        {
            gameData = new GameData(this);

            InitializeComponent();

        
        }

       
        private void init()
        {

       

            Thread t = new Thread(new ThreadStart(ThreadProc));
            t.Start();
        }

       
        public void ThreadProc()
        {

           

            Random rand = new Random(Guid.NewGuid().GetHashCode());
         

            while (true)
            {
                if (GameData.loadFinished && GameData.marketOpened)
                {

                    for(int i = 0;i < GameData.companyArray.Count; i++)
                    {
                        CompanyData companyData = GameData.companyArray[i];
                        //漲0.1~1%，0.001  0.01

                        double dice1 = rand.NextDouble() * 100;
                        double dice2 = -rand.NextDouble() * 100;

                        double p = (dice1 + dice2) / 1000;
                        //p = 0.01;
                        p = Math.Round(p, 2, MidpointRounding.AwayFromZero);

                        GameData.companyArray[i].ChangePercent = p + "%";
                        //Console.WriteLine("ChangePercent = " + p);

                        double NetChange = p * companyData.TodayPrice;
                        NetChange = Math.Round(NetChange, 2, MidpointRounding.AwayFromZero);
                        //Console.WriteLine("NetChange = " + NetChange);


                        companyData.ClosingPrice = companyData.TodayPrice + NetChange;

                        companyData.NetChange = NetChange + "";


                        companyData.ClosingPrice = companyData.ClosingPrice;
                    }
                  

                    stockLabel.Text = gameData.getTotalStock() + "";
                }

                //時間經過一秒
                if (GameData.dateTime != null)
                {
                    GameData.dateTime = GameData.dateTime.AddMinutes(1);
                    dateTimeValuelabel.Text = GameData.dateTime.ToString();

                    // 距離開盤還有60分鐘
                    // 開盤
                    //GameData.marketOpened = true;

                    // 收盤(暫停處理股價更新 和 停止買賣功能)
                }
           

                Thread.Sleep(1000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (companyForm == null)
            {
                Console.WriteLine("init CompanyForm");
                companyForm = new CompanyForm();
                companyForm.gameData = gameData;
                //companyForm.companies = companies;
                //Console.WriteLine("CompanyForm " + companyForm.companies[0].CompanyName);
            }

            companyForm.setDataSource();
            companyForm.ShowDialog();
    
            //companyForm.update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form.CheckForIllegalCrossThreadCalls = false;
            init();
        }

        internal void setMoneyText(double money)
        {
            moneyValueLabael.Text = money + "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void myStockButton_Click(object sender, EventArgs e)
        {
            if (MyStockForm == null)
            {
                Console.WriteLine("init MyStockForm");
                MyStockForm = new MyStockForm();
                //myStockButton.gameData = gameData;
            }

            GameData.myStockArray.Clear();
            foreach (DictionaryEntry de in GameData.holdStockMap)
            {
                HoldStock hs = (HoldStock)de.Value;
                int index = (int)de.Key;
                MyStock myStock = new MyStock();
                myStock.CompanyName = GameData.companyArray[index].CompanyName;
                myStock.NumOfStock = hs.numOfHold;
                myStock.OriPrice = hs.totalPrice / hs.numOfHold;
                myStock.NowPrice = GameData.companyArray[index].ClosingPrice;
                myStock.Profit = myStock.NowPrice - myStock.OriPrice;
                myStock.Profit = Math.Round(myStock.Profit, 2, MidpointRounding.AwayFromZero);
                double ProfitRatio = myStock.Profit * 100 / myStock.OriPrice;
                myStock.ProfitRatio = Math.Round(ProfitRatio, 2, MidpointRounding.AwayFromZero)+"%";
                GameData.myStockArray.Add(myStock);

            }


            MyStockForm.setDataSource();
            MyStockForm.ShowDialog();
        }
    }

    public class CompanyData
    {
        public string CompanyName { get; set; }
        public int IssuedShares { get; set; }
        public string MarketCapitalization { get; set; }

        public double TodayPrice { get; set; }
        public double ClosingPrice { get; set; }

        public string NetChange { get; set; }

        public string ChangePercent { get; set; }


    }

    public class HoldStock
    {
        public int numOfHold { get; set; }

        public double totalPrice { get; set; }
    }

    public class MyStock
    {
        public string CompanyName { get; set; }
        public int NumOfStock { get; set; }
        public double OriPrice { get; set; }
        public double NowPrice { get; set; }
        public double Profit { get; set; }
        public string ProfitRatio { get; set; }
        



    }
}