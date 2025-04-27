namespace School_Pourchases
{
    partial class ComponentsView
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
            checkedListBox = new CheckedListBox();
            sortTypeCb = new ComboBox();
            label1 = new Label();
            lblSchoolName = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panelCatalog = new FlowLayoutPanel();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            OrderByCb = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            lblCost = new Label();
            lblCountItems = new Label();
            panelCatalog.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // checkedListBox
            // 
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Items.AddRange(new object[] { "Мониторы", "Процессоры", "Электронные доски", "Проекторы", "Экраны для проекторовОбучающие наборы" });
            checkedListBox.Location = new Point(531, 142);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(138, 292);
            checkedListBox.TabIndex = 1;
            // 
            // sortTypeCb
            // 
            sortTypeCb.BackColor = Color.White;
            sortTypeCb.FormattingEnabled = true;
            sortTypeCb.Location = new Point(74, 5);
            sortTypeCb.Name = "sortTypeCb";
            sortTypeCb.Size = new Size(121, 23);
            sortTypeCb.TabIndex = 2;
            sortTypeCb.Text = "Название категории";
            sortTypeCb.SelectedIndexChanged += sortTypeCb_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Location = new Point(21, 85);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 3;
            label1.Text = "Товаров в корзине:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSchoolName
            // 
            lblSchoolName.BackColor = SystemColors.ControlDark;
            lblSchoolName.Location = new Point(531, 10);
            lblSchoolName.Name = "lblSchoolName";
            lblSchoolName.Size = new Size(138, 90);
            lblSchoolName.TabIndex = 4;
            // 
            // label2
            // 
            label2.Location = new Point(404, 10);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 3;
            label2.Text = "Учреждение";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(531, 124);
            label3.Name = "label3";
            label3.Size = new Size(138, 15);
            label3.TabIndex = 3;
            label3.Text = "Выбранные категории:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 9);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 6;
            label4.Text = "Категория:";
            label4.Click += this.label4_Click;
            // 
            // panelCatalog
            // 
            panelCatalog.AutoScroll = true;
            panelCatalog.BackColor = SystemColors.Info;
            panelCatalog.Controls.Add(panel1);
            panelCatalog.FlowDirection = FlowDirection.TopDown;
            panelCatalog.Location = new Point(14, 142);
            panelCatalog.Name = "panelCatalog";
            panelCatalog.Size = new Size(511, 292);
            panelCatalog.TabIndex = 7;
            panelCatalog.WrapContents = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 255, 191);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 129);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(401, 98);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Khaki;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label7);
            panel2.Location = new Point(276, 9);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(200, 82);
            panel2.TabIndex = 3;
            // 
            // label7
            // 
            label7.BackColor = Color.Ivory;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(5, 5);
            label7.Name = "label7";
            label7.Size = new Size(188, 70);
            label7.TabIndex = 0;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.Location = new Point(124, 63);
            label6.Name = "label6";
            label6.Size = new Size(110, 23);
            label6.TabIndex = 2;
            label6.Text = "Цена товара";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Location = new Point(124, 10);
            label5.Name = "label5";
            label5.Size = new Size(110, 53);
            label5.TabIndex = 1;
            label5.Text = "Название товара";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(7, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 82);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PapayaWhip;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(OrderByCb);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(sortTypeCb);
            panel3.Location = new Point(294, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(213, 68);
            panel3.TabIndex = 8;
            // 
            // OrderByCb
            // 
            OrderByCb.BackColor = Color.White;
            OrderByCb.FormattingEnabled = true;
            OrderByCb.Location = new Point(74, 38);
            OrderByCb.Name = "OrderByCb";
            OrderByCb.Size = new Size(121, 23);
            OrderByCb.TabIndex = 2;
            OrderByCb.Text = "Название категории";
            OrderByCb.SelectedIndexChanged += sortTypeCb_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 42);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 6;
            label8.Text = "Категория:";
            label8.Click += this.label4_Click;
            // 
            // label9
            // 
            label9.Location = new Point(25, 118);
            label9.Name = "label9";
            label9.Size = new Size(127, 15);
            label9.TabIndex = 3;
            label9.Text = "Примерная цена";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCost
            // 
            lblCost.Location = new Point(158, 118);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(13, 15);
            lblCost.TabIndex = 5;
            lblCost.Text = "0";
            lblCost.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCountItems
            // 
            lblCountItems.Location = new Point(158, 85);
            lblCountItems.Name = "lblCountItems";
            lblCountItems.Size = new Size(13, 15);
            lblCountItems.TabIndex = 5;
            lblCountItems.Text = "0";
            lblCountItems.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ComponentsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            Controls.Add(panel3);
            Controls.Add(panelCatalog);
            Controls.Add(lblCountItems);
            Controls.Add(lblCost);
            Controls.Add(lblSchoolName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(checkedListBox);
            Name = "ComponentsView";
            Size = new Size(672, 450);
            panelCatalog.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CheckedListBox checkedListBox;
        private ComboBox sortTypeCb;
        private Label label1;
        private Label lblSchoolName;
        private Label label2;
        private Label label3;
        private Label label4;
        private FlowLayoutPanel panelCatalog;
        private Panel panel1;
        private Label label5;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label6;
        private Label label7;
        private Button button1;
        private Panel panel3;
        private Label label8;
        private ComboBox OrderByCb;
        private Label label9;
        private Label lblCost;
        private Label lblCountItems;
    }
}
