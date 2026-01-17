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
                Text = book.Price.ToString(),
                Location = new Point(10, 215),
                Width = 180,
                //Height = 20,
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.Red,
                AutoSize = false
            };


            Button btnBuy = new Button()
            {
                Text = "Подробнее",
                Size = new Size(180, 30),
                Location = new Point(10, 240),
            };
            btnBuy.Click += (sender, e) =>
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
            card.Controls.Add(btnBuy);

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
