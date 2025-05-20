namespace School_Pourchases
{
    partial class ProfileView
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
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            label7 = new Label();
            typeSchoolCb = new ComboBox();
            registerBtn = new Button();
            passwordRegTb = new TextBox();
            responsibleRegTb = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BlanchedAlmond;
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(0, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(1011, 425);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.NavajoWhite;
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(286, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(422, 292);
            panel3.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AntiqueWhite;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(typeSchoolCb);
            panel2.Controls.Add(registerBtn);
            panel2.Controls.Add(passwordRegTb);
            panel2.Controls.Add(responsibleRegTb);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(27, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(374, 234);
            panel2.TabIndex = 20;
            // 
            // label7
            // 
            label7.Location = new Point(14, 75);
            label7.Name = "label7";
            label7.Size = new Size(107, 23);
            label7.TabIndex = 14;
            label7.Text = "Тип школы";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // typeSchoolCb
            // 
            typeSchoolCb.DropDownStyle = ComboBoxStyle.DropDownList;
            typeSchoolCb.Items.AddRange(new object[] { "Сельская школа", "Школа в среднем городе", "Школа в большом городе" });
            typeSchoolCb.Location = new Point(161, 75);
            typeSchoolCb.Name = "typeSchoolCb";
            typeSchoolCb.Size = new Size(202, 23);
            typeSchoolCb.TabIndex = 19;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.Wheat;
            registerBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Location = new Point(14, 178);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(349, 37);
            registerBtn.TabIndex = 11;
            registerBtn.Text = "Обновить данные";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // passwordRegTb
            // 
            passwordRegTb.Location = new Point(161, 120);
            passwordRegTb.Name = "passwordRegTb";
            passwordRegTb.Size = new Size(202, 23);
            passwordRegTb.TabIndex = 18;
            // 
            // responsibleRegTb
            // 
            responsibleRegTb.Location = new Point(161, 28);
            responsibleRegTb.Name = "responsibleRegTb";
            responsibleRegTb.Size = new Size(202, 23);
            responsibleRegTb.TabIndex = 17;
            // 
            // label4
            // 
            label4.Location = new Point(14, 18);
            label4.Name = "label4";
            label4.Size = new Size(125, 40);
            label4.TabIndex = 13;
            label4.Text = "Имя пользователя";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new Point(14, 119);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 12;
            label3.Text = "Пароль";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProfileView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            Controls.Add(panel1);
            Name = "ProfileView";
            Size = new Size(1011, 562);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label7;
        private ComboBox typeSchoolCb;
        private Button registerBtn;
        private TextBox passwordRegTb;
        private TextBox responsibleRegTb;
        private Label label4;
        private Label label3;
        private Panel panel3;
    }
}
