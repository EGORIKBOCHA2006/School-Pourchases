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
            sortTypeCb = new ComboBox();
            label1 = new Label();
            lblSchoolName = new Label();
            label2 = new Label();
            label4 = new Label();
            panelCatalog = new FlowLayoutPanel();
            panel3 = new Panel();
            label8 = new Label();
            OrderByCb = new ComboBox();
            label9 = new Label();
            lblCost = new Label();
            lblCountItems = new Label();
            panel1 = new Panel();
            label5 = new Label();
            lblNameUser = new Label();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sortTypeCb
            // 
            sortTypeCb.BackColor = Color.White;
            sortTypeCb.DropDownStyle = ComboBoxStyle.DropDownList;
            sortTypeCb.FormattingEnabled = true;
            sortTypeCb.Items.AddRange(new object[] { "Монитор", "Процессор", "Все товары" });
            sortTypeCb.Location = new Point(74, 5);
            sortTypeCb.Name = "sortTypeCb";
            sortTypeCb.Size = new Size(152, 23);
            sortTypeCb.TabIndex = 2;
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
            // lblSchoolName
            // 
            lblSchoolName.BackColor = Color.PapayaWhip;
            lblSchoolName.Font = new Font("Segoe UI", 12F);
            lblSchoolName.Location = new Point(596, 10);
            lblSchoolName.Name = "lblSchoolName";
            lblSchoolName.Size = new Size(289, 47);
            lblSchoolName.TabIndex = 4;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(447, 10);
            label2.Name = "label2";
            label2.Size = new Size(122, 27);
            label2.TabIndex = 3;
            label2.Text = "Учреждение";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 9);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 6;
            label4.Text = "Категория:";
            // 
            // panelCatalog
            // 
            panelCatalog.AutoScroll = true;
            panelCatalog.BackColor = SystemColors.Info;
            panelCatalog.FlowDirection = FlowDirection.TopDown;
            panelCatalog.Location = new Point(14, 142);
            panelCatalog.Name = "panelCatalog";
            panelCatalog.Size = new Size(994, 417);
            panelCatalog.TabIndex = 7;
            panelCatalog.WrapContents = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PapayaWhip;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(OrderByCb);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(sortTypeCb);
            panel3.Location = new Point(338, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(231, 68);
            panel3.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 42);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 6;
            label8.Text = "Цена";
            // 
            // OrderByCb
            // 
            OrderByCb.BackColor = Color.White;
            OrderByCb.DropDownStyle = ComboBoxStyle.DropDownList;
            OrderByCb.FormattingEnabled = true;
            OrderByCb.Items.AddRange(new object[] { "По возрастанию цены", "По убыванию цены", "Нет сортировки" });
            OrderByCb.Location = new Point(74, 38);
            OrderByCb.Name = "OrderByCb";
            OrderByCb.Size = new Size(152, 23);
            OrderByCb.TabIndex = 2;
            // 
            // label9
            // 
            label9.Location = new Point(13, 42);
            label9.Name = "label9";
            label9.Size = new Size(131, 15);
            label9.TabIndex = 3;
            label9.Text = "Примерная цена";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCost
            // 
            lblCost.Location = new Point(146, 42);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(13, 15);
            lblCost.TabIndex = 5;
            lblCost.Text = "0";
            lblCost.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCountItems
            // 
            lblCountItems.Location = new Point(146, 10);
            lblCountItems.Name = "lblCountItems";
            lblCountItems.Size = new Size(13, 15);
            lblCountItems.TabIndex = 5;
            lblCountItems.Text = "0";
            lblCountItems.TextAlign = ContentAlignment.MiddleLeft;
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
            panel1.TabIndex = 9;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(106, 10);
            label5.Name = "label5";
            label5.Size = new Size(147, 27);
            label5.TabIndex = 3;
            label5.Text = "Пользователь";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNameUser
            // 
            lblNameUser.BackColor = Color.PapayaWhip;
            lblNameUser.Font = new Font("Segoe UI", 12F);
            lblNameUser.Location = new Point(269, 10);
            lblNameUser.Name = "lblNameUser";
            lblNameUser.Size = new Size(172, 47);
            lblNameUser.TabIndex = 4;
            // 
            // ComponentsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panelCatalog);
            Controls.Add(lblNameUser);
            Controls.Add(lblSchoolName);
            Controls.Add(label5);
            Controls.Add(label2);
            Name = "ComponentsView";
            Size = new Size(1011, 562);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ComboBox sortTypeCb;
        private Label label1;
        private Label lblSchoolName;
        private Label label2;
        private Label label4;
        private FlowLayoutPanel panelCatalog;
        private Panel panel3;
        private Label label8;
        private ComboBox OrderByCb;
        private Label label9;
        private Label lblCost;
        private Label lblCountItems;
        private Panel panel1;
        private Label label5;
        private Label lblNameUser;
    }
}
