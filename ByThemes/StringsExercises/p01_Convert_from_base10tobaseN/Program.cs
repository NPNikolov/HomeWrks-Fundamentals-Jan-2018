using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace p01_Convert_from_base10tobaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = Console.ReadLine().Split(new char[] { ' ','.' ,','}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            int n = (int)Math.Round(double.Parse(strArr[0]));
            BigInteger numbrAtBas10 = BigInteger.Parse(strArr[1]);
            var lsRmnngs = new List<BigInteger>();
            BigInteger rmnng = 0;
            BigInteger mainPart = numbrAtBas10;
            do
            {
                rmnng = mainPart % n;
                mainPart /= n;
                lsRmnngs.Add(rmnng);
            } while (mainPart>n);
            string nBasedStr = "" + mainPart;
            for (int i = lsRmnngs.Count;i>0; i--)
            {
                nBasedStr += lsRmnngs[i - 1];
            }
            Console.WriteLine(nBasedStr);
        }
    }
}
