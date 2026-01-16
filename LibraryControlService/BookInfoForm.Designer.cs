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
            BookCoverPictureBox = new PictureBox();
            BookNameLabel = new Label();
            BookAuthorLabel = new Label();
            BookDescriptionLabel = new Label();
            BuyButton = new Button();
            BasketButton = new Button();
            BookPriceLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)BookCoverPictureBox).BeginInit();
            SuspendLayout();
            // 
            // BookCoverPictureBox
            // 
            BookCoverPictureBox.Location = new Point(12, 12);
            BookCoverPictureBox.Name = "BookCoverPictureBox";
            BookCoverPictureBox.Size = new Size(120, 120);
            BookCoverPictureBox.TabIndex = 0;
            BookCoverPictureBox.TabStop = false;
            // 
            // BookNameLabel
            // 
            BookNameLabel.AutoSize = true;
            BookNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            BookNameLabel.Location = new Point(138, 12);
            BookNameLabel.Name = "BookNameLabel";
            BookNameLabel.Size = new Size(76, 30);
            BookNameLabel.TabIndex = 1;
            BookNameLabel.Text = "label1";
            // 
            // BookAuthorLabel
            // 
            BookAuthorLabel.AutoSize = true;
            BookAuthorLabel.Location = new Point(138, 66);
            BookAuthorLabel.Name = "BookAuthorLabel";
            BookAuthorLabel.Size = new Size(38, 15);
            BookAuthorLabel.TabIndex = 2;
            BookAuthorLabel.Text = "label1";
            // 
            // BookDescriptionLabel
            // 
            BookDescriptionLabel.AutoSize = true;
            BookDescriptionLabel.Location = new Point(12, 260);
            BookDescriptionLabel.Name = "BookDescriptionLabel";
            BookDescriptionLabel.Size = new Size(38, 15);
            BookDescriptionLabel.TabIndex = 3;
            BookDescriptionLabel.Text = "label1";
            // 
            // BuyButton
            // 
            BuyButton.Location = new Point(55, 358);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(138, 38);
            BuyButton.TabIndex = 4;
            BuyButton.Text = "Купить";
            BuyButton.UseVisualStyleBackColor = true;
            BuyButton.Click += BuyButton_Click;
            // 
            // BasketButton
            // 
            BasketButton.Location = new Point(199, 358);
            BasketButton.Name = "BasketButton";
            BasketButton.Size = new Size(138, 38);
            BasketButton.TabIndex = 5;
            BasketButton.Text = "В корзину";
            BasketButton.UseVisualStyleBackColor = true;
            BasketButton.Click += BasketButton_Click;
            // 
            // BookPriceLabel
            // 
            BookPriceLabel.AutoSize = true;
            BookPriceLabel.Location = new Point(12, 154);
            BookPriceLabel.Name = "BookPriceLabel";
            BookPriceLabel.Size = new Size(38, 15);
            BookPriceLabel.TabIndex = 6;
            BookPriceLabel.Text = "label1";
            // 
            // BookInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 408);
            Controls.Add(BookPriceLabel);
            Controls.Add(BasketButton);
            Controls.Add(BuyButton);
            Controls.Add(BookDescriptionLabel);
            Controls.Add(BookAuthorLabel);
            Controls.Add(BookNameLabel);
            Controls.Add(BookCoverPictureBox);
            Name = "BookInfoForm";
            Text = "BookInfo";
            ((System.ComponentModel.ISupportInitialize)BookCoverPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox BookCoverPictureBox;
        private Label BookNameLabel;
        private Label BookAuthorLabel;
        private Label BookDescriptionLabel;
        private Button BuyButton;
        private Button BasketButton;
        private Label BookPriceLabel;
    }
}