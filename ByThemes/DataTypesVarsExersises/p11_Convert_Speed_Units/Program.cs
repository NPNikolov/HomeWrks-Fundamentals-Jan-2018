using System;

namespace p11_Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float one_mile = 1609;
            float time_in_seconds = (float)(hours * 3600.0 + minutes * 60.0 + seconds);
            //float time_in_hours = time_in_seconds / 3600;

            float speed_m_p_s = (float)(distance * 1.0 / time_in_seconds);
            float speed_km_p_h = (float)(speed_m_p_s * 3600/1000.0);
            float speed_miles_p_h = speed_m_p_s *3600/one_mile;

            Console.WriteLine($"{speed_m_p_s}");
            Console.WriteLine($"{speed_km_p_h}");
            Console.WriteLine($"{speed_miles_p_h}");
        }
    }
}
