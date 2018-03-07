using System;
using System.Collections.Generic;
using System.Linq;


namespace p06_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var intLs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int lsSize = intLs.Count;
            int k = lsSize / 4;
            var lsLwr = intLs.Take(k).Reverse().ToList();
            int[] tmp = new int[lsSize];
            intLs.CopyTo(tmp);
            var lsRvrs = tmp.Reverse().ToList();
            var lsUpper = lsRvrs.Take(k).ToList();
            lsLwr.AddRange(lsUpper);
            var row2 = intLs.GetRange(k, 2 * k);

            var sum = lsLwr.Select((x, index) => x + row2[index]);
            Console.WriteLine(string.Join(" ", sum));

        }
    }
}
