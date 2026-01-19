using System;
using System.IO;

namespace LibraryControlService
{
    public class LibraryService
    {
        private readonly List<Book> books = [];

        public List<Book> GetBooks()
        {
            return new List<Book>(books);
        }

        public void Clear() => books.Clear();
        public void AddBook(Book book)
        {
            if (books.Find((b) => b.Id == book.Id) != null)
                return;

            books.Add(book);
        }

        public void RemoveBook(Guid bookId)
        {
            int idx = books.FindIndex(b => b.Id == bookId);
            if (idx != -1)
                books.RemoveAt(idx);
        }


        public Book? GetBookById(Guid bookId)
        {
            return books.Find(b => b.Id == bookId);
        }

        public void LoadFromFile(string filename = "books.txt")
        {
            string filepath = $"assets/{filename}";

            using (StreamReader sr = new StreamReader(filepath))
            {
                string line;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine() ?? "";
                    if (line != "")
                    {
                        string[] splited = line.Split(" | ");
                        Book parsedBook = new()
                        {
                            Title = splited[0],
                            Author = splited[1],
                            Genres = splited[2].Split().Select(genre => (Genre)Enum.Parse(typeof(Genre), genre)).ToList(),
                            PublishYear = Convert.ToInt32(splited[3]),
                            ISBN = splited[4],
                            Pages = Convert.ToInt32(splited[5]),
                            ImagePath = $"assets/images/{splited[6]}",
                            Description = splited[7],
                            Price = Convert.ToDecimal(splited[8]),
                        };

                        books.Add(parsedBook);
                    }
                }
            }
        }

    }
}
