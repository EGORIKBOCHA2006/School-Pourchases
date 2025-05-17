using Production;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Pourchases
{
    public partial class CartView : UserControl
    {
        Container parentContainer;
        public CartView( Container parentContainer)
        {
            InitializeComponent();
            this.parentContainer = parentContainer;
            lblCost.Text = parentContainer.totalCost.ToString();
            lblCountItems.Text = parentContainer.productCount.ToString();
            if (parentContainer.productCount==0)
            {
                panelCart.Visible = false;
                label3.Text = "Корзина пуста!";
            }
            LoadItemsAsync();
        }
        private async Task LoadItemsAsync()
        {
            panelCart.Controls.Clear();
            

            foreach (var product in parentContainer.user.cart)
            {
                PrintItem(product);

            }
        }


        private void PrintItem(KeyValuePair<Product, int> product) //НАДО РЕШИТЬ ЧЕРЕЗ ЧТО ОБЪЕКТЫ СЕРЕАЛИЗИРОВАТЬ И НАДО ЛИ
        {

            // 
            // itemPanel
            // 
            Panel tempItemPanel = new Panel();
            Button tempBtnDeleteFromCart = new Button();
            Panel tempPanel2 = new Panel();
            Panel tempPanel3 = new Panel();
            Label tempLblDescriptionItem = new Label();
            Label tempLblCostItem = new Label();
            Label tempLblNameItem = new Label();
            Label tempLblTypeItem = new Label();
            PictureBox tempPictureItem = new PictureBox();
            panelCart.Controls.Add(tempItemPanel);
            tempItemPanel.BackColor = Color.FromArgb(251, 255, 191);
            tempItemPanel.BorderStyle = BorderStyle.FixedSingle;
            tempItemPanel.Controls.Add(tempBtnDeleteFromCart);
            tempItemPanel.Controls.Add(tempPanel2);
            tempItemPanel.Controls.Add(tempPanel3);
            //tempItemPanel.Controls.Add(tempLblCostItem);
            //tempItemPanel.Controls.Add(tempLblNameItem);
            tempItemPanel.Controls.Add(tempPictureItem);
            tempItemPanel.Location = new Point(3, 3);
            tempItemPanel.Name = "itemPanel";
            tempItemPanel.Size = new Size(970, 229);
            tempItemPanel.TabIndex = 0;
            // 
            // btnAddToCart
            // 
            tempBtnDeleteFromCart.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            tempBtnDeleteFromCart.FlatAppearance.BorderSize = 2;
            tempBtnDeleteFromCart.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            tempBtnDeleteFromCart.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            tempBtnDeleteFromCart.BackColor = Color.Wheat;
            tempBtnDeleteFromCart.Font = new Font("Segoe UI", 12F);
            tempBtnDeleteFromCart.FlatStyle = FlatStyle.Flat;
            tempBtnDeleteFromCart.Location = new Point(820, 180);
            
            tempBtnDeleteFromCart.Size = new Size(130, 40);
            tempBtnDeleteFromCart.TabIndex = 4;
            tempBtnDeleteFromCart.Text = "Удалить";
            tempBtnDeleteFromCart.UseVisualStyleBackColor = true;
            //tempBtnAddToCart.Click += tempBtnAddToCart_Click;
            string productJson = JsonSerializer.Serialize<Product>(product.Key, new JsonSerializerOptions
            {
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });
            tempBtnDeleteFromCart.Tag = productJson;
            
            // 
            // panel3
            //
            tempPanel3.BackColor = Color.Khaki;
            tempPanel3.BorderStyle = BorderStyle.FixedSingle;
            tempPanel3.Controls.Add(tempLblNameItem);
            tempPanel3.Controls.Add(tempLblCostItem);
            tempPanel3.Location = new Point(160, 9);
            tempPanel3.Name = "panel3";
            tempPanel3.Font = new Font("Segoe UI", 12F);
            tempPanel3.Padding = new Padding(5);
            tempPanel3.Size = new Size(170, 160);


            // 
            // panel2
            // 
            tempPanel2.BackColor = Color.Khaki;
            tempPanel2.BorderStyle = BorderStyle.FixedSingle;
            tempPanel2.Controls.Add(tempLblDescriptionItem);
            tempPanel2.Location = new Point(350, 9);
            tempPanel2.Name = "panel2";
            tempPanel2.Padding = new Padding(5);
            tempPanel2.Size = new Size(600, 160);
            tempPanel2.TabIndex = 3;
            // 
            // lblDescriptionItem
            // 
            tempLblDescriptionItem.BackColor = Color.Ivory;
            tempLblDescriptionItem.Dock = DockStyle.Fill;
            tempLblDescriptionItem.Font = new Font("Segoe UI", 15F);
            tempLblDescriptionItem.Location = new Point(5, 5);
            tempLblDescriptionItem.Name = "lblDescriptionItem";

            tempLblDescriptionItem.TabIndex = 0;
            tempLblDescriptionItem.Text = product.Key.Description;
            // 
            // lblCostItem
            // 
            tempLblCostItem.Location = new Point(0, 128);
            tempLblCostItem.Name = "lblCostItem";
            tempLblCostItem.Size = new Size(110, 23);
            tempLblCostItem.TabIndex = 2;
            tempLblCostItem.Text = product.Key.Price.ToString() + " руб.";
            tempLblCostItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNameItem
            // 
            tempLblNameItem.Location = new Point(0, 10);
            tempLblNameItem.Name = "lblNameItem";
            tempLblNameItem.Size = new Size(170, 70);
            tempLblNameItem.TabIndex = 1;
            tempLblNameItem.Text = product.Key.Name;
            // 
            // itemPicture
            //
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentsView));
            tempPictureItem.ImageLocation = product.Key.ImageSource;
            tempPictureItem.ErrorImage = null;
            tempPictureItem.Location = new Point(0, 0);
            tempPictureItem.Name = "pictureBox1";
            tempPictureItem.Size = new Size(159, 118);
            tempPictureItem.SizeMode = PictureBoxSizeMode.Zoom;
            tempPictureItem.TabIndex = 10;
            tempPictureItem.TabStop = false;
        }
    }
}
