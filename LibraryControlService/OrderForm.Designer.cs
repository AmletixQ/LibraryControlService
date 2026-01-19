namespace LibraryControlService
{
    partial class OrderForm
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
			MainLabel = new Label();
			FullnameInput = new TextBox();
			label2 = new Label();
			label3 = new Label();
			PhoneInput = new TextBox();
			EmailInput = new TextBox();
			label5 = new Label();
			AddressInput = new TextBox();
			label6 = new Label();
			JokeInput = new TextBox();
			label7 = new Label();
			ConfirmBuyButton = new Button();
			SuspendLayout();
			// 
			// MainLabel
			// 
			MainLabel.AutoSize = true;
			MainLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
			MainLabel.Location = new Point(92, 9);
			MainLabel.Name = "MainLabel";
			MainLabel.Size = new Size(203, 37);
			MainLabel.TabIndex = 0;
			MainLabel.Text = "Форма заказа";
			// 
			// FullnameInput
			// 
			FullnameInput.Location = new Point(132, 76);
			FullnameInput.MaxLength = 100;
			FullnameInput.Name = "FullnameInput";
			FullnameInput.PlaceholderText = "ФИО";
			FullnameInput.Size = new Size(252, 23);
			FullnameInput.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 79);
			label2.Name = "label2";
			label2.Size = new Size(78, 15);
			label2.TabIndex = 2;
			label2.Text = "Полное имя:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 108);
			label3.Name = "label3";
			label3.Size = new Size(104, 15);
			label3.TabIndex = 4;
			label3.Text = "Номер телефона:";
			// 
			// PhoneInput
			// 
			PhoneInput.Location = new Point(132, 105);
			PhoneInput.MaxLength = 12;
			PhoneInput.Name = "PhoneInput";
			PhoneInput.PlaceholderText = "89995080007";
			PhoneInput.Size = new Size(252, 23);
			PhoneInput.TabIndex = 3;
			// 
			// EmailInput
			// 
			EmailInput.Location = new Point(132, 134);
			EmailInput.Name = "EmailInput";
			EmailInput.PlaceholderText = "testemail@example.com";
			EmailInput.Size = new Size(252, 23);
			EmailInput.TabIndex = 5;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 137);
			label5.Name = "label5";
			label5.Size = new Size(75, 15);
			label5.TabIndex = 6;
			label5.Text = "Адрес email:";
			// 
			// AddressInput
			// 
			AddressInput.Location = new Point(132, 163);
			AddressInput.Name = "AddressInput";
			AddressInput.PlaceholderText = "Улица Пушкина, Дом Калатушкина";
			AddressInput.Size = new Size(252, 23);
			AddressInput.TabIndex = 5;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(12, 166);
			label6.Name = "label6";
			label6.Size = new Size(43, 15);
			label6.TabIndex = 6;
			label6.Text = "Адрес:";
			// 
			// JokeInput
			// 
			JokeInput.Location = new Point(244, 192);
			JokeInput.Name = "JokeInput";
			JokeInput.PlaceholderText = "999";
			JokeInput.Size = new Size(140, 23);
			JokeInput.TabIndex = 7;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(12, 195);
			label7.Name = "label7";
			label7.Size = new Size(226, 15);
			label7.TabIndex = 8;
			label7.Text = "Последние 3 цифры банковской карты:";
			// 
			// ConfirmBuyButton
			// 
			ConfirmBuyButton.BackColor = Color.PaleGreen;
			ConfirmBuyButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
			ConfirmBuyButton.Location = new Point(89, 274);
			ConfirmBuyButton.Name = "ConfirmBuyButton";
			ConfirmBuyButton.Size = new Size(213, 44);
			ConfirmBuyButton.TabIndex = 9;
			ConfirmBuyButton.Text = "Подтвердить покупку";
			ConfirmBuyButton.UseVisualStyleBackColor = false;
			ConfirmBuyButton.Click += ConfirmBuyButton_Click;
			// 
			// OrderForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(396, 330);
			Controls.Add(ConfirmBuyButton);
			Controls.Add(label7);
			Controls.Add(JokeInput);
			Controls.Add(label5);
			Controls.Add(label6);
			Controls.Add(EmailInput);
			Controls.Add(AddressInput);
			Controls.Add(label3);
			Controls.Add(PhoneInput);
			Controls.Add(label2);
			Controls.Add(FullnameInput);
			Controls.Add(MainLabel);
			Name = "OrderForm";
			Text = "OrderForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label MainLabel;
        private TextBox FullnameInput;
        private Label label2;
        private Label label3;
        private TextBox PhoneInput;
        private TextBox EmailInput;
        private Label label5;
        private TextBox AddressInput;
        private Label label6;
        private TextBox JokeInput;
        private Label label7;
        private Button ConfirmBuyButton;
    }
}