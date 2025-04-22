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
            // ComponentsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(sortTypeCb);
            Controls.Add(checkedListBox);
            Controls.Add(listView1);
            Name = "ComponentsView";
            Size = new Size(672, 450);
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private CheckedListBox checkedListBox;
        private ComboBox sortTypeCb;
    }
}
