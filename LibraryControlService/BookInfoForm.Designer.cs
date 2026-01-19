namespace LibraryControlService
{
    partial class BookInfoForm
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
            BookNameLabel = new Label();
            BookAuthorLabel = new Label();
            BookDescriptionLabel = new Label();
            BuyButton = new Button();
            BasketButton = new Button();
            BookPriceLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            BookGenresLabel = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // BookNameLabel
            // 
            BookNameLabel.AutoSize = true;
            BookNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            BookNameLabel.Location = new Point(12, 9);
            BookNameLabel.MaximumSize = new Size(270, 0);
            BookNameLabel.Name = "BookNameLabel";
            BookNameLabel.Size = new Size(76, 30);
            BookNameLabel.TabIndex = 1;
            BookNameLabel.Text = "label1";
            // 
            // BookAuthorLabel
            // 
            BookAuthorLabel.AutoSize = true;
            BookAuthorLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BookAuthorLabel.Location = new Point(12, 83);
            BookAuthorLabel.Name = "BookAuthorLabel";
            BookAuthorLabel.Size = new Size(48, 20);
            BookAuthorLabel.TabIndex = 2;
            BookAuthorLabel.Text = "label1";
            // 
            // BookDescriptionLabel
            // 
            BookDescriptionLabel.AutoSize = true;
            BookDescriptionLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BookDescriptionLabel.Location = new Point(12, 237);
            BookDescriptionLabel.MaximumSize = new Size(390, 0);
            BookDescriptionLabel.Name = "BookDescriptionLabel";
            BookDescriptionLabel.Size = new Size(50, 20);
            BookDescriptionLabel.TabIndex = 3;
            BookDescriptionLabel.Text = "label1";
            // 
            // BuyButton
            // 
            BuyButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BuyButton.Location = new Point(12, 331);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(145, 38);
            BuyButton.TabIndex = 4;
            BuyButton.Text = "Купить";
            BuyButton.UseVisualStyleBackColor = true;
            BuyButton.Click += BuyButton_Click;
            // 
            // BasketButton
            // 
            BasketButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BasketButton.Location = new Point(228, 331);
            BasketButton.Name = "BasketButton";
            BasketButton.Size = new Size(156, 38);
            BasketButton.TabIndex = 5;
            BasketButton.Text = "В корзину";
            BasketButton.UseVisualStyleBackColor = true;
            BasketButton.Click += BasketButton_Click;
            // 
            // BookPriceLabel
            // 
            BookPriceLabel.AutoSize = true;
            BookPriceLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BookPriceLabel.Location = new Point(10, 132);
            BookPriceLabel.Name = "BookPriceLabel";
            BookPriceLabel.Size = new Size(65, 25);
            BookPriceLabel.TabIndex = 6;
            BookPriceLabel.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 117);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 7;
            label1.Text = "Цена:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 221);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 8;
            label2.Text = "Описание:";
            // 
            // BookGenresLabel
            // 
            BookGenresLabel.AutoSize = true;
            BookGenresLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BookGenresLabel.Location = new Point(8, 185);
            BookGenresLabel.Name = "BookGenresLabel";
            BookGenresLabel.Size = new Size(51, 21);
            BookGenresLabel.TabIndex = 6;
            BookGenresLabel.Text = "label1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 170);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 7;
            label4.Text = "Жанры:";
            // 
            // BookInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 379);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(BookGenresLabel);
            Controls.Add(BookPriceLabel);
            Controls.Add(BasketButton);
            Controls.Add(BuyButton);
            Controls.Add(BookDescriptionLabel);
            Controls.Add(BookAuthorLabel);
            Controls.Add(BookNameLabel);
            Name = "BookInfoForm";
            Text = "BookInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label BookNameLabel;
        private Label BookAuthorLabel;
        private Label BookDescriptionLabel;
        private Button BuyButton;
        private Button BasketButton;
        private Label BookPriceLabel;
        private Label label1;
        private Label label2;
		private Label BookGenresLabel;
		private Label label4;
	}
}