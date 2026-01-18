using System;
using System.Collections.Generic;

namespace LibraryControlService
{
    public partial class BookInfoForm : Form
    {
        private readonly Book _book;
        private readonly Action _action;

        public BookInfoForm(Book book, Action addToBasket)
        {
            InitializeComponent();
            this._book = book;
            this._action = addToBasket;

            BookNameLabel.Text = book.Title;
            BookAuthorLabel.Text = book.Author;
            BookPriceLabel.Text = $"{book.Price.ToString()} ₽";
            BookDescriptionLabel.Text = book.Description;

            try
            {
                BookCoverPictureBox.Image = Image.FromFile(book.ImagePath);
            } catch
            {
                BookCoverPictureBox.BackColor = Color.Gray;
            }
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
        }

        private void BasketButton_Click(object sender, EventArgs e)
        {
            this._action();
            MessageBox.Show("Книга добавлена корзину...");
        }
    }
}
