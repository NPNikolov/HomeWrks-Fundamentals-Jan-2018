using System;

namespace p02_Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrPhrases = {"Excellent product.", "Such a great product.",
                "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can’t live without this product."};
            string[] arrEvents = {"Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!"};
            string[] arrAuthors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] arrCities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rnd = new Random();

            int nmbrMssgs = int.Parse(Console.ReadLine());

            for (int i = 0; i<nmbrMssgs; i++)
			{
                string phrase = GetRandomWord(arrPhrases, rnd);
                string events = GetRandomWord(arrEvents, rnd);
                string author = GetRandomWord(arrAuthors, rnd);
                string city = GetRandomWord(arrCities, rnd);
                Console.WriteLine($"{phrase} {events} {author} – {city}");
            }

        }

        private static string GetRandomWord(string[] arrPhrases, Random rnd)
        {
            int sizeArr = arrPhrases.Length;
            int rndNmbr = rnd.Next(0, sizeArr - 1);
    return arrPhrases[rndNmbr];
        }
    }
}
