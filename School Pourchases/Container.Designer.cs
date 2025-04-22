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
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Dock = DockStyle.Right;
            contentPanel.Location = new Point(128, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(672, 450);
            contentPanel.TabIndex = 0;
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.Gainsboro;
            menuPanel.Dock = DockStyle.Right;
            menuPanel.Location = new Point(-1, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(129, 450);
            menuPanel.TabIndex = 1;
            // 
            // Container
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuPanel);
            Controls.Add(contentPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Container";
            Text = "Школьные закупки";
            ResumeLayout(false);
        }

        #endregion

        public Panel contentPanel;
        public Panel menuPanel;
    }
}
