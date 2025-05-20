using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace School_Pourchases
{
    public partial class ProfileView : UserControl
    {
        Container parentContainer;
        public ProfileView(Container parentContainer)
        {
            InitializeComponent();
            this.parentContainer = parentContainer;
        }

        private async void registerBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(responsibleRegTb.Text) ||
        string.IsNullOrEmpty(passwordRegTb.Text) ||
        typeSchoolCb.SelectedIndex < 0)
            {
                MessageBox.Show("Заполните все обязательные поля!");
                return;
            }

           
                
                    await parentContainer.sqlConnection.OpenAsync();

            // Начинаем транзакцию для обеспечения целостности данных
            using (SqlTransaction transaction = parentContainer.sqlConnection.BeginTransaction())
            {
                try
                {

                    // 1. Обновляем данные школы
                    string updateSchoolQuery = @"
                        UPDATE Schools 
                        SET 
                            typeId = @typeId 
                        WHERE id = @schoolId";

                    using (SqlCommand schoolCmd = new SqlCommand(updateSchoolQuery, parentContainer.sqlConnection, transaction))
                    {

                        schoolCmd.Parameters.AddWithValue("@typeId", typeSchoolCb.SelectedIndex + 1);
                        schoolCmd.Parameters.AddWithValue("@schoolId", parentContainer.User.UserId);

                        await schoolCmd.ExecuteNonQueryAsync();
                    }

                    // 2. Обновляем данные пользователя
                    string updateUserQuery = @"
                        UPDATE Users 
                        SET name = @userName, 
                            password = @password 
                        WHERE id = @userId";

                    using (SqlCommand userCmd = new SqlCommand(updateUserQuery, parentContainer.sqlConnection, transaction))
                    {
                        userCmd.Parameters.AddWithValue("@userName", responsibleRegTb.Text);
                        userCmd.Parameters.AddWithValue("@password", passwordRegTb.Text);
                        userCmd.Parameters.AddWithValue("@userId", parentContainer.User.UserId);

                        await userCmd.ExecuteNonQueryAsync();
                    }

                    // Если все успешно - коммитим транзакцию
                    transaction.Commit();

                    // Обновляем данные в приложении
                    parentContainer.User.UserName = responsibleRegTb.Text;
                    parentContainer.User.TypeSchool = typeSchoolCb.SelectedIndex + 1;


                    MessageBox.Show("Данные успешно обновлены!");

                }

                catch (Exception ex)
                {
                    // Откатываем транзакцию при ошибке
                    transaction.Rollback();
                    MessageBox.Show($"Ошибка при обновлении данных: {ex.Message}");
                }
                finally
                {
                    parentContainer.sqlConnection.Close();
                    parentContainer.GetRequiredItems();
                }

            }
                
            
            
        }
    }
}
