namespace School_Pourchases
{
    partial class CartView
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            panelCart = new FlowLayoutPanel();
            label3 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            label1 = new Label();
            lblCost = new Label();
            lblCountItems = new Label();
            btnMakeCsvFile = new Button();
            panel2 = new Panel();
            rbOwnCart = new RadioButton();
            rbRequiredCart = new RadioButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelCart
            // 
            panelCart.AutoScroll = true;
            panelCart.BackColor = SystemColors.Info;
            panelCart.FlowDirection = FlowDirection.TopDown;
            panelCart.Location = new Point(14, 142);
            panelCart.Name = "panelCart";
            panelCart.Size = new Size(994, 417);
            panelCart.TabIndex = 8;
            panelCart.WrapContents = false;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(9, 0);
            label3.Name = "label3";
            label3.Size = new Size(310, 37);
            label3.TabIndex = 11;
            label3.Text = "Корзина";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PapayaWhip;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblCost);
            panel1.Controls.Add(lblCountItems);
            panel1.Location = new Point(17, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 68);
            panel1.TabIndex = 12;
            // 
            // label9
            // 
            label9.Location = new Point(13, 42);
            label9.Name = "label9";
            label9.Size = new Size(131, 15);
            label9.TabIndex = 3;
            label9.Text = "Примерная цена руб.";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 3;
            label1.Text = "Товаров в корзине:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(146, 42);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(13, 15);
            lblCost.TabIndex = 5;
            lblCost.Text = "0";
            lblCost.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCountItems
            // 
            lblCountItems.AutoSize = true;
            lblCountItems.Location = new Point(146, 10);
            lblCountItems.Name = "lblCountItems";
            lblCountItems.Size = new Size(13, 15);
            lblCountItems.TabIndex = 5;
            lblCountItems.Text = "0";
            lblCountItems.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnMakeCsvFile
            // 
            btnMakeCsvFile.BackColor = Color.Wheat;
            btnMakeCsvFile.Cursor = Cursors.Hand;
            btnMakeCsvFile.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            btnMakeCsvFile.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            btnMakeCsvFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 225, 192);
            btnMakeCsvFile.FlatStyle = FlatStyle.Flat;
            btnMakeCsvFile.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMakeCsvFile.Location = new Point(677, 100);
            btnMakeCsvFile.Name = "btnMakeCsvFile";
            btnMakeCsvFile.Size = new Size(331, 39);
            btnMakeCsvFile.TabIndex = 13;
            btnMakeCsvFile.Text = "Создать Csv таблицу с товаром";
            btnMakeCsvFile.UseVisualStyleBackColor = false;
            btnMakeCsvFile.Click += btnMakeCsvFile_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PapayaWhip;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(rbRequiredCart);
            panel2.Controls.Add(rbOwnCart);
            panel2.Location = new Point(349, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(302, 68);
            panel2.TabIndex = 13;
            // 
            // rbOwnCart
            // 
            rbOwnCart.AutoSize = true;
            rbOwnCart.Checked = true;
            rbOwnCart.Location = new Point(31, 7);
            rbOwnCart.Name = "rbOwnCart";
            rbOwnCart.Size = new Size(90, 19);
            rbOwnCart.TabIndex = 0;
            rbOwnCart.TabStop = true;
            rbOwnCart.Text = "Моя корзна";
            rbOwnCart.UseVisualStyleBackColor = true;
            // 
            // rbRequiredCart
            // 
            rbRequiredCart.AutoSize = true;
            rbRequiredCart.Location = new Point(31, 38);
            rbRequiredCart.Name = "rbRequiredCart";
            rbRequiredCart.Size = new Size(172, 19);
            rbRequiredCart.TabIndex = 0;
            rbRequiredCart.Text = "Рекомендованная корзина";
            rbRequiredCart.UseVisualStyleBackColor = true;
            // 
            // CartView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            Controls.Add(panel2);
            Controls.Add(btnMakeCsvFile);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(panelCart);
            Name = "CartView";
            Size = new Size(1011, 562);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panelCart;
        private Label label3;
        private Panel panel1;
        private Label label9;
        private Label label1;
        private Label lblCost;
        private Label lblCountItems;
        private Button btnMakeCsvFile;
        private Panel panel2;
        private RadioButton rbRequiredCart;
        private RadioButton rbOwnCart;
    }
}
