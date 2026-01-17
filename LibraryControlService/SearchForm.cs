using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibraryControlService
{
    public partial class SearchForm : Form
    {
        public string SelectAuthor { get; set; }
        public string SelectTitle { get; set; }
        public Genre? SelectGenre { get; set; }
        public int SelectYear { get; set; }
        public SearchForm()
        {
            InitializeComponent();
            InitializeGenres();
        }
        private void InitializeGenres()
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SelectAuthor = AuthorTextBox.Text;
            SelectTitle = NameTextBox.Text;
            if(int.TryParse(YearTextBox.Text, out int result))
                SelectYear = result;
            if(cmbGenre.SelectedIndex > 0)
                SelectGenre = (Genre)Enum.Parse(typeof(Genre), cmbGenre.SelectedItem?.ToString()!); ;
            this.Close();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            cmbGenre.Items.AddRange(new string[] {
                "",
                "Fiction",
                "NonFiction",
                "Science",
                "History",
                "Biography",
                "Fantasy",
                "Mystery",
                "Romance",
                "Thriller",
                "Horror",
                "Detective"
            });
            cmbGenre.SelectedIndex = 0;
        }
    }
}
