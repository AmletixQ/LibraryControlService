using System;
using System.IO;
using System.Text.Json;

namespace LibraryControlService
{
    static class LibraryService
    {
        static private readonly List<Book> books = [];

        public static List<Book> GetBooks()
        {
            return new List<Book>(books);
        }

        public static void Initialize() => LoadFromFile();
        public static void Clear() => books.Clear();
        public static void AddBook(Book book) => books.Add(book);

        public static void RemoveBook(Guid bookId)
        {
            foreach (var book in books)
                if (book.Id == bookId)
                    books.Remove(book);
        }

        public static Book? GetBookById(Guid bookId)
        {
            foreach (var book in books)
                if (book.Id == bookId)
                    return book;

            return null;
        }

        public static void UpdateBook(Book updatedBook)
        {
            for (int i = 0; i < books.Count; ++i)
                if (books[i].Id == updatedBook.Id)
                    books[i] = updatedBook;
        }

        private static void LoadFromFile()
        {
            const string filepath = "assets/books.txt";

            using (StreamReader sr = new StreamReader(filepath))
            {
                string line;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine() ?? "";
                    if (line != "")
                    {
                        string[] splited = line.Split(" | ");
                        Book parsedBook = new Book()
                        {
                            Title = splited[0],
                            Author = splited[1],
                            Genre = splited[2],
                            PublishYear = Convert.ToInt32(splited[3]),
                            ISBN = splited[4],
                            Pages = Convert.ToInt32(splited[5]),
                            ImagePath = splited[6],
                            Description = splited[7],
                            Price = 1000,
                            Count = 100
                        };
                    }
                }
            }
        }
    }
}
