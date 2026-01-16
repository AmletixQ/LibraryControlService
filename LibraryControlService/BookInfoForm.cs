using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace LibraryControlService
{
    public partial class BookInfoForm : Form
    {
        private Book _book;
        public BookInfoForm(Book book)
        {
            InitializeComponent();
            this._book = book;

            BookNameLabel.Text = book.Title;
            BookAuthorLabel.Text = book.Author;
            BookPriceLabel.Text = book.Price.ToString();
            BookDescriptionLabel.Text = book.Description;
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Покупка добавлена на ожидание...");
        }

        private void BasketButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Книга добавлена корзину...");
        }
    }
}
