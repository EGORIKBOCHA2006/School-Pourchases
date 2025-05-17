using Microsoft.Data.SqlClient;
using Production;
using School_Pourchases.Properties;
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
    public partial class ComponentsView : UserControl
    {

        private int selectedIndexOrderBy = 0;
        private string selectedTextSortType = "все товары";
        private List<Product> GetProductsFromDatabase()
        {
            List<Product> products = new List<Product>();


            parentContainer.sqlConnection.Open();

            string orderBystring = " ";
            string sortByString = " and TypesProducts.name=@Type";
            switch (selectedIndexOrderBy)
            {
                case 0:
                    orderBystring = "order by cost asc";
                    break;
                case 1:
                    orderBystring = "order by cost desc";
                    break;
                case 2:
                    break;
            }
            SqlParameter sortByParametr = new SqlParameter("@Type", System.Data.SqlDbType.NVarChar);

            SqlCommand command = new SqlCommand("SELECT CommonItems.Id, CommonItems.name, typeId, cost,  description, imageSource, TypesProducts.name FROM CommonItems, TypesProducts where TypesProducts.id=typeId  " + ((selectedTextSortType == "все товары") ? " " : sortByString + " ") + orderBystring, parentContainer.sqlConnection);
            command.Parameters.Add(sortByParametr);

            sortByParametr.Value = selectedTextSortType.ToLower();
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    products.Add(new Product(reader.GetString(1), reader.GetDecimal(3)) { Id = reader.GetInt32(0), IdType = reader.GetInt32(2), Description = reader.GetString(4), ImageSource = reader.GetString(5) });

                }
            }

            parentContainer.sqlConnection.Close();

            return products;
        }

        private async Task LoadItemsAsync()
        {
            panelCatalog.Controls.Clear();
            var products = await Task.Run(() => GetProductsFromDatabase());

            foreach (var product in products)
            {
                PrintItem(product);

            }
        }


        private void PrintItem(Product product) //НАДО РЕШИТЬ ЧЕРЕЗ ЧТО ОБЪЕКТЫ СЕРЕАЛИЗИРОВАТЬ И НАДО ЛИ
        {

            // 
            // itemPanel
            // 
            Panel tempItemPanel = new Panel();
            Button tempBtnAddToCart = new Button();
            Panel tempPanel2 = new Panel();
            Panel tempPanel3 = new Panel();
            Label tempLblDescriptionItem = new Label();
            Label tempLblCostItem = new Label();
            Label tempLblNameItem = new Label();
            Label tempLblTypeItem = new Label();
            PictureBox tempPictureItem = new PictureBox();
            panelCatalog.Controls.Add(tempItemPanel);
            tempItemPanel.BackColor = Color.FromArgb(251, 255, 191);
            tempItemPanel.BorderStyle = BorderStyle.FixedSingle;
            tempItemPanel.Controls.Add(tempBtnAddToCart);
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
            tempBtnAddToCart.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            tempBtnAddToCart.FlatAppearance.BorderSize = 2;
            tempBtnAddToCart.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            tempBtnAddToCart.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            tempBtnAddToCart.BackColor = Color.Wheat;
            tempBtnAddToCart.Font = new Font("Segoe UI", 12F);
            tempBtnAddToCart.FlatStyle = FlatStyle.Flat;
            tempBtnAddToCart.Location = new Point(820, 180);
            tempBtnAddToCart.Name = "btnAddToCart";
            tempBtnAddToCart.Size = new Size(130, 40);
            tempBtnAddToCart.TabIndex = 4;
            tempBtnAddToCart.Text = "Добавить";
            tempBtnAddToCart.UseVisualStyleBackColor = true;

            tempBtnAddToCart.Click += tempBtnAddToCart_Click;
            string productJson = JsonSerializer.Serialize<Product>(product, new JsonSerializerOptions
            {
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });
            tempBtnAddToCart.Tag = productJson;
            MessageBox.Show(productJson);
            // 
            // panel3
            //
            tempPanel3.BackColor = Color.Khaki;
            tempPanel3.BorderStyle = BorderStyle.FixedSingle;
            tempPanel3.Controls.Add(tempLblNameItem);
            tempPanel3.Controls.Add(tempLblCostItem);
            tempPanel3.Location = new Point(160, 9);
            tempPanel3.Name = "panel3";
            tempPanel3.Font= new Font("Segoe UI", 12F);
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
            tempLblDescriptionItem.Text = product.Description;
            // 
            // lblCostItem
            // 
            tempLblCostItem.Location = new Point(0, 128);
            tempLblCostItem.Name = "lblCostItem";
            tempLblCostItem.Size = new Size(110, 23);
            tempLblCostItem.TabIndex = 2;
            tempLblCostItem.Text = product.Price.ToString() + " руб.";
            tempLblCostItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNameItem
            // 
            tempLblNameItem.Location = new Point(0, 10);
            tempLblNameItem.Name = "lblNameItem";
            tempLblNameItem.Size = new Size(170, 70);
            tempLblNameItem.TabIndex = 1;
            tempLblNameItem.Text = product.Name;
            // 
            // itemPicture
            //
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentsView));
            tempPictureItem.ImageLocation = product.ImageSource;
            tempPictureItem.ErrorImage = null;
            tempPictureItem.Location = new Point(0, 0);
            tempPictureItem.Name = "pictureBox1";
            tempPictureItem.Size = new Size(159, 118);
            tempPictureItem.SizeMode = PictureBoxSizeMode.Zoom;
            tempPictureItem.TabIndex = 10;
            tempPictureItem.TabStop = false;
        }
        Container parentContainer;
        public ComponentsView(Container parentContainer)
        {
            InitializeComponent();
            this.parentContainer = parentContainer;
            
            lblNameUser.Text = parentContainer.user.UserName;
            lblSchoolName.Text = parentContainer.user.SchoolName;
            LoadItemsAsync();
            OrderByCb.SelectedIndex = 0;
            sortTypeCb.SelectedIndex = sortTypeCb.Items.Count-1;
            OrderByCb.SelectedIndexChanged += OrderByCb_SelectedIndexChanged;
            sortTypeCb.SelectedIndexChanged += sortTypeCb_SelectedIndexChanged;

        }

        private async void sortTypeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTextSortType = sortTypeCb.SelectedItem.ToString().ToLower();
            MessageBox.Show(selectedTextSortType);
            await LoadItemsAsync();

        }

        private async void OrderByCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndexOrderBy=OrderByCb.SelectedIndex;
            await LoadItemsAsync();
        }
        private void tempBtnAddToCart_Click(object sender, EventArgs e)
        {
            string productJson = ((Control)sender).Tag as string;
            Product product = JsonSerializer.Deserialize<Product>(productJson);
            parentContainer.user.cart.Add(product, 1);
            MessageBox.Show("Товар добавлен в корзину");
            (((Control)sender) as Button).Text = "Удалить";
            (((Control)sender) as Button).BackColor = Color.LightGreen;
            (((Control)sender) as Button).FlatAppearance.MouseOverBackColor = Color.Red;
            (((Control)sender) as Button).Click -= tempBtnAddToCart_Click;
            (((Control)sender) as Button).Click += tempBtnAddToCartDelete_Click;
        }
        private void tempBtnAddToCartDelete_Click(object sender, EventArgs e)
        {
            string productJson = ((Control)sender).Tag as string;
            Product product = JsonSerializer.Deserialize<Product>(productJson);
            parentContainer.user.cart.Remove(product);
            MessageBox.Show("Товар удален из корзины");
            (((Control)sender) as Button).Text = "Добавить";
            (((Control)sender) as Button).FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            (((Control)sender) as Button).BackColor = Color.Wheat;
            (((Control)sender) as Button).Click -= tempBtnAddToCartDelete_Click;
            (((Control)sender) as Button).Click += tempBtnAddToCart_Click;
        }
    }
}
