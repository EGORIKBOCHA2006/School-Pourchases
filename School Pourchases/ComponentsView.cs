using Microsoft.Data.SqlClient;
using Production;
using School_Pourchases.Models;
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
        private int selectedTextSortType=0;
        
            

        private List<Product> GetProductsFromDatabase()
        {
            List<Product> products = new List<Product>();


            parentContainer.sqlConnection.Open();

            string orderBystring = " ";
            string sortByString = " and TypesProducts.Id=@Type";
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
            SqlParameter sortByParametr = new SqlParameter("@Type", System.Data.SqlDbType.Int);

            SqlCommand command = new SqlCommand("SELECT CommonItems.Id, CommonItems.name, typeId, cost,  description, imageSource, TypesProducts.name FROM CommonItems, TypesProducts where TypesProducts.id=typeId  " + ((selectedTextSortType == sortTypeCb.Items.Count) ? " " : sortByString + " ") + orderBystring, parentContainer.sqlConnection);
            command.Parameters.Add(sortByParametr);

            sortByParametr.Value = selectedTextSortType;
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


      
        private void UpdateCartTotals()
        {
            parentContainer.productCount = parentContainer.User.Cart.Sum(x => x.Value);
            parentContainer.totalCost = parentContainer.User.Cart.Sum(x => x.Key.Price * x.Value);
            lblCost.Text = parentContainer.totalCost.ToString();
            lblCountItems.Text = parentContainer.productCount.ToString();
        }

        private void PrintItem(Product product)
        {
            // Основная панель товара (сохраняем оригинальное название tempItemPanel)
            Panel itemPanel = new Panel
            {
                BackColor = Color.FromArgb(251, 255, 191),
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(3, 3),
                Size = new Size(970, 229),
                Padding = new Padding(5)
            };

            // Картинка товара (tempPictureItem)
            PictureBox pictureItem = new PictureBox
            {
                ImageLocation = product.ImageSource,
                ErrorImage = null,
                Location = new Point(10, 10),
                Size = new Size(140, 140),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Панель с основной информацией (tempPanel3)
            Panel infoPanel = new Panel
            {
                BackColor = Color.Khaki,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(160, 10),
                Size = new Size(170, 140),
                Padding = new Padding(5)
            };

            // Название товара (tempLblNameItem)
            Label lblNameItem = new Label
            {
                Text = product.Name,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                Dock = DockStyle.Top,
                Height = 50,
                TextAlign = ContentAlignment.MiddleLeft
            };

            // Цена товара (tempLblCostItem)
            Label lblCostItem = new Label
            {
                Text = $"{product.Price} руб.",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                Dock = DockStyle.Bottom,
                Height = 30,
                ForeColor = Color.DarkGreen,
                TextAlign = ContentAlignment.MiddleLeft
            };

            // Панель с описанием (tempPanel2)
            Panel descPanel = new Panel
            {
                BackColor = Color.Khaki,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(350, 10),
                Size = new Size(600, 140),
                Padding = new Padding(5)
            };

            // Описание товара (tempLblDescriptionItem)
            RichTextBox lblDescriptionItem = new RichTextBox
            {
                Text = product.Description,
                ReadOnly = true,
                Font = new Font("Segoe UI", 11F),
                Dock = DockStyle.Fill,
                BackColor = Color.Ivory,
                Padding = new Padding(5)
            };

            // Кнопка добавления/удаления (tempBtnAddToCart)
            Button btnAddToCart = new Button
            {
                Font = new Font("Segoe UI", 12F),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(820, 180),
                Size = new Size(130, 40),
                Cursor = Cursors.Hand,
                Tag = product // Сохраняем продукт в Tag
            };

            // Настройка кнопки в зависимости от состояния корзины
            if (!parentContainer.User.Cart.ContainsKey(product))
            {
                btnAddToCart.Text = "Добавить";
                btnAddToCart.BackColor = Color.Wheat;
                btnAddToCart.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
                btnAddToCart.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
                btnAddToCart.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
                btnAddToCart.Click += tempBtnAddToCart_Click;

            }
            else
            {
                btnAddToCart.Text = "Удалить";
                btnAddToCart.BackColor = Color.FromArgb(255, 128, 128);
                btnAddToCart.FlatAppearance.BorderColor = Color.FromArgb(200, 0, 0);
                btnAddToCart.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 160, 160);
                btnAddToCart.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 80, 80);
                btnAddToCart.Click += tempBtnAddToCartDelete_Click;
            }

            // Добавляем элементы на панели (сохраняем оригинальную структуру)
            infoPanel.Controls.Add(lblNameItem);
            infoPanel.Controls.Add(lblCostItem);

            descPanel.Controls.Add(lblDescriptionItem);

            itemPanel.Controls.Add(pictureItem);
            itemPanel.Controls.Add(infoPanel);
            itemPanel.Controls.Add(descPanel);
            itemPanel.Controls.Add(btnAddToCart);

            // Добавляем на основную панель
            panelCatalog.Controls.Add(itemPanel);
        }
        Container parentContainer;
        public ComponentsView(Container parentContainer)
        {
            InitializeComponent();
            this.parentContainer = parentContainer;
            selectedTextSortType=sortTypeCb.Items.Count;
            lblNameUser.Text = parentContainer.User.UserName;
            lblSchoolName.Text = parentContainer.User.SchoolName;
            UpdateCartTotals();
            LoadItemsAsync();
            OrderByCb.SelectedIndex = 0;
            sortTypeCb.SelectedIndex =sortTypeCb.Items.Count-1;
            OrderByCb.SelectedIndexChanged += OrderByCb_SelectedIndexChanged;
            sortTypeCb.SelectedIndexChanged += sortTypeCb_SelectedIndexChanged;

        }

        private async void sortTypeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTextSortType = sortTypeCb.SelectedIndex+1;
            
            await LoadItemsAsync();

        }

        private async void OrderByCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndexOrderBy = OrderByCb.SelectedIndex;
            await LoadItemsAsync();
        }
        private void tempBtnAddToCart_Click(object sender, EventArgs e)
        {
            Product product = (((Control)sender) as Button).Tag as Product;
            parentContainer.User.Cart.Add(product, 1);
            MessageBox.Show("Товар добавлен в корзину");
            UpdateCartTotals();
            (((Control)sender) as Button).Text = "Удалить";
            (((Control)sender) as Button).BackColor = Color.LightGreen;
            (((Control)sender) as Button).FlatAppearance.MouseOverBackColor = Color.Red;
            (((Control)sender) as Button).Click -= tempBtnAddToCart_Click;
            (((Control)sender) as Button).Click += tempBtnAddToCartDelete_Click;
        }
        private void tempBtnAddToCartDelete_Click(object sender, EventArgs e)
        {
            Product product = (((Control)sender) as Button).Tag as Product;
            parentContainer.User.Cart.Remove(product);
            MessageBox.Show("Товар удален из корзины");
            UpdateCartTotals();
            (((Control)sender) as Button).Text = "Добавить";
            (((Control)sender) as Button).FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            (((Control)sender) as Button).FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            (((Control)sender) as Button).BackColor = Color.Wheat;
            (((Control)sender) as Button).Click -= tempBtnAddToCartDelete_Click;
            (((Control)sender) as Button).Click += tempBtnAddToCart_Click;
        }
    }
}
