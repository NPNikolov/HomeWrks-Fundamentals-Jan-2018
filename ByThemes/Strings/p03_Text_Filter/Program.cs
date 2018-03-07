using System;
using System.Linq;

namespace p03_Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string strToFilter = Console.ReadLine();
            
            for (int i = 0; i < strArr.Length; i++)
            {
                string strToReplace = strArr[i];
                int lngth = strToReplace.Length;
                string rplsmnt = new string('*', lngth);
                strToFilter = strToFilter.Replace(strToReplace, rplsmnt);
            }
            Console.WriteLine(strToFilter);

        }
    }
}
