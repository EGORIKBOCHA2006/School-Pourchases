namespace School_Pourchases
{
    partial class Container
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Container));
            contentPanel = new Panel();
            menuPanel = new Panel();
            profileBtn = new Button();
            cartBtn = new Button();
            catalogBtn = new Button();
            menuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Dock = DockStyle.Right;
            contentPanel.Location = new Point(129, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1011, 562);
            contentPanel.TabIndex = 0;
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.Khaki;
            menuPanel.BorderStyle = BorderStyle.Fixed3D;
            menuPanel.Controls.Add(profileBtn);
            menuPanel.Controls.Add(cartBtn);
            menuPanel.Controls.Add(catalogBtn);
            menuPanel.Dock = DockStyle.Right;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(129, 562);
            menuPanel.TabIndex = 1;
            // 
            // profileBtn
            // 
            profileBtn.BackColor = Color.Wheat;
            profileBtn.BackgroundImage = (Image)resources.GetObject("profileBtn.BackgroundImage");
            profileBtn.BackgroundImageLayout = ImageLayout.Zoom;
            profileBtn.Cursor = Cursors.Hand;
            profileBtn.FlatAppearance.BorderColor = Color.Black;
            profileBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            profileBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 225, 192);
            profileBtn.FlatStyle = FlatStyle.Flat;
            profileBtn.Image = Properties.Resources.pngwing_com;
            profileBtn.Location = new Point(20, 253);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new Size(83, 93);
            profileBtn.TabIndex = 0;
            profileBtn.TabStop = false;
            profileBtn.UseVisualStyleBackColor = false;
            profileBtn.Click += profileBtn_Click;
            // 
            // cartBtn
            // 
            cartBtn.BackColor = Color.Wheat;
            cartBtn.BackgroundImage = (Image)resources.GetObject("cartBtn.BackgroundImage");
            cartBtn.BackgroundImageLayout = ImageLayout.Zoom;
            cartBtn.Cursor = Cursors.Hand;
            cartBtn.FlatAppearance.BorderColor = Color.Black;
            cartBtn.FlatAppearance.BorderSize = 2;
            cartBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            cartBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 225, 192);
            cartBtn.FlatStyle = FlatStyle.Flat;
            cartBtn.Image = Properties.Resources.pngwing_com;
            cartBtn.Location = new Point(20, 137);
            cartBtn.Name = "cartBtn";
            cartBtn.Size = new Size(83, 93);
            cartBtn.TabIndex = 0;
            cartBtn.TabStop = false;
            cartBtn.UseVisualStyleBackColor = false;
            cartBtn.Click += cartBtn_Click;
            // 
            // catalogBtn
            // 
            catalogBtn.BackColor = Color.FromArgb(255, 192, 128);
            catalogBtn.BackgroundImage = (Image)resources.GetObject("catalogBtn.BackgroundImage");
            catalogBtn.BackgroundImageLayout = ImageLayout.Zoom;
            catalogBtn.Cursor = Cursors.Hand;
            catalogBtn.FlatAppearance.BorderColor = Color.Black;
            catalogBtn.FlatAppearance.BorderSize = 2;
            catalogBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            catalogBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 225, 192);
            catalogBtn.FlatStyle = FlatStyle.Flat;
            catalogBtn.Image = Properties.Resources.pngwing_com;
            catalogBtn.Location = new Point(20, 28);
            catalogBtn.Name = "catalogBtn";
            catalogBtn.Size = new Size(83, 93);
            catalogBtn.TabIndex = 0;
            catalogBtn.TabStop = false;
            catalogBtn.UseVisualStyleBackColor = false;
            catalogBtn.Click += catalogBtn_Click_1;
            // 
            // Container
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 562);
            Controls.Add(menuPanel);
            Controls.Add(contentPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Container";
            Text = "Школьные закупки";
            menuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Panel contentPanel;
        public Panel menuPanel;
        private Button catalogBtn;
        private Button profileBtn;
        private Button cartBtn;
    }
}
