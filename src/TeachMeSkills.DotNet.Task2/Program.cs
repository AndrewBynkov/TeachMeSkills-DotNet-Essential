using System;
using System.Collections.Generic;

namespace TeachMeSkills.DotNet.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            AddInfo();
        }

        public static void AddInfo()
        {
            var title = new Title();
            var author = new Author();
            var content = new Content();
            var myBook = new List<Book>();

            char key = default;
            while (key != 'n')
            {
                title.GetBookTitle();
                author.GetNameAuthor();
                content.GetBookContent();

                myBook.Add(new Book
                {
                    _bookContents = content.BookContent,
                    _authorName = author.NameAuthor,
                    _bookTitle = title.BookTitle
                });

                Console.Write("Countinue?:");
                key = char.Parse(Console.ReadLine());
            }

            foreach (var item in myBook)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Author name - {item._authorName}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Book title -{item._bookTitle}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Book content - {item._bookContents}");
                Console.ResetColor();
            }
        }
    }
}
