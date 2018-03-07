using System;

namespace p11_Price_Change_Alert
{
    class PriceChangeAlert
    {
        static void Main()
        {
            int numberPrices = int.Parse(Console.ReadLine());
            double threshld = double.Parse(Console.ReadLine());
            double lastKnowPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberPrices - 1; i++)
            {
                double newPrice = double.Parse(Console.ReadLine());
                double rateDiff = FindRateDifference(lastKnowPrice, newPrice);
                bool isSignificantDifference = IsSignificantlyDifferent(rateDiff, threshld);
                string message = GetMessage(newPrice, lastKnowPrice, rateDiff, isSignificantDifference);

                Console.WriteLine(message);

                lastKnowPrice = newPrice;
            }
        }

        private static string GetMessage(double newPrice, double lastKnowPrice, double rateDiff, bool isSignificantDifference)
        {
            string message = "";
            double toPercentage = rateDiff * 100.0;
            if (rateDiff == 0)
            {
                message = string.Format("NO CHANGE: {0}", newPrice);
            }
            else if (!isSignificantDifference)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastKnowPrice, newPrice, toPercentage);
            }
            else if (isSignificantDifference && (rateDiff > 0))
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastKnowPrice, newPrice, toPercentage);
            }
            else if (isSignificantDifference && (rateDiff < 0))
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastKnowPrice, newPrice, toPercentage);
            return message;
        }

        private static bool IsSignificantlyDifferent(double amntChange, double threshold)
        {
            if (Math.Abs(amntChange) >= threshold)
            {
                return true;
            }
            return false;
        }

        private static double FindRateDifference(double lastKnowPrice, double newPrice)
        {
            double rate = (newPrice - lastKnowPrice) / lastKnowPrice;
            return rate;
        }
    }
}
