using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;
using System.Globalization;

namespace TouhouStock
{
    public class GameData
    {
        public static double money = 1000000;
        public Form1 form1;

        //public static double todayPrice = 200;
        //public static double currentPrice = 200;
        public static int numOfStock = 0;

        //CompanyData[] companies;// = new CompanyData[1];
        public static List<CompanyData> companyArray;

        //看持股用
        public static BindingList<MyStock> myStockArray;

        public static Hashtable holdStockMap;

        public static bool loadFinished = false;
        public static double TransactionFees = 0.001425;
        public static double TransferTax = 0.003;
        public static long ticks;
        public static DateTime dateTime;
        public static int timeState = 1; //1 2 3開盤前 中 後
        //是否開盤
        public static bool marketOpened = false;
        public GameData(Form1 form1)
        {
            this.form1 = form1;
            loadDataBase();

            //時間
            ticks = new DateTime(1996, 11, 01, 8, 0, 0,
            new CultureInfo("zh-TW", false).Calendar).Ticks;
            dateTime = new DateTime(ticks);
            //Console.WriteLine(dateTime.Hour);
        }

        public void loadDataBase()
        {
            holdStockMap = new Hashtable();
            companyArray = new List<CompanyData>();
            myStockArray = new BindingList<MyStock>();
            using (var connection = new SqliteConnection("Data Source=data.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                    SELECT *
                    FROM company
                ";
                //command.Parameters.AddWithValue("$id", 1);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var name = reader.GetString(0);
                        var IssuedShares = reader.GetInt32(1);
                        var ClosingPrice = reader.GetDouble(2);
                        CompanyData companyData = new CompanyData();
                        companyData.CompanyName = name;
                        companyData.IssuedShares = IssuedShares;
                        companyData.MarketCapitalization = "1";
                        companyData.ClosingPrice = ClosingPrice;
                        companyData.TodayPrice = ClosingPrice;
                        companyData.NetChange = "0";
                        companyData.ChangePercent = "0%";
                     
                        companyArray.Add(companyData);


                    }
                }

                loadFinished = true;
            }
        }

        /**
         * 交易手續費：0.1425%，買賣股票皆會收取，近年券商在手續費上給的折扣越來越多。 
         * 證券交易稅：0.3%，賣出股票時才會收取，交易稅由主管機關收取，無法降低。
         * */

        public void buyStock(int index,int num,double price)
        {
            Console.WriteLine("companyArray = " + companyArray.Count);
            Console.WriteLine("index = "+index);

            money -= companyArray[index].ClosingPrice * num * (1+TransactionFees);
            money = Math.Round(money, 2, MidpointRounding.AwayFromZero);
            //numOfStock += num;
            if (holdStockMap.ContainsKey(index))
            {
                HoldStock holdStock = (HoldStock)holdStockMap[index];
                holdStock.numOfHold += num;
                holdStock.totalPrice += num * price;
            }
            else
            {
                HoldStock holdStock = new HoldStock();
                holdStock.numOfHold += num;
                holdStock.totalPrice += num * price;
                holdStockMap.Add(index, holdStock);
            }
         
            //holdStockMap[index].numOfHold += num;
            form1.setMoneyText(money);

        }

        public void sellStock(int index,int num, double price)
        {
            Console.WriteLine("companyArray = " + companyArray.Count);
            Console.WriteLine("index = " + index);

            money += companyArray[index].ClosingPrice * num * (1 - TransactionFees - TransferTax);
            money = Math.Round(money, 2, MidpointRounding.AwayFromZero);
            if (holdStockMap.ContainsKey(index))
            {
                HoldStock holdStock = (HoldStock)holdStockMap[index];
                holdStock.numOfHold -= num;
                holdStock.totalPrice -= num * price;

            }
            else
            {
                //沒股票可賣
            }

            //holdStockMap[index].numOfHold += num;
            form1.setMoneyText(money);

        }

        public double getTotalStock()
        {
            double sum = 0;

            if(GameData.holdStockMap!=null)
                /*for (int i = 0; i < GameData.holdStockMap.Count; i++)
                {
                    sum += GameData.holdStockMap[i].totalPrice;
                }*/

            foreach (DictionaryEntry de in GameData.holdStockMap)
            {
                    //Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
                    HoldStock hs = (HoldStock)de.Value; 
                    int index = (int)de.Key;
                    sum += companyArray[index].ClosingPrice * hs.numOfHold;
            }


            return sum;
        }
    }
}
