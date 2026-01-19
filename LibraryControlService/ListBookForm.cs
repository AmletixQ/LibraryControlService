using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryControlService
{
	public partial class ListBookForm : Form
	{
		private readonly LibraryService _basketLibrary;
		public ListBookForm(LibraryService basketLibrary)
		{
			this._basketLibrary = basketLibrary;

			InitializeComponent();
			ShowBooks(basketLibrary.GetBooks());
		}

		private void AddBookCard(Book book)
		{
			Panel card = new Panel()
			{
				Width = 590,
				Height = 100,
				BorderStyle = BorderStyle.FixedSingle,
				Margin = new Padding(5)
			};

			PictureBox pictureBox = new PictureBox()
			{
				Size = new Size(120, 80),
				Location = new Point(10, 10),
				SizeMode = PictureBoxSizeMode.Zoom,
				BorderStyle = BorderStyle.FixedSingle,
			};
			try
			{
				pictureBox.Image = Image.FromFile(book.ImagePath);
			}
			catch
			{
				pictureBox.BackColor = Color.Gray;
			}

			Label lblTitle = new Label()
			{
				Width = 350,
				Height = 30,
				Text = book.Title,
				Font = new Font("Segoe UI", 10, FontStyle.Bold),
				Location = new Point(150, 5),
				TextAlign = ContentAlignment.MiddleLeft,
				AutoSize = false
			};

			Label lblAuthor = new Label()
			{
				Text = "Автор: " + book.Author,
				Location = new Point(152, 37),
				Width = 180,
				Height = 20,
				Font = new Font("Arial", 9),
				AutoSize = false
			};

			Label lblPrice = new Label()
			{
				Text = $"{book.Price.ToString()} ₽",
				Width = 150,
				Height = 25,
				Font = new Font("Segoe UI", 12, FontStyle.Bold),
				ForeColor = Color.DarkGreen,
				Location = new Point(150, 65),
				AutoSize = false,
				TextAlign = ContentAlignment.MiddleLeft
			};

			Button btnDelete = new Button()
			{
				Text = "✕",
				Size = new Size(30, 30),
				Location = new Point(550, 37),
			};
			btnDelete.FlatAppearance.BorderSize = 1;
			btnDelete.FlatAppearance.BorderColor = Color.Red;
			btnDelete.Click += (sender, e) =>
			{
				var result = MessageBox.Show(
					"Удалить книгу из корзины?",
					"Подтверждение",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question
				);

				if (result == DialogResult.Yes)
				{
					_basketLibrary.RemoveBook(book.Id);
					ShowBooks(_basketLibrary.GetBooks());
				}
			};

			card.Controls.Add(pictureBox);
			card.Controls.Add(lblTitle);
			card.Controls.Add(lblPrice);
			card.Controls.Add(lblAuthor);
			card.Controls.Add(btnDelete);

			BasketPanel.Controls.Add(card);
		}
		private void ShowBooks(List<Book> books)
		{
			BasketPanel.Controls.Clear();
			foreach (var book in books)
			{
				AddBookCard(book);
			}
			PriceLabel.Text = $"{_basketLibrary.GetBooks().Select(book => book.Price).Sum().ToString()} ₽";
			BuyButton.Enabled = books.Count > 0;
		}

		private void BuyButton_Click(object sender, EventArgs e)
		{
			OrderForm orderForm = new OrderForm();
			orderForm.ShowDialog();

			if (orderForm.DialogResult == DialogResult.OK)
			{
				_basketLibrary.Clear();
				ShowBooks(_basketLibrary.GetBooks());
			}


		}
	}
}
