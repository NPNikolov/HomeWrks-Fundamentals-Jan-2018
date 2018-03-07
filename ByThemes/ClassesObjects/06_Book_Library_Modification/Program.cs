using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace p06_Book_Library_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbrBooks = int.Parse(Console.ReadLine());
            var library = new Library() { Name = "My Library", Catalog = new List<Book>() };
            for (int i = 0; i < numbrBooks; i++)
            {
                string[] arrayBook = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var book = new Book()
                {
                    Title = arrayBook[0],
                    Author = arrayBook[1],
                    Publisher = arrayBook[2],
                    ReleaseDate = arrayBook[3],
                    ISBNNumber = arrayBook[4],
                    Price = double.Parse(arrayBook[5])
                };
                library.Catalog.Add(book);
            }
            string dateAfter = Console.ReadLine();
            DateTime releaseDateAfter = DateTime.ParseExact(dateAfter, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var srtCatalog = library.Catalog.Where(x =>x.ReleaseDateInDateTime>releaseDateAfter).OrderBy(x => x.ReleaseDateInDateTime).ThenBy(x => x.Title);

            foreach (var item in srtCatalog)
            {
                Console.WriteLine($"{item.Title} -> {item.ReleaseDate}");
            }

        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDateInDateTime { get; set; }
        public string ReleaseDate { get { return ReleaseDateInDateTime.ToString("dd.MM.yyyy"); } set { ReleaseDateInDateTime = DateTime.ParseExact(value, "dd.MM.yyyy", CultureInfo.InvariantCulture); } }
        public string ISBNNumber { get; set; }
        public double Price { get; set; }
    }
    class Library
    {
        public string Name { get; set; }
        public List<Book> Catalog { get; set; }
    }
}
