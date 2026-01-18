namespace LibraryControlService
{
    partial class ListBookForm
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
            BuyButton = new Button();
            label2 = new Label();
            BasketPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(244, 28);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Корзина";
            label1.Click += label1_Click;
            // 
            // BuyButton
            // 
            BuyButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BuyButton.Location = new Point(85, 403);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(116, 26);
            BuyButton.TabIndex = 2;
            BuyButton.Text = "Купить";
            BuyButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 410);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Цена: ";
            // 
            // BasketPanel
            // 
            BasketPanel.AutoScroll = true;
            BasketPanel.Location = new Point(0, 81);
            BasketPanel.Name = "BasketPanel";
            BasketPanel.Size = new Size(604, 300);
            BasketPanel.TabIndex = 5;
            // 
            // ListBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 450);
            Controls.Add(BasketPanel);
            Controls.Add(label2);
            Controls.Add(BuyButton);
            Controls.Add(label1);
            Name = "ListBookForm";
            Text = "ListBookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BuyButton;
        private Label label2;
        private FlowLayoutPanel BasketPanel;
    }
}