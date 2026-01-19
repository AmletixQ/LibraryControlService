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

        public void UpdateBook(Book updatedBook)
        {
            for (int i = 0; i < books.Count; ++i)
                if (books[i].Id == updatedBook.Id)
                    books[i] = updatedBook;
        }

        public void SaveToFile(string filename = "books.txt")
        {
            string filepath = $"assets/{filename}";

            using (StreamWriter sw = new StreamWriter(filepath, false))
            {
                foreach (Book book in books)
                {
                    string[] parts = [
                        book.Title,
                        book.Author,
                        book.Genres.ToString()!,
                        book.PublishYear.ToString(),
                        book.ISBN,
                        book.Pages.ToString(),
                        book.ImagePath,
                        book.Description
                    ];

                    sw.WriteLine(string.Join(" | ", parts));
                }
            }
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
                            ImagePath = splited[6],
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
