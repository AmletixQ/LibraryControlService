using System.Windows.Forms;

namespace LibraryControlService
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Настройка FlowLayoutPanel
            BooksPanel.WrapContents = true;
            BooksPanel.AutoScroll = true;

            // Добавим несколько карточек книг
            AddBookCard("Книга 1", "Автор 1", "path_to_image1.jpg", "Цена1");
            AddBookCard("Книга 2", "Автор 2", "path_to_image2.jpg", "Цена2");
            AddBookCard("Книга 3", "Автор 3", "path_to_image3.jpg", "Цена3");
            AddBookCard("Книга 4", "Автор 4", "равыоап", "Цена4");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void AddBookCard(string title, string author, string imagePath, string price)
        {
            // Создаем панель для карточки
            Panel card = new Panel();
            card.Width = 200;
            card.Height = 270;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Margin = new Padding(10);

            // Создаем PictureBox для изображения
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(180, 120);
            pictureBox.Location = new Point(10, 10);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            try
            {
                pictureBox.Image = Image.FromFile(imagePath);
            }
            catch
            {
                // На случай отсутствия изображения или ошибки
                pictureBox.BackColor = Color.Gray;
            }

            // Создаем Label для названия
            Label lblTitle = new Label();
            lblTitle.Text = title;
            lblTitle.Location = new Point(10, 135);
            lblTitle.Width = 180;
            lblTitle.Font = new Font("Arial", 10, FontStyle.Bold);
            lblTitle.AutoSize = false;

            // Создаем Label для автора
            Label lblAuthor = new Label();
            lblAuthor.Text = "Автор: " + author;
            lblAuthor.Location = new Point(10, 160);
            lblAuthor.Width = 180;
            lblAuthor.Font = new Font("Arial", 9);
            lblAuthor.AutoSize = false;

            Label lblPrice = new Label();
            lblPrice.Text = price;
            lblPrice.Location = new Point(10, 195);
            lblPrice.Width = 180;
            lblPrice.Font = new Font("Arial", 10, FontStyle.Bold);
            lblPrice.ForeColor = Color.Red;
            lblPrice.AutoSize = false;

            // Создаем кнопку "Купить"
            Button btnBuy = new Button();
            btnBuy.Text = "Купить";
            btnBuy.Size = new Size(85, 30);
            btnBuy.Location = new Point(10, 220);
            btnBuy.Click += (sender, e) =>
            {
                MessageBox.Show($"Вы купили книгу: {title}");
            };

            // Создаем кнопку "В корзину"
            Button btnCart = new Button();
            btnCart.Text = "В корзину";
            btnCart.Size = new Size(85, 30);
            btnCart.Location = new Point(105, 220);
            btnCart.Click += (sender, e) =>
            {
                MessageBox.Show($"Добавлено в корзину: {title}");
            };

            // Добавляем все элементы на панель
            card.Controls.Add(pictureBox);
            card.Controls.Add(lblTitle);
            card.Controls.Add(lblAuthor);
            card.Controls.Add(lblPrice);
            card.Controls.Add(btnBuy);
            card.Controls.Add(btnCart);

            // Добавляем карточку в FlowLayoutPanel
            BooksPanel.Controls.Add(card);
        }
    }
}
