using System;
using System.Collections.Generic;
using System.Linq;


namespace p02_Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var strngDctnr = new Dictionary<string, int>();
            foreach (var item in array)
            {
                string itemLwr = item.ToLower();
                bool fnd = strngDctnr.TryGetValue(itemLwr, out int nmbr);
                if (fnd)
                {
                    nmbr++;
                } else nmbr = 1;
                strngDctnr[itemLwr] = nmbr;
            }
            var newDctnr = new Dictionary<string, int>();
            foreach (var item in strngDctnr)
            {
                if (item.Value%2==1)
                {
                    newDctnr.Add(item.Key, item.Value);
                }
            }
            Console.WriteLine(string.Join(", ", newDctnr.Keys));
        }
    }
}
