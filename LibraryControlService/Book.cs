using System;
using System.Collections.Generic;

namespace LibraryControlService
{
    public enum Genre
    {
        Fiction,
        NonFiction,
        Science,
        History,
        Biography,
        Fantasy,
        Mystery,
        Romance,
        Thriller,
        Horror
    }

    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublishYear { get; set; }
        public string ISBN { get; set; }
        public Genre Genre { get; set; }
        public int Pages { get; set; }
        public bool IsAvailable { get; set; }

        public Book(
            string title,
            string author,
            int publishYear,
            string ISBN,
            Genre genre,
            int pages,
            bool isAvailable
        )
        {
            this.Id = Guid.NewGuid();
            this.Title = title;
            this.Author = author;
            this.PublishYear = publishYear;
            this.ISBN = ISBN;
            this.Genre = genre;
            this.Pages = pages;
            this.IsAvailable = isAvailable;
        }

        public List<string> ToList()
        {
            return [
                Id.ToString(),
                Title,
                Author,
                PublishYear.ToString(),
                ISBN,
                Genre.ToString(),
                Pages.ToString(),
                IsAvailable.ToString()
            ];
        }

        public override string ToString()
        {
            string[] lines = [
                $"${Title} by {Author}",
                $"Published: {PublishYear}",
                $"ISBN: {ISBN}",
                $"Genre: {Genre}",
                $"Pages: {Pages}",
                $"Available: {IsAvailable}"
            ];

            return string.Join("\n", lines);
        }
    }
}
