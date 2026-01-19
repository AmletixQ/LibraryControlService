using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace LibraryControlService
{
	public partial class MainForm : Form
	{
		LibraryService globalLibrary;
		LibraryService basketLibrary;

		public MainForm()
		{
			InitializeComponent();
			globalLibrary = new LibraryService();
			basketLibrary = new LibraryService();

			globalLibrary.LoadFromFile();
			ShowBooks(globalLibrary.GetBooks());
		}

		private void AddBookCard(Book book)
		{
			Panel card = new Panel()
			{
				Width = 200,
				Height = 280,
				BorderStyle = BorderStyle.FixedSingle,
				Margin = new Padding(5)
			};

			PictureBox pictureBox = new PictureBox()
			{
				Size = new Size(180, 120),
				Location = new Point(10, 10),
				SizeMode = PictureBoxSizeMode.Zoom
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
				Width = 180,
				Height = 35,
				Text = book.Title,
				Location = new Point(10, 135),
				Font = new Font("Arial", 10, FontStyle.Bold),
				AutoSize = false
			};

			Label lblAuthor = new Label()
			{
				Text = "Автор: " + book.Author,
				Location = new Point(10, 190),
				Width = 180,
				Height = 20,
				Font = new Font("Arial", 9),
				AutoSize = false
			};

			Label lblPrice = new Label()
			{
				Text = $"{book.Price.ToString()} р.",
				Location = new Point(10, 215),
				Width = 180,
				Font = new Font("Arial", 12, FontStyle.Bold),
				ForeColor = Color.Red,
				AutoSize = false
			};


			Button btnAbout = new Button()
			{
				Text = "Подробнее",
				Size = new Size(180, 30),
				Location = new Point(10, 240),
			};
			btnAbout.Click += (sender, e) =>
			{
				BookInfoForm bookInfoForm = new(book, () =>
				{
					basketLibrary.AddBook(book);
				});
				bookInfoForm.ShowDialog();
			};

			card.Controls.Add(pictureBox);
			card.Controls.Add(lblTitle);
			card.Controls.Add(lblPrice);
			card.Controls.Add(lblAuthor);
			card.Controls.Add(btnAbout);

			BooksPanel.Controls.Add(card);
		}

		private void ShowBooks(List<Book> books)
		{
			BooksPanel.Controls.Clear();
			foreach (var book in books)
			{
				AddBookCard(book);
			}
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			SearchForm searchForm = new SearchForm();
			searchForm.ShowDialog();

			if (string.IsNullOrEmpty(searchForm.SelectTitle) &&
				string.IsNullOrEmpty(searchForm.SelectAuthor) &&
				searchForm.SelectGenre == null &&
				searchForm.SelectYear == 0)
				return;
			ClearFilterButton.Visible = true;

			var filteredBooks = globalLibrary.GetBooks();
			if (!string.IsNullOrEmpty(searchForm.SelectTitle))
			{
				filteredBooks = filteredBooks.Where((book) => book.Title.ToLower().Contains(searchForm.SelectTitle.ToLower())).ToList();
			}
			if (!string.IsNullOrEmpty(searchForm.SelectAuthor))
			{
				filteredBooks = filteredBooks.Where((book) => book.Author.ToLower().Contains(searchForm.SelectAuthor.ToLower())).ToList();
			}
			if (searchForm.SelectYear != 0)
			{
				filteredBooks = filteredBooks.Where((book) => book.PublishYear == searchForm.SelectYear).ToList();
			}
			if (searchForm.SelectGenre != null)
			{ filteredBooks = filteredBooks.Where((book) => book.Genres.Contains((Genre)searchForm.SelectGenre)).ToList(); }

			ShowBooks(filteredBooks);
		}

		private void ClearFilterButton_Click(object sender, EventArgs e)
		{
			ClearFilterButton.Visible = false;
			ShowBooks(globalLibrary.GetBooks());
		}

		private void basket_Click(object sender, EventArgs e)
		{
			ListBookForm ListForm = new ListBookForm(basketLibrary);
			ListForm.ShowDialog();
		}

		private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
		{
			var sortedBooks = globalLibrary.GetBooks();
			switch(cmbSort.SelectedIndex){
				case 1:
					sortedBooks = sortedBooks.OrderBy(book => book.Price).ToList();
					break;
				case 2:
					sortedBooks = sortedBooks.OrderByDescending(book => book.Price).ToList();
					break;
				case 3:
					sortedBooks = sortedBooks.OrderBy(book => book.Author).ToList();
					break;
				case 4:
					sortedBooks = sortedBooks.OrderBy(book => book.Title).ToList();
					break;

			}
			ShowBooks(sortedBooks);
		}
	}
}
