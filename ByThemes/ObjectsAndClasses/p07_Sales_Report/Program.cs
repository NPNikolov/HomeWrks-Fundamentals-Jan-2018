using System;
using System.Collections.Generic;
using System.Linq;

namespace p07_Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Sale[] arraySales = LoadArraySales(n);
            SortedDictionary<string,double> mapSales = FillMapSales(arraySales, n);
            PrintSales(mapSales);
        }

        private static void PrintSales(SortedDictionary<string, double> mapSales)
        {
            foreach (var item in mapSales)
            {
                Console.WriteLine($"{item.Key} -> {item.Value,0:f2}");
            }
        }

        private static SortedDictionary<string, double> FillMapSales(Sale[] arraySales, int n)
        {
            var mapSales = new SortedDictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                bool found = false;
                double total = arraySales[i].CalcAmount();
                found = mapSales.TryGetValue(arraySales[i].Town, out double totalTmp);
                if (found)
                {
                    total += totalTmp;
                }
                mapSales[arraySales[i].Town] = total;
            }
            return mapSales;
        }

        private static Sale[] LoadArraySales(int n)
        {
            Sale[] arraySales = new Sale[n];
            for (int i = 0; i < n; i++)
            {
                var strArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                double price = double.Parse(strArr[2]);
                double qntty = double.Parse(strArr[3]);
                arraySales[i] = Sale.CreateSale(strArr[0], strArr[1], price, qntty);
            }
            return arraySales;
        }
    }
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public double CalcAmount()
        {
            double amount = this.Quantity * this.Price;
            return amount;
        }
        public static Sale CreateSale(string town, string product, double price, double quantity)
        {
            Sale sale = new Sale() { Town = town, Product = product, Price = price, Quantity = quantity };
            return sale;
        }
    }
}
