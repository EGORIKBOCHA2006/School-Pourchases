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
        Dictionary<Product, int> cartOnSaving;
        public CartView(Container parentContainer)
        {
            InitializeComponent();
            this.parentContainer = parentContainer;
            cartOnSaving = this.parentContainer.User.Cart;

            UpdateCartTotals(parentContainer.User.Cart.Count > 0 ? parentContainer.User.Cart : parentContainer.User.RequiredCart);
            if (parentContainer.User.Cart.Count == 0)
            {
                rbRequiredCart.Checked = true;
            }
            LoadItems(parentContainer.User.Cart.Count > 0 ? parentContainer.User.Cart : parentContainer.User.RequiredCart);
        }
        private void LoadItems(Dictionary<Product, int> itemDictinary)
        {
            panelCart.Controls.Clear();
            foreach (var product in itemDictinary)
            {
                PrintItem(product, itemDictinary);

            }
        }

        private void UpdateCartTotals(Dictionary<Product, int> cart)
        {
            parentContainer.productCount = cart.Sum(x => x.Value);
            parentContainer.totalCost = cart.Sum(x => x.Key.Price * x.Value);
            lblCost.Text = parentContainer.totalCost.ToString();
            lblCountItems.Text = parentContainer.productCount.ToString();

            if (cart.Count == 0)
            {
                label3.Text = "Корзина пуста";
                btnMakeCsvFile.Enabled = false;
            }
            else
            {
                label3.Text = "Корзина";
                btnMakeCsvFile.Enabled = true;
            }
        }

        private void PrintItem(KeyValuePair<Product, int> product, Dictionary<Product, int> cart) //НАДО РЕШИТЬ ЧЕРЕЗ ЧТО ОБЪЕКТЫ СЕРЕАЛИЗИРОВАТЬ И НАДО ЛИ
        {

            Panel tempItemPanel = new Panel
            {
                BackColor = Color.FromArgb(251, 255, 191),
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(3, 3),
                Size = new Size(970, 229),
                Padding = new Padding(5)
            };
            PictureBox tempPictureItem = new PictureBox
            {
                ImageLocation = product.Key.ImageSource,
                ErrorImage = null,
                Location = new Point(10, 10),
                Size = new Size(140, 140),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle
            };
            Panel infoPanel = new Panel
            {
                BackColor = Color.Khaki,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(160, 10),
                Size = new Size(170, 140),
                Padding = new Padding(5)
            };
            Label tempLblNameItem = new Label
            {
                Text = product.Key.Name,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                Dock = DockStyle.Top,
                Height = 50
            };
            Label tempLblCostItem = new Label
            {
                Text = $"{product.Key.Price} руб.",
                Font = new Font("Segoe UI", 12F),
                Dock = DockStyle.Bottom,
                Height = 30,
                TextAlign = ContentAlignment.MiddleLeft
            };

            Panel descPanel = new Panel
            {
                BackColor = Color.Khaki,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(350, 10),
                Size = new Size(400, 140),
                Padding = new Padding(5)
            };
            Label tempLblDescriptionItem = new Label
            {
                Text = product.Key.Description,
                Font = new Font("Segoe UI", 11F),
                Dock = DockStyle.Fill,
                BackColor = Color.Ivory
            };
            Panel quantityPanel = new Panel
            {
                BackColor = Color.Khaki,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(770, 10),
                Size = new Size(180, 140),
                Padding = new Padding(5)
            };
            Label quantityLabel = new Label
            {
                Text = "Количество:",
                Font = new Font("Segoe UI", 10F),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter
            };

            NumericUpDown quantitySelector = new NumericUpDown
            {
                Minimum = 1,
                Maximum = 100,
                Value = product.Value,
                Font = new Font("Segoe UI", 12F),
                Dock = DockStyle.Top,
                Height = 40,
                TextAlign = HorizontalAlignment.Center,
                BackColor = Color.White
            };
            quantitySelector.ValueChanged += (sender, e) =>
            {
                cart[product.Key] = (int)quantitySelector.Value;
                UpdateCartTotals(cart);
            };
            // Кнопка удаления
            Button tempBtnDeleteFromCart = new Button
            {
                Text = "Удалить",
                BackColor = Color.FromArgb(255, 128, 128),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 12F),
                Location = new Point(820, 180),
                Size = new Size(130, 40),
                Cursor = Cursors.Hand

            };

            // Настройка внешнего вида кнопки
            tempBtnDeleteFromCart.FlatAppearance.BorderColor = Color.FromArgb(200, 0, 0);
            tempBtnDeleteFromCart.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 160, 160);
            tempBtnDeleteFromCart.FlatAppearance.MouseDownBackColor = Color.FromArgb(220, 80, 80);

            // Сохраняем продукт в Tag кнопки
            tempBtnDeleteFromCart.Tag = product.Key;
            tempBtnDeleteFromCart.Click += (sender, e) =>
            {
                cart.Remove(tempBtnDeleteFromCart.Tag as Product);
                UpdateCartTotals(cart);
                panelCart.Controls.Remove(tempItemPanel);
            };

            // Добавляем элементы управления
            infoPanel.Controls.Add(tempLblNameItem);
            infoPanel.Controls.Add(tempLblCostItem);

            descPanel.Controls.Add(tempLblDescriptionItem);

            quantityPanel.Controls.Add(quantityLabel);
            quantityPanel.Controls.Add(quantitySelector);

            tempItemPanel.Controls.Add(tempPictureItem);
            tempItemPanel.Controls.Add(infoPanel);
            tempItemPanel.Controls.Add(descPanel);
            tempItemPanel.Controls.Add(quantityPanel);
            tempItemPanel.Controls.Add(tempBtnDeleteFromCart);

            panelCart.Controls.Add(tempItemPanel);
        }

        private void btnMakeCsvFile_Click(object sender, EventArgs e)
        {
            // Создаем и настраиваем диалог сохранения файла
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.FileName = "Товары на закупку " + DateTime.Now.ToString("yyyyMMdd") + ".csv";
                saveFileDialog.DefaultExt = ".csv";
                saveFileDialog.AddExtension = true;

                // Показываем диалог и проверяем, что пользователь выбрал файл
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Получаем данные для экспорта (пример)

                        // Создаем CSV содержимое
                        StringBuilder csvContent = new StringBuilder();

                        // Добавляем заголовки (пример)
                        csvContent.AppendLine("Товар\tПримерная цена руб.\tКоличество\tВсего руб.");

                        // Добавляем данные
                        foreach (KeyValuePair<Product, int> itemInfo in cartOnSaving)
                        {
                            // Экранируем специальные символы и формируем строку
                            csvContent.AppendLine($"{itemInfo.Key.Name}\t" +
                                $"{itemInfo.Key.Price}\t" +
                                $"{itemInfo.Value}\t" +
                                $"{itemInfo.Value * itemInfo.Key.Price}");
                        }
                        csvContent.AppendLine($"Итого руб.\t{parentContainer.totalCost}");
                        // Записываем в файл
                        File.WriteAllText(saveFileDialog.FileName, csvContent.ToString(), Encoding.Unicode);

                        MessageBox.Show("Файл успешно экспортирован!", "Экспорт завершен",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при экспорте: {ex.Message}", "Ошибка",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void rbOwnCart_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOwnCart.Checked)
            {
                LoadItems(parentContainer.User.Cart);
                cartOnSaving = parentContainer.User.Cart;
            }
            else
            {
                LoadItems(parentContainer.User.RequiredCart);
                cartOnSaving = parentContainer.User.RequiredCart;
            }
            UpdateCartTotals(rbOwnCart.Checked ? parentContainer.User.Cart : parentContainer.User.RequiredCart);
        }

        private async void btnRefreshRequired_Click(object sender, EventArgs e)
        {
            await parentContainer.GetRequiredItems();
            LoadItems(parentContainer.User.RequiredCart);
            UpdateCartTotals(parentContainer.User.RequiredCart);
            rbRequiredCart.Checked = true;
        }
    }
}
