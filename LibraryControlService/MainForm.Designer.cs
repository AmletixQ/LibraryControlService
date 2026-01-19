namespace LibraryControlService
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			basket = new Button();
			SearchButton = new Button();
			ClearFilterButton = new Button();
			BooksPanel = new FlowLayoutPanel();
			label1 = new Label();
			cmbSort = new ComboBox();
			SuspendLayout();
			// 
			// basket
			// 
			basket.Location = new Point(785, 35);
			basket.Name = "basket";
			basket.Size = new Size(69, 27);
			basket.TabIndex = 1;
			basket.Text = "Корзина";
			basket.UseVisualStyleBackColor = true;
			basket.Click += basket_Click;
			// 
			// SearchButton
			// 
			SearchButton.Location = new Point(704, 35);
			SearchButton.Name = "SearchButton";
			SearchButton.Size = new Size(75, 27);
			SearchButton.TabIndex = 2;
			SearchButton.Text = "Поиск";
			SearchButton.UseVisualStyleBackColor = true;
			SearchButton.Click += SearchButton_Click;
			// 
			// ClearFilterButton
			// 
			ClearFilterButton.Location = new Point(574, 35);
			ClearFilterButton.Name = "ClearFilterButton";
			ClearFilterButton.Size = new Size(124, 27);
			ClearFilterButton.TabIndex = 4;
			ClearFilterButton.Text = "Очистить фильтры";
			ClearFilterButton.UseVisualStyleBackColor = true;
			ClearFilterButton.Visible = false;
			ClearFilterButton.Click += ClearFilterButton_Click;
			// 
			// BooksPanel
			// 
			BooksPanel.AutoScroll = true;
			BooksPanel.Dock = DockStyle.Bottom;
			BooksPanel.Location = new Point(0, 81);
			BooksPanel.Name = "BooksPanel";
			BooksPanel.Size = new Size(866, 465);
			BooksPanel.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("SimSun", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
			label1.Location = new Point(297, 9);
			label1.Name = "label1";
			label1.Size = new Size(251, 64);
			label1.TabIndex = 5;
			label1.Text = "Library";
			// 
			// cmbSort
			// 
			cmbSort.FormattingEnabled = true;
			cmbSort.Items.AddRange(new object[] { "По умоляю", "Дешевле ", "Дороже", "Авторы по алфавиту", "Названия по алфавиту" });
			cmbSort.Location = new Point(24, 35);
			cmbSort.Name = "cmbSort";
			cmbSort.Size = new Size(187, 23);
			cmbSort.TabIndex = 6;
			cmbSort.Text = "Сортировка";
			cmbSort.SelectedIndexChanged += cmbSort_SelectedIndexChanged;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(866, 546);
			Controls.Add(cmbSort);
			Controls.Add(label1);
			Controls.Add(ClearFilterButton);
			Controls.Add(BooksPanel);
			Controls.Add(SearchButton);
			Controls.Add(basket);
			Name = "MainForm";
			Text = "Главная";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button basket;
        private Button SearchButton;
        private Button ClearFilterButton;
        private FlowLayoutPanel BooksPanel;
        private Label label1;
		private ComboBox cmbSort;
	}
}
