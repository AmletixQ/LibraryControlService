using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryControlService
{
    public partial class ListBookForm : Form
    {
        public ListBookForm(LibraryService basketLibrary)
        {
            InitializeComponent();
            ShowBooks(basketLibrary.GetBooks());
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

            card.Controls.Add(pictureBox);
            card.Controls.Add(lblTitle);
            card.Controls.Add(lblPrice);
            card.Controls.Add(lblAuthor);

            BasketPanel.Controls.Add(card);
        }
        private void ShowBooks(List<Book> books)
        {
            BasketPanel.Controls.Clear();
            foreach (var book in books)
            {
                AddBookCard(book);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
