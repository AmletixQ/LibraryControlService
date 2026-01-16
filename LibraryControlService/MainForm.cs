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

            globalLibrary.Initialize();

            ShowBooks(globalLibrary.GetBooks());
        }

        private void AddBookCard(Book book)
        {
            Panel card = new Panel()
            {
                Width = 200,
                Height = 260,
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
                Text = book.Title,
                Location = new Point(10, 135),
                Width = 180,
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoSize = false
            };

            Label lblAuthor = new Label()
            {
                Text = "Автор: " + book.Author,
                Location = new Point(10, 160),
                Width = 180,
                Font = new Font("Arial", 9),
                AutoSize = false
            };

            Label lblPrice = new Label()
            {
                Text = book.Price.ToString(),
                Location = new Point(10, 195),
                Width = 180,
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.Red,
                AutoSize = false
            };


            Button btnBuy = new Button()
            {
                Text = "Купить",
                Size = new Size(85, 30),
                Location = new Point(10, 220),
            };
            btnBuy.Click += (sender, e) =>
            {
                MessageBox.Show($"Вы купили книгу: {book.Title}");
            };

            Button btnCart = new Button()
            {
                Text = "В корзину",
                Size = new Size(85, 30),
                Location = new Point(105, 220)
            };
            btnCart.Click += (sender, e) =>
            {
                MessageBox.Show($"Добавлено в корзину: {book.Title}");
            };

            card.Controls.Add(pictureBox);
            card.Controls.Add(lblTitle);
            card.Controls.Add(lblAuthor);
            card.Controls.Add(lblPrice);
            card.Controls.Add(btnBuy);
            card.Controls.Add(btnCart);

            BooksPanel.Controls.Add(card);
        }

        private void ShowBooks(List<Book> books)
        {
            foreach (var book in books)
            {
                AddBookCard(book);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }
    }
}
