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
        Horror,
        Detective,
        Drama
    }

    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public List<Genre> Genres { get; set; }
        public int PublishYear { get; set; }
        public int Pages { get; set; }
        public decimal Price { get; set; }

        public Book()
        {
            this.Id = Guid.NewGuid();
        }

        public Book(
            string title,
            string author,
            string imagePath,
            string ISBN,
            string description,
            List<Genre> genres,
            int publishYear,
            int pages,
            decimal price
        ) : this()
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = ISBN;
            this.ImagePath = imagePath;
            this.Description = description;

            this.Genres = new List<Genre>(genres);

            this.PublishYear = publishYear;
            this.Pages = pages;
            this.Price = price;
        }

        public List<string> ToList()
        {
            return [
                Title,
                Author,
                string.Join(" ", Genres),
                PublishYear.ToString(),
                ISBN,
                Pages.ToString(),
                ImagePath,
                Description,
                Price.ToString()
            ];
        }

        public override string ToString()
        {
            return string.Join("\n", this.ToList());
        }
    }
}
