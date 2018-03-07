using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace p01_Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateAsText = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateAsText, "dd-MM-yyyy",CultureInfo.InvariantCulture);
            string dateAsTextLast = Console.ReadLine();
            DateTime dateLast = DateTime.ParseExact(dateAsTextLast, "dd-MM-yyyy",CultureInfo.InvariantCulture);
            dateLast = dateLast.AddDays(1);
            Dictionary<string, byte[]> mapHollyDays = BGDate.GetHollyDays();
            int cntr = 0;
            do
            {
                byte day = (byte)date.Day;
                byte month = (byte)date.Month;
                var hollyDay = BGDate.IsHollyDay(day, month, mapHollyDays);
                if (! hollyDay.ElementAt(0).Key)
                {
                    if (date.DayOfWeek.Equals(DayOfWeek.Saturday)|| date.DayOfWeek.Equals(DayOfWeek.Sunday))
                    {

                    }else
                    cntr++;
                }
                date = date.AddDays(1);
            } while (!date.Equals(dateLast));

            Console.WriteLine(cntr);
        }
    }
    class BGDate
    {
        public DateTime DateDay { get; set; }
        public Dictionary<string, byte[]> HollyDays { get; set; }

        public static Dictionary<bool, string> IsHollyDay(byte day, byte month, Dictionary<string, byte[]> mapHollyDays)
        {
            
            bool found = false;
            string name = "";
            foreach (var item in mapHollyDays)
            {
                if (found) break;
                
                string hollyDay = item.Key;
                byte[] arrayDates = item.Value;
                for (int i = 0; i < arrayDates.Length; i+=2)
                {
                    if (arrayDates[i+1]==month)
                    {
                        if (arrayDates[i]==day)
                        {
                            found = true;
                            name = hollyDay;
                            break;
                        }
                    }
                }
            }
            Dictionary<bool, string> mapResult = new Dictionary<bool, string>();
            mapResult[found] = name;
            
            return mapResult;
        }
        public static Dictionary<string, byte[]> GetHollyDays()
        {
            Dictionary<string, byte[]> mapHollyDays = new Dictionary<string, byte[]>();
            mapHollyDays.Add("New Year Eve", new byte[] { 1, 1 });
            mapHollyDays.Add("Liberation Day", new byte[] { 3, 3 });
            mapHollyDays.Add("Worker’s day", new byte[] { 1, 5 });
            mapHollyDays.Add("Saint George’s Day", new byte[] { 6, 5 });
            mapHollyDays.Add("Saints Cyril and Methodius Day", new byte[] { 24, 5 });
            mapHollyDays.Add("Unification Day", new byte[] { 6, 9 });
            mapHollyDays.Add("Independence Day", new byte[] { 22, 9 });
            mapHollyDays.Add("National Awakening Day", new byte[] { 1, 11 });
            mapHollyDays.Add("Christmas", new byte[] { 24, 12, 25, 12, 26, 12 });
            return mapHollyDays;
        }
    }
}