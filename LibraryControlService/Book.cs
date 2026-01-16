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
        public string ISBN { get; set; }
        public string ImagePath { get; set; }
        public Genre Genre { get; set; }
        public int PublishYear { get; set; }
        public int Pages { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }

        public Book(
            string title,
            string author,
            string imagePath,
            string ISBN,
            Genre genre,
            int publishYear,
            int pages,
            int count,
            int price

        )
        {
            this.Id = Guid.NewGuid();

            this.Title = title;
            this.Author = author;
            this.ISBN = ISBN;
            this.ImagePath = imagePath;

            this.Genre = genre;

            this.PublishYear = publishYear;
            this.Pages = pages;
            this.Count = count;
            this.Price = price;
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
                Count.ToString()
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
                $"Available: {Count}"
            ];

            return string.Join("\n", lines);
        }
    }
}
