using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;

namespace LibraryControlService
{
    enum KeyPressType
    {
        DigitAndLetter,
        OnlyDigit,
        OnlyLetter
    }

    public partial class OrderForm : Form
    {
        

        public OrderForm()
        {
            InitializeComponent();

            MainLabel.Left = this.Width / 2 - MainLabel.Width / 2;
            ConfirmBuyButton.Left = this.Width / 2 - ConfirmBuyButton.Width / 2;

            AddressInput.KeyPress += (s, e) => CheckPressedKey(s, e, KeyPressType.DigitAndLetter);
            EmailInput.KeyPress += (s, e) => CheckPressedKey(s, e, KeyPressType.DigitAndLetter);
            FullnameInput.KeyPress += (s, e) => CheckPressedKey(s, e, KeyPressType.OnlyLetter);
            PhoneInput.KeyPress += (s, e) => CheckPressedKey(s, e, KeyPressType.OnlyDigit);
        }

        private void ConfirmBuyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FullnameInput.Text))
            {
                ShowError("Введите ФИО!");
                return;
            }

            if (string.IsNullOrEmpty(PhoneInput.Text))
            {
                ShowError("Введите номер телефона!");
                return;
            }

            if (string.IsNullOrEmpty(EmailInput.Text))
            {
                ShowError("Введите email адрес!");
                return;
            }

            if (string.IsNullOrEmpty(AddressInput.Text))
            {
                ShowError("Введите адрес своего дома!");
                return;
            }

            MessageBox.Show("Спасибо за заказ! Ожидайте...");
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CheckPressedKey(
            object? sender,
            KeyPressEventArgs e,
            KeyPressType keyPressType
        )
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (keyPressType == KeyPressType.DigitAndLetter && (
                char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar) ||
                e.KeyChar == '.' || e.KeyChar == '@'
                )
            )
                return;

            if (keyPressType == KeyPressType.OnlyDigit && char.IsDigit(e.KeyChar))
                return;

            if (keyPressType == KeyPressType.OnlyLetter && char.IsLetter(e.KeyChar))
                return;

            e.Handled = true;
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
