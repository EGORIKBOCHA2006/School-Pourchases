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
            passwordTb = new TextBox();
            schoolTb = new TextBox();
            label2 = new Label();
            label1 = new Label();
            RegisterPage = new TabPage();
            registerBtn = new Button();
            makePasswordTb = new TextBox();
            makePersonTb = new TextBox();
            makeSchoolNameTb = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            LoginPage.SuspendLayout();
            RegisterPage.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Location = new Point(200, 110);
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
            LoginPage.BackColor = SystemColors.ControlLightLight;
            LoginPage.Controls.Add(loginBtn);
            LoginPage.Controls.Add(passwordTb);
            LoginPage.Controls.Add(schoolTb);
            LoginPage.Controls.Add(label2);
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
            loginBtn.BackColor = Color.FromArgb(255, 128, 0);
            loginBtn.FlatAppearance.BorderColor = Color.FromArgb(26, 181, 255);
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Location = new Point(11, 163);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(349, 37);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Войти";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += Login_Click;
            // 
            // passwordTb
            // 
            passwordTb.Location = new Point(158, 113);
            passwordTb.Name = "passwordTb";
            passwordTb.Size = new Size(202, 23);
            passwordTb.TabIndex = 1;
            // 
            // schoolTb
            // 
            schoolTb.Location = new Point(158, 51);
            schoolTb.Name = "schoolTb";
            schoolTb.Size = new Size(202, 23);
            schoolTb.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(11, 113);
            label2.Name = "label2";
            label2.Size = new Size(107, 23);
            label2.TabIndex = 0;
            label2.Text = "Пароль";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Location = new Point(9, 43);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 0;
            label1.Text = "Название школы";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RegisterPage
            // 
            RegisterPage.BackColor = SystemColors.ControlLightLight;
            RegisterPage.Controls.Add(registerBtn);
            RegisterPage.Controls.Add(makePasswordTb);
            RegisterPage.Controls.Add(makePersonTb);
            RegisterPage.Controls.Add(makeSchoolNameTb);
            RegisterPage.Controls.Add(label5);
            RegisterPage.Controls.Add(label4);
            RegisterPage.Controls.Add(label3);
            RegisterPage.Location = new Point(4, 27);
            RegisterPage.Name = "RegisterPage";
            RegisterPage.Padding = new Padding(3);
            RegisterPage.Size = new Size(366, 238);
            RegisterPage.TabIndex = 1;
            RegisterPage.Text = "Регистрация";
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.FromArgb(255, 128, 0);
            registerBtn.FlatAppearance.BorderColor = Color.FromArgb(26, 181, 255);
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Location = new Point(11, 170);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(349, 37);
            registerBtn.TabIndex = 3;
            registerBtn.Text = "Заргистрироваться";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += Register_Click;
            // 
            // makePasswordTb
            // 
            makePasswordTb.Location = new Point(153, 134);
            makePasswordTb.Name = "makePasswordTb";
            makePasswordTb.Size = new Size(207, 23);
            makePasswordTb.TabIndex = 1;
            // 
            // makePersonTb
            // 
            makePersonTb.Location = new Point(153, 85);
            makePersonTb.Name = "makePersonTb";
            makePersonTb.Size = new Size(207, 23);
            makePersonTb.TabIndex = 1;
            // 
            // makeSchoolNameTb
            // 
            makeSchoolNameTb.Location = new Point(153, 39);
            makeSchoolNameTb.Name = "makeSchoolNameTb";
            makeSchoolNameTb.Size = new Size(207, 23);
            makeSchoolNameTb.TabIndex = 1;
            // 
            // label5
            // 
            label5.Location = new Point(8, 134);
            label5.Name = "label5";
            label5.Size = new Size(139, 23);
            label5.TabIndex = 0;
            label5.Text = "Пароль";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Location = new Point(8, 85);
            label4.Name = "label4";
            label4.Size = new Size(139, 23);
            label4.TabIndex = 0;
            label4.Text = "ФИО ответственного";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new Point(8, 39);
            label3.Name = "label3";
            label3.Size = new Size(139, 23);
            label3.TabIndex = 0;
            label3.Text = "Название школы";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            Controls.Add(panel1);
            Name = "LoginView";
            Size = new Size(800, 450);
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
        private TextBox passwordTb;
        private TextBox schoolTb;
        private Label label2;
        private Label label1;
        private TextBox makeSchoolNameTb;
        private Label label3;
        private TextBox makePasswordTb;
        private TextBox makePersonTb;
        private Label label5;
        private Label label4;
        private Button registerBtn;
    }
}
