using System;

namespace p04_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] arrHallPriceTable = new double[3, 3];
            arrHallPriceTable[0, 0] = 50.0; arrHallPriceTable[0, 1] = 60.0; arrHallPriceTable[0, 2] = 68.0;
            arrHallPriceTable[1, 0] = 65.0; arrHallPriceTable[1, 1] = 72.0; arrHallPriceTable[1, 2] = 77.0;
            arrHallPriceTable[2, 0] = 75.0; arrHallPriceTable[2, 1] = 82.0; arrHallPriceTable[2, 2] = 89.0;

            String month = Console.ReadLine();
            int nmbrNights = int.Parse(Console.ReadLine());

            double priceStudio, priceDouble, priceSuite;
            int indexPrtce = -1;

            if ("May".Equals(month) || "October".Equals(month))
            {
                indexPrtce = 0;
            }
            else if ("June".Equals(month) || "September".Equals(month))
            {
                indexPrtce = 1;
            }
            else indexPrtce = 2;

            priceStudio = nmbrNights * arrHallPriceTable[0, indexPrtce]; priceDouble = nmbrNights * arrHallPriceTable[1, indexPrtce];
            priceSuite = nmbrNights * arrHallPriceTable[2, indexPrtce];

            if (nmbrNights>7)
            {
                if (nmbrNights<=14)
                {
                    
                    
                }
                else
                {
                    if (indexPrtce==1)
                    {
                        priceDouble = priceDouble - 0.1 * priceDouble;
                    }
                    else if (indexPrtce == 2)
                    {
                        priceSuite = priceSuite - 0.15 * priceSuite;
                    }

                }
            }
            if (("May".Equals(month) || "October".Equals(month))&& nmbrNights > 7)
            {
                priceStudio = priceStudio - 0.05 * priceStudio;
            }
            if ("September".Equals(month) || "October".Equals(month))
            {
                if (nmbrNights > 7)
                {
                 
                    priceStudio = priceStudio * (1 - (1.0 / nmbrNights));
                }
            }

            Console.WriteLine($"Studio: {priceStudio,0:f2} lv.");
            Console.WriteLine($"Double: {priceDouble,0:f2} lv.");
            Console.WriteLine($"Suite: {priceSuite,0:f2} lv.");


        }
    }
}
