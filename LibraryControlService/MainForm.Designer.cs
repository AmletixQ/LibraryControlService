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
            SignButton = new Button();
            basket = new Button();
            SearchButton = new Button();
            BooksPanel = new FlowLayoutPanel();
            ClearFilterButton = new Button();
            SuspendLayout();
            // 
            // SignButton
            // 
            SignButton.Location = new Point(12, 12);
            SignButton.Name = "SignButton";
            SignButton.Size = new Size(75, 23);
            SignButton.TabIndex = 0;
            SignButton.Text = "Войти";
            SignButton.UseVisualStyleBackColor = true;
            // 
            // basket
            // 
            basket.Location = new Point(768, 12);
            basket.Name = "basket";
            basket.Size = new Size(86, 23);
            basket.TabIndex = 1;
            basket.Text = "Корзина";
            basket.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(687, 12);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Поиск";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
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
            // ClearFilterButton
            // 
            ClearFilterButton.Location = new Point(554, 12);
            ClearFilterButton.Name = "ClearFilterButton";
            ClearFilterButton.Size = new Size(127, 23);
            ClearFilterButton.TabIndex = 4;
            ClearFilterButton.Text = "Очистить фильтры";
            ClearFilterButton.UseVisualStyleBackColor = true;
            ClearFilterButton.Visible = false;
            ClearFilterButton.Click += ClearFilterButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 546);
            Controls.Add(ClearFilterButton);
            Controls.Add(BooksPanel);
            Controls.Add(SearchButton);
            Controls.Add(basket);
            Controls.Add(SignButton);
            Name = "MainForm";
            Text = "Главная";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button SignButton;
        private Button basket;
        private Button SearchButton;
        private FlowLayoutPanel BooksPanel;
        private Button ClearFilterButton;
    }
}
