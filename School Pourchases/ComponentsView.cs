using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Pourchases
{
    public partial class ComponentsView : UserControl
    {
        public void LoadItem(string name, double cost, string description)
        {
        
            // 
            // itemPanel
            // 
            Panel tempItemPanel = new Panel();
            Button tempBtnAddToCart = new Button();
            Panel tempPanel2 = new Panel();
            Label tempLblDescriptionItem= new Label();
            Label  tempLblCostItem= new Label();
            Label tempLblNameItem = new Label();
            PictureBox tempPictureItem = new PictureBox();
            panelCatalog.Controls.Add(tempItemPanel);
            tempItemPanel.BackColor = Color.FromArgb(251, 255, 191);
            tempItemPanel.BorderStyle = BorderStyle.FixedSingle;
            tempItemPanel.Controls.Add(tempBtnAddToCart);
            tempItemPanel.Controls.Add(tempPanel2);
            tempItemPanel.Controls.Add(tempLblCostItem);
            tempItemPanel.Controls.Add(tempLblNameItem);
            tempItemPanel.Controls.Add(tempPictureItem);
            tempItemPanel.Location = new Point(3, 3);
            tempItemPanel.Name = "itemPanel";
            tempItemPanel.Size = new Size(486, 129);
            tempItemPanel.TabIndex = 0;
            // 
            // btnAddToCart
            // 
            tempBtnAddToCart.Location = new Point(401, 98);
            tempBtnAddToCart.Name = "btnAddToCart";
            tempBtnAddToCart.Size = new Size(75, 23);
            tempBtnAddToCart.TabIndex = 4;
            tempBtnAddToCart.Text = "Добавить";
            tempBtnAddToCart.UseVisualStyleBackColor = true;
            tempBtnAddToCart.Click += btnAddToCart_Click;
            // 
            // panel2
            // 
            tempPanel2.BackColor = Color.Khaki;
            tempPanel2.BorderStyle = BorderStyle.FixedSingle;
            tempPanel2.Controls.Add(tempLblDescriptionItem);
            tempPanel2.Location = new Point(276, 9);
            tempPanel2.Name = "panel2";
            tempPanel2.Padding = new Padding(5);
            tempPanel2.Size = new Size(200, 82);
            tempPanel2.TabIndex = 3;
            // 
            // lblDescriptionItem
            // 
            tempLblDescriptionItem.BackColor = Color.Ivory;
            tempLblDescriptionItem.Dock = DockStyle.Fill;
            tempLblDescriptionItem.Location = new Point(5, 5);
            tempLblDescriptionItem.Name = "lblDescriptionItem";
            tempLblDescriptionItem.Size = new Size(188, 70);
            tempLblDescriptionItem.TabIndex = 0;
            tempLblDescriptionItem.Text = description;
            // 
            // lblCostItem
            // 
            tempLblCostItem.Location = new Point(124, 63);
            tempLblCostItem.Name = "lblCostItem";
            tempLblCostItem.Size = new Size(110, 23);
            tempLblCostItem.TabIndex = 2;
            tempLblCostItem.Text = cost+" руб.";
            tempLblCostItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNameItem
            // 
            tempLblNameItem.Location = new Point(124, 10);
            tempLblNameItem.Name = "lblNameItem";
            tempLblNameItem.Size = new Size(110, 53);
            tempLblNameItem.TabIndex = 1;
            tempLblNameItem.Text = name;
            // 
            // itemPicture
            // 
            tempPictureItem.Location = new Point(7, 9);
            tempPictureItem.Name = "itemPicture";
            tempPictureItem.Size = new Size(98, 82);
            tempPictureItem.TabIndex = 0;
            tempPictureItem.TabStop = false;
            tempPictureItem.WaitOnLoad = true;
        }

        public ComponentsView()
        {
            InitializeComponent();
            for (int i=0;i<10;i++)
                LoadItem("Залупа ебаная",500,"Я вахуе кто покупает эту ебанину");

        }

        private void sortTypeCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

        }
    }
}
