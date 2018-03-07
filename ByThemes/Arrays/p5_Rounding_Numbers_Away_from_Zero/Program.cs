using System;

namespace p5_Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,5,10 };
            int[] nums = numbers;
            numbers[1] += 14;
            Console.WriteLine(nums[1]);
        }
    }
}
