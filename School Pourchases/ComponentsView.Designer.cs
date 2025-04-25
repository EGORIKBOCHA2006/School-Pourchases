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
            listView1 = new ListView();
            checkedListBox = new CheckedListBox();
            sortTypeCb = new ComboBox();
            label1 = new Label();
            lblSchoolName = new Label();
            lblCountItems = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(21, 136);
            listView1.Name = "listView1";
            listView1.Size = new Size(504, 307);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
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
            sortTypeCb.FormattingEnabled = true;
            sortTypeCb.Location = new Point(404, 107);
            sortTypeCb.Name = "sortTypeCb";
            sortTypeCb.Size = new Size(121, 23);
            sortTypeCb.TabIndex = 2;
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
            // lblCountItems
            // 
            lblCountItems.AutoSize = true;
            lblCountItems.Location = new Point(154, 85);
            lblCountItems.Name = "lblCountItems";
            lblCountItems.Size = new Size(13, 15);
            lblCountItems.TabIndex = 5;
            lblCountItems.Text = "0";
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
            label4.Location = new Point(335, 111);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 6;
            label4.Text = "Категория:";
            // 
            // ComponentsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(lblCountItems);
            Controls.Add(lblSchoolName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sortTypeCb);
            Controls.Add(checkedListBox);
            Controls.Add(listView1);
            Name = "ComponentsView";
            Size = new Size(672, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private CheckedListBox checkedListBox;
        private ComboBox sortTypeCb;
        private Label label1;
        private Label lblSchoolName;
        private Label lblCountItems;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
