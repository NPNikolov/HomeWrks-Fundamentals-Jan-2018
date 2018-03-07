using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace p07_Andrey_and_Billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            int nmbrItems = int.Parse(Console.ReadLine());
            var itemMap = new Dictionary<string, double>(nmbrItems);
            var customerMap = new SortedDictionary<string,Customer>();
            for (int i = 0; i < nmbrItems; i++)
            {
                string[] strArr = Console.ReadLine().Split(new[] { '-' }).ToArray();
                string itemStr = strArr[0];
                itemMap[itemStr] = double.Parse(strArr[1]);
            }
            string cmd = "";
            do
            {
                cmd = Console.ReadLine();
                if (!cmd.Equals("end of clients"))
                {
                    string[] strArr = cmd.Split(new[] { '-' }).ToArray();
                    string nameStr = strArr[0];
                    string[] strArrOrder = strArr[1].Split(new[] { ',' }).ToArray();
                    if (itemMap.Keys.Contains(strArrOrder[0]))
                    {
                        int qtty = int.Parse(strArrOrder[1]);
                        double price = itemMap[strArrOrder[0]] * qtty;
                        bool found = customerMap.TryGetValue(nameStr, out Customer cstmrObj);
                        var cstmr = new Customer();
                        if (found)
                        {
                            cstmr = cstmrObj;
                            bool fndItem = cstmr.OrderList.TryGetValue(strArrOrder[0], out int crrntQtty);
                            int newQtty = qtty;
                            if (fndItem)
                            {
                                newQtty += crrntQtty;
                            }
                            cstmr.OrderList[strArrOrder[0]] = newQtty;
                        }
                        else
                        {
                            cstmr.Name = nameStr;
                            var orderLs = new Dictionary<string, int>();
                            orderLs[strArrOrder[0]] = qtty;
                            cstmr.OrderList = orderLs;
                            cstmr.Bill = 0.0;
                        }
                        cstmr.Bill += price;
                        customerMap[nameStr] = cstmr;
                    }
                }
            } while (!(cmd== "end of clients"));

            double totalBill = 0.0;
            foreach (var item in customerMap)
            {
                Console.WriteLine(item.Key);

                totalBill += item.Value.Bill;
                foreach (var item1 in item.Value.OrderList)
                {
                    Console.WriteLine($"-- {item1.Key} - {item1.Value}");
                }
                Console.WriteLine($"Bill: {item.Value.Bill,0:f2}");
            }
            Console.WriteLine($"Total bill: {totalBill,0:f2}");
        }
    }
    class Customer
    {
        public string Name { get; set; }
        public Dictionary <string,int> OrderList { get; set; }
        public double Bill { get; set; }
    }
}
