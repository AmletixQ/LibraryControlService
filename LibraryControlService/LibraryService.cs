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
            const string filepath = "files/mock.json";

            if (File.Exists(filepath))
            {
                var json = File.ReadAllText(filepath);
                // Исправлено: используем System.Text.Json для десериализации
                var loadedBooks = JsonSerializer.Deserialize<List<Book>>(json);
                if (loadedBooks != null)
                {
                    books.Clear();
                    books.AddRange(loadedBooks);
                }
            }
        }
    }
}
