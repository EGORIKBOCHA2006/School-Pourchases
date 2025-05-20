namespace School_Pourchases
{
    partial class LoginView
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
            tabControl1 = new TabControl();
            LoginPage = new TabPage();
            loginBtn = new Button();
            passwordTb = new MaskedTextBox();
            responsibleTb = new TextBox();
            schoolTb = new TextBox();
            label2 = new Label();
            label6 = new Label();
            label1 = new Label();
            RegisterPage = new TabPage();
            typeSchoolCb = new ComboBox();
            passwordRegTb = new TextBox();
            responsibleRegTb = new TextBox();
            schoolNameRegTb = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            label5 = new Label();
            registerBtn = new Button();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            LoginPage.SuspendLayout();
            RegisterPage.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Location = new Point(390, 160);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 269);
            panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(LoginPage);
            tabControl1.Controls.Add(RegisterPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(374, 269);
            tabControl1.TabIndex = 0;
            // 
            // LoginPage
            // 
            LoginPage.BackColor = Color.PapayaWhip;
            LoginPage.Controls.Add(loginBtn);
            LoginPage.Controls.Add(passwordTb);
            LoginPage.Controls.Add(responsibleTb);
            LoginPage.Controls.Add(schoolTb);
            LoginPage.Controls.Add(label2);
            LoginPage.Controls.Add(label6);
            LoginPage.Controls.Add(label1);
            LoginPage.Location = new Point(4, 27);
            LoginPage.Name = "LoginPage";
            LoginPage.Padding = new Padding(3, 3, 50, 3);
            LoginPage.Size = new Size(366, 238);
            LoginPage.TabIndex = 0;
            LoginPage.Text = "Войти";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Wheat;
            loginBtn.FlatAppearance.BorderColor = Color.Wheat;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Location = new Point(11, 176);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(349, 37);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Войти";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += Login_Click;
            // 
            // passwordTb
            // 
            passwordTb.Location = new Point(158, 113);
            passwordTb.Name = "passwordTb";
            passwordTb.PasswordChar = '*';
            passwordTb.Size = new Size(202, 23);
            passwordTb.TabIndex = 3;
            // 
            // responsibleTb
            // 
            responsibleTb.Location = new Point(158, 73);
            responsibleTb.Name = "responsibleTb";
            responsibleTb.Size = new Size(202, 23);
            responsibleTb.TabIndex = 2;
            // 
            // schoolTb
            // 
            schoolTb.Location = new Point(158, 36);
            schoolTb.Name = "schoolTb";
            schoolTb.Size = new Size(202, 23);
            schoolTb.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(11, 112);
            label2.Name = "label2";
            label2.Size = new Size(107, 23);
            label2.TabIndex = 0;
            label2.Text = "Пароль";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Location = new Point(11, 63);
            label6.Name = "label6";
            label6.Size = new Size(125, 40);
            label6.TabIndex = 0;
            label6.Text = "Имя пользователя";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Location = new Point(11, 35);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 0;
            label1.Text = "Название школы";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RegisterPage
            // 
            RegisterPage.BackColor = Color.PapayaWhip;
            RegisterPage.Controls.Add(typeSchoolCb);
            RegisterPage.Controls.Add(passwordRegTb);
            RegisterPage.Controls.Add(responsibleRegTb);
            RegisterPage.Controls.Add(schoolNameRegTb);
            RegisterPage.Controls.Add(label3);
            RegisterPage.Controls.Add(label4);
            RegisterPage.Controls.Add(label7);
            RegisterPage.Controls.Add(label5);
            RegisterPage.Controls.Add(registerBtn);
            RegisterPage.Location = new Point(4, 27);
            RegisterPage.Name = "RegisterPage";
            RegisterPage.Padding = new Padding(3);
            RegisterPage.Size = new Size(366, 238);
            RegisterPage.TabIndex = 1;
            RegisterPage.Text = "Регистрация";
            // 
            // typeSchoolCb
            // 
            typeSchoolCb.DropDownStyle = ComboBoxStyle.DropDownList;
            typeSchoolCb.Items.AddRange(new object[] { "Сельская школа", "Школа в среднем городе", "Школа в большом городе" });
            typeSchoolCb.Location = new Point(158, 70);
            typeSchoolCb.Name = "typeSchoolCb";
            typeSchoolCb.Size = new Size(202, 23);
            typeSchoolCb.TabIndex = 10;
            // 
            // passwordRegTb
            // 
            passwordRegTb.Location = new Point(158, 135);
            passwordRegTb.Name = "passwordRegTb";
            passwordRegTb.Size = new Size(202, 23);
            passwordRegTb.TabIndex = 9;
            // 
            // responsibleRegTb
            // 
            responsibleRegTb.Location = new Point(158, 103);
            responsibleRegTb.Name = "responsibleRegTb";
            responsibleRegTb.Size = new Size(202, 23);
            responsibleRegTb.TabIndex = 8;
            // 
            // schoolNameRegTb
            // 
            schoolNameRegTb.Location = new Point(158, 36);
            schoolNameRegTb.Name = "schoolNameRegTb";
            schoolNameRegTb.Size = new Size(202, 23);
            schoolNameRegTb.TabIndex = 7;
            // 
            // label3
            // 
            label3.Location = new Point(11, 134);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 4;
            label3.Text = "Пароль";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Location = new Point(11, 93);
            label4.Name = "label4";
            label4.Size = new Size(125, 40);
            label4.TabIndex = 5;
            label4.Text = "Имя пользователя";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Location = new Point(11, 70);
            label7.Name = "label7";
            label7.Size = new Size(107, 23);
            label7.TabIndex = 6;
            label7.Text = "Тип школы";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Location = new Point(11, 35);
            label5.Name = "label5";
            label5.Size = new Size(107, 23);
            label5.TabIndex = 6;
            label5.Text = "Название школы";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.Wheat;
            registerBtn.FlatAppearance.BorderColor = Color.FromArgb(26, 181, 255);
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Location = new Point(11, 193);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(349, 37);
            registerBtn.TabIndex = 3;
            registerBtn.Text = "Заргистрироваться";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += Register_Click;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            Controls.Add(panel1);
            Name = "LoginView";
            Size = new Size(1156, 601);
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            LoginPage.ResumeLayout(false);
            LoginPage.PerformLayout();
            RegisterPage.ResumeLayout(false);
            RegisterPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage LoginPage;
        private TabPage RegisterPage;
        private Button loginBtn;
        private MaskedTextBox passwordTb;
        private TextBox schoolTb;
        private Label label2;
        private Label label1;
        private Button registerBtn;
        private TextBox responsibleTb;
        private Label label6;
        private TextBox passwordRegTb;
        private TextBox responsibleRegTb;
        private TextBox schoolNameRegTb;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox typeSchoolCb;
        private Label label7;
    }
}
