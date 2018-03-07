using System;

namespace p03_Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] arrHallPriceTable = new double[2, 3];
            arrHallPriceTable[0, 0] = 2500.0; arrHallPriceTable[0, 1] = 5000.0; arrHallPriceTable[0, 2] = 7500.0;
            arrHallPriceTable[1, 0] = 50.0; arrHallPriceTable[1, 1] = 100.0; arrHallPriceTable[1, 2] = 120.0;

            double[,] arrDiscountTable = new double[2, 3];
            arrDiscountTable[0, 0] = 0.05; arrDiscountTable[0, 1] = 0.1; arrDiscountTable[0, 2] = 0.15;
            arrDiscountTable[1, 0] = 500.0; arrDiscountTable[1, 1] = 750.0; arrDiscountTable[1, 2] = 1000.0;

            int groupSize = int.Parse(Console.ReadLine());
            string pack = Console.ReadLine();

            int indexHallSize = -1;

            for (int i = 0; i <= 2; i++)
            {
                if (arrHallPriceTable[1,i]>=groupSize)
                {
                    indexHallSize = i;
                    break;
                }
            }

            int indexPack = -1;

            switch (pack)
            {
                case "Normal":indexPack = 0;
                    break;
                case "Gold":
                    indexPack = 1;
                    break;
                default:indexPack = 2;
                    break;
            }

            if (indexHallSize<0)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                double amnt = arrHallPriceTable[0, indexHallSize];
                amnt += arrDiscountTable[1, indexPack];
                amnt = amnt - amnt * arrDiscountTable[0, indexPack];
                amnt = amnt / groupSize;

                String hall = "";

                switch (indexHallSize)
                {
                    case 0:
                        hall = "Small Hall";
                        break;
                    case 1:
                        hall = "Terrace";
                        break;
                    default:
                        hall = "Great Hall";
                        break;
                }

                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {amnt,0:f2}$");
            }

           


        }
    }
}
