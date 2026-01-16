using System;
using System.IO;
using System.Text.Json;

namespace LibraryControlService
{
    class LibraryService
    {
        private readonly List<Book> books = [];

        public List<Book> GetBooks()
        {
            return new List<Book>(books);
        }

        public void Initialize() => LoadFromFile();
        public void Clear() => books.Clear();
        public void AddBook(Book book) => books.Add(book);

        public void RemoveBook(Guid bookId)
        {
            foreach (var book in books)
                if (book.Id == bookId)
                    books.Remove(book);
        }

        public Book? GetBookById(Guid bookId)
        {
            foreach (var book in books)
                if (book.Id == bookId)
                    return book;

            return null;
        }

        public void UpdateBook(Book updatedBook)
        {
            for (int i = 0; i < books.Count; ++i)
                if (books[i].Id == updatedBook.Id)
                    books[i] = updatedBook;
        }

        private void LoadFromFile()
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
                        Book parsedBook = new()
                        {
                            Title = splited[0],
                            Author = splited[1],
                            Genre = (Genre)Enum.Parse(typeof(Genre), splited[2]),
                            PublishYear = Convert.ToInt32(splited[3]),
                            ISBN = splited[4],
                            Pages = Convert.ToInt32(splited[5]),
                            ImagePath = splited[6],
                            Description = splited[7],
                            Price = 1000,
                            Count = 100
                        };

                        books.Add(parsedBook);
                    }
                }
            }
        }
    }
}
