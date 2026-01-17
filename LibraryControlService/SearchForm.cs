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
    public partial class SearchForm : Form
    {
        public string SelectAuthor { get; set; }
        public string SelectTitle { get; set; }
        public string SelectGenre { get; set; }
        public string SelectYear { get; set; }
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
            SelectYear = YearTextBox.Text;
            SelectGenre = cmbGenre.SelectedItem?.ToString() ?? "";
            this.Close();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            cmbGenre.Items.AddRange(new object[] {
                "",
                "Роман",
                "Фантастика",
                "Детектив",
                "Фэнтези",
                "Научная литература",
                "Биография",
                "Поэзия"
            });
            cmbGenre.SelectedIndex = 0;
        }
    }
}
