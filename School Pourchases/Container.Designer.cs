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
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            caralogBtn = new PictureBox();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)caralogBtn).BeginInit();
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
            menuPanel.BackColor = Color.Gainsboro;
            menuPanel.Controls.Add(pictureBox3);
            menuPanel.Controls.Add(pictureBox2);
            menuPanel.Controls.Add(caralogBtn);
            menuPanel.Dock = DockStyle.Right;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(129, 562);
            menuPanel.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pngwing_com;
            pictureBox3.Location = new Point(20, 253);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(83, 93);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pngwing_com;
            pictureBox2.Location = new Point(20, 137);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(83, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // caralogBtn
            // 
            caralogBtn.Image = Properties.Resources.pngwing_com;
            caralogBtn.Location = new Point(20, 28);
            caralogBtn.Name = "caralogBtn";
            caralogBtn.Size = new Size(83, 93);
            caralogBtn.SizeMode = PictureBoxSizeMode.Zoom;
            caralogBtn.TabIndex = 0;
            caralogBtn.TabStop = false;
            caralogBtn.Click += caralogBtn_Click_1;
            // 
            // Container
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 562);
            Controls.Add(menuPanel);
            Controls.Add(contentPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Container";
            Text = "Школьные закупки";
            menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)caralogBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel contentPanel;
        public Panel menuPanel;
        private PictureBox caralogBtn;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}
