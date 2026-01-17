namespace LibraryControlService
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SearchButton = new Button();
            AuthorTextBox = new TextBox();
            NameTextBox = new TextBox();
            YearTextBox = new TextBox();
            cmbGenre = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 39);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 0;
            label1.Text = "Фильтрация";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 98);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Автор :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 142);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "Название :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 185);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Жанр :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 227);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 4;
            label5.Text = "Год выпуска :";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(91, 287);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 5;
            SearchButton.Text = "поиск";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(131, 95);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(122, 23);
            AuthorTextBox.TabIndex = 6;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(131, 139);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(122, 23);
            NameTextBox.TabIndex = 7;
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(131, 224);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(122, 23);
            YearTextBox.TabIndex = 9;
            // 
            // cmbGenre
            // 
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Location = new Point(132, 182);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(121, 23);
            cmbGenre.TabIndex = 10;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 334);
            Controls.Add(cmbGenre);
            Controls.Add(YearTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(AuthorTextBox);
            Controls.Add(SearchButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SearchForm";
            Text = "SearchForm";
            Load += SearchForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button SearchButton;
        private TextBox AuthorTextBox;
        private TextBox NameTextBox;
        private TextBox YearTextBox;
        private ComboBox cmbGenre;
    }
}