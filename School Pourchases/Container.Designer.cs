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
            contentPanel = new Panel();
            menuPanel = new Panel();
            profileBtn = new PictureBox();
            cartBtn = new PictureBox();
            catalogBtn = new PictureBox();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profileBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cartBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)catalogBtn).BeginInit();
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
            profileBtn.Cursor = Cursors.Hand;
            profileBtn.Image = Properties.Resources.pngwing_com;
            profileBtn.Location = new Point(20, 253);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new Size(83, 93);
            profileBtn.SizeMode = PictureBoxSizeMode.Zoom;
            profileBtn.TabIndex = 0;
            profileBtn.TabStop = false;
            // 
            // cartBtn
            // 
            cartBtn.Cursor = Cursors.Hand;
            cartBtn.Image = Properties.Resources.pngwing_com;
            cartBtn.Location = new Point(20, 137);
            cartBtn.Name = "cartBtn";
            cartBtn.Size = new Size(83, 93);
            cartBtn.SizeMode = PictureBoxSizeMode.Zoom;
            cartBtn.TabIndex = 0;
            cartBtn.TabStop = false;
            cartBtn.Click += cartBtn_Click;
            // 
            // catalogBtn
            // 
            catalogBtn.Cursor = Cursors.Hand;
            catalogBtn.Image = Properties.Resources.pngwing_com;
            catalogBtn.Location = new Point(20, 28);
            catalogBtn.Name = "catalogBtn";
            catalogBtn.Size = new Size(83, 93);
            catalogBtn.SizeMode = PictureBoxSizeMode.Zoom;
            catalogBtn.TabIndex = 0;
            catalogBtn.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)profileBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)cartBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)catalogBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel contentPanel;
        public Panel menuPanel;
        private PictureBox catalogBtn;
        private PictureBox profileBtn;
        private PictureBox cartBtn;
    }
}
