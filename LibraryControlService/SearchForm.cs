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
        public string SelectAuthor {  get; set; }
        public string SelectTitle { get; set; }
        public string SelectGenre {  get; set; }
        public string SelectYear {  get; set; }
        public SearchForm()
        {
            InitializeComponent();
            InitializeGenres();
        }
        private void InitializeGenres()
        {
            // Заполняем ListView жанрами
            listViewGenres.View = View.List;
            listViewGenres.CheckBoxes = true;

            string[] genres = {
                "Фантастика", "Детектив", "Роман", "Поэзия",
                "Приключения", "Фэнтези", "Научная литература",
                "Историческая", "Биография", "Ужасы", "Драма"
            };
            foreach (var genre in genres)
            {
                listViewGenres.Items.Add(genre);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SelectAuthor= AuthorTextBox.Text;
            SelectTitle= NameTextBox.Text;
            SelectYear= YearTextBox.Text;
            ListView listView= new ListView();
            var l = listView.SelectedItems[0];
            

            /*// Собираем данные для фильтрации
            var filterData = new FilterData
            {
                Author = AuthorTextBox.Text.Trim(),
                Title = NamуTextBox.Text.Trim(),
                Year = YearTextBox.Text.Trim(),
                
            };*/

            /*// Получаем выбранные жанры
            */

            /*// Создаем и показываем форму с результатами
            var resultsForm = new ResultsForm(filterData);
            resultsForm.Show();*/
        }

        private void listViewGenres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
