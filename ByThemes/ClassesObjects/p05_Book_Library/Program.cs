using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace p05_Book_Library
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
                var book = new Book();
                book.Title = arrayBook[0];
                book.Author = arrayBook[1];
                book.Publisher = arrayBook[2];
                book.ReleaseDate = arrayBook[3];
                book.ISBNNumber = arrayBook[4];
                book.Price = double.Parse(arrayBook[5]);
                library.Catalog.Add(book);
            }

            //var srtdCatalog = library.Catalog.GroupBy(x =>x.Author).Sum(x => x.Select()).OrderByDescending(_ => Sum(_.Price)).ThenByDescending(x => x.AverageGrade);
            var srtdCatalog = (from book in library.Catalog
                               group book by book.Author into groupResult
                               select new
                               {
                                   Author = groupResult.Key,
                                   Prices = groupResult.Sum(f => f.Price)
                               }
                               ).ToList().OrderByDescending(x =>x.Prices).ThenBy(x=>x.Author);
            foreach (var item in srtdCatalog)
            {
                Console.WriteLine($"{item.Author} -> {item.Prices,0:f2}");
            }
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDateInDateTime { get; set; }
        public string ReleaseDate { get { return ReleaseDateInDateTime.ToString("dd.MM.yyyy"); } set { ReleaseDateInDateTime = DateTime.ParseExact(value,"dd.MM.yyyy", CultureInfo.InvariantCulture); } }
        public string ISBNNumber { get; set; }
        public double Price { get; set; }
    }
    class Library
    {
        public string Name { get; set; }
        public List<Book> Catalog { get; set; }
    }
}
