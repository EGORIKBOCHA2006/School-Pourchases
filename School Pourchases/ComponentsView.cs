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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Pourchases
{
    public partial class ComponentsView : UserControl
    {

        private int selectedIndexOrderBy = 0;
        private int selectedIndexSortBy = 0;
        private List<Product> GetProductsFromDatabase()
        {
            List<Product> products = new List<Product>();


            parentContainer.sqlConnection.Open();
            string orderBystring = " ";
            string sortByString = " and typeId=@idType";
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
            SqlParameter sortByParametr = new SqlParameter("@idType", System.Data.SqlDbType.Int);

            SqlCommand command = new SqlCommand("SELECT CommonItems.Id, CommonItems.name, typeId, cost,  description, imageSource, TypesProducts.name FROM CommonItems, TypesProducts where TypesProducts.id=typeId  " + ((sortTypeCb.SelectedText == "Все товары") ? " " : sortByString + " ") + orderBystring, parentContainer.sqlConnection);
            command.Parameters.Add(sortByParametr);
            sortByParametr.Value = selectedIndexSortBy;
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
            Label tempLblDescriptionItem = new Label();
            Label tempLblCostItem = new Label();
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
            tempItemPanel.Size = new Size(632, 129);
            tempItemPanel.TabIndex = 0;
            // 
            // btnAddToCart
            // 
            tempBtnAddToCart.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            tempBtnAddToCart.FlatAppearance.BorderSize = 2;
            tempBtnAddToCart.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            tempBtnAddToCart.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            tempBtnAddToCart.BackColor = Color.Wheat;
            tempBtnAddToCart.FlatStyle = FlatStyle.Flat;
            tempBtnAddToCart.Location = new Point(520, 98);
            tempBtnAddToCart.Name = "btnAddToCart";
            tempBtnAddToCart.Size = new Size(80, 26);
            tempBtnAddToCart.TabIndex = 4;
            tempBtnAddToCart.Text = "Добавить";
            tempBtnAddToCart.UseVisualStyleBackColor = true;

            // 
            // panel2
            // 
            tempPanel2.BackColor = Color.Khaki;
            tempPanel2.BorderStyle = BorderStyle.FixedSingle;
            tempPanel2.Controls.Add(tempLblDescriptionItem);
            tempPanel2.Location = new Point(300, 9);
            tempPanel2.Name = "panel2";
            tempPanel2.Padding = new Padding(5);
            tempPanel2.Size = new Size(300, 82);
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
            tempLblDescriptionItem.Text = product.Description;
            // 
            // lblCostItem
            // 
            tempLblCostItem.Location = new Point(142, 63);
            tempLblCostItem.Name = "lblCostItem";
            tempLblCostItem.Size = new Size(110, 23);
            tempLblCostItem.TabIndex = 2;
            tempLblCostItem.Text = product.Price.ToString() + " руб.";
            tempLblCostItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNameItem
            // 
            tempLblNameItem.Location = new Point(142, 10);
            tempLblNameItem.Name = "lblNameItem";
            tempLblNameItem.Size = new Size(110, 53);
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
            OrderByCb.SelectedIndex = 0;
            sortTypeCb.SelectedIndex = 0;
            lblNameUser.Text = parentContainer.user.UserName;
            lblSchoolName.Text = parentContainer.user.SchoolName;
            LoadItemsAsync();
        }

        private void sortTypeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndexSortBy = sortTypeCb.SelectedIndex;

        }

        private void OrderByCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndexOrderBy=OrderByCb.SelectedIndex;
        }
    }
}
