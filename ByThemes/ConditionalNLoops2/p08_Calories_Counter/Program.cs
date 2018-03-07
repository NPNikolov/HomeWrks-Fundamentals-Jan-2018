using System;

namespace p08_Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLines = int.Parse(Console.ReadLine());
            string ingrdnt = "";
            int numCalories = 0;
            for (int i = 0; i < numLines; i++)
            {
                ingrdnt = Console.ReadLine().ToLower();
                switch (ingrdnt)
                {
                    case "cheese": numCalories += 500;
                        break;
                    case "tomato sauce":
                        numCalories += 150;
                        break;
                    case "salami":
                        numCalories += 600;
                        break;
                    case "pepper":
                        numCalories += 50;
                        break;

                }
            }
            Console.WriteLine($"Total calories: {numCalories}");
        }
    }
}
