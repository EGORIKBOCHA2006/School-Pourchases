using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Pourchases
{
    public partial class LoginView : UserControl
    {
        Container parentContainer;
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-LBTERG7\SQLEXPRESS;Initial Catalog=SchooIItems; Integrated Security=SSPI; TrustServerCertificate=True;");
        public LoginView(Container parentContainer)
        {
            this.parentContainer = parentContainer;
            InitializeComponent();
            typeSchoolCb.SelectedIndex = 1;
        }

        public static void CloseLogining(Container parent)
        {
            parent.contentPanel.Controls.Clear();
            parent.contentPanel.Dock = DockStyle.Right;
            parent.menuPanel.Visible = true;
        }

        private async void Login_Click(object sender, EventArgs e)
        {
            parentContainer.user = new Models.User(0, "DEV", "DEV", "DEV", "DEV");
           CloseLogining(parentContainer);
            return;
            if (schoolTb.Text != "" && responsibleTb.Text != "" && passwordTb.Text != "")
            {

                try
                {
                    await sqlConnection.OpenAsync();
                    SqlParameter sqlParameterSchool = new SqlParameter("@nameSchool", System.Data.SqlDbType.VarChar);
                    SqlParameter sqlParameterPassword = new SqlParameter("@password", System.Data.SqlDbType.VarChar);
                    SqlParameter sqlParameterResponsible = new SqlParameter("@responsible", System.Data.SqlDbType.VarChar);
                    sqlParameterSchool.Value = schoolTb.Text;
                    sqlParameterPassword.Value = passwordTb.Text;
                    sqlParameterResponsible.Value = responsibleTb.Text;
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.Parameters.Add(sqlParameterSchool);
                    sqlCommand.Parameters.Add(sqlParameterPassword);
                    sqlCommand.Parameters.Add(sqlParameterResponsible);
                    sqlCommand.CommandText = "select Users.id, Users.name , Schools.name, TypesSchool.name, TypesUser.name\r\nfrom Users,Schools, TypesSchool, TypesUser\r\nwhere Users.name=@responsible and Users.password=@password and Schools.name=@nameSchool and Users.schoolId=Schools.id and TypesUser.id=Users.typeUser and Schools.typeId=TypesSchool.id\r\n";
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        parentContainer.user = new Models.User((int)reader[0], reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
                        MessageBox.Show(parentContainer.user.TypeSchool + parentContainer.user.TypeUser + parentContainer.user.UserId + parentContainer.user.SchoolName + parentContainer.user.UserName);
                        CloseLogining(parentContainer);
                    }
                    else
                    {
                        MessageBox.Show("Учетная запись не найдена");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlConnection.Close(); }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private async void Register_Click(object sender, EventArgs e)
        {
            if (schoolNameRegTb.Text != "" && passwordRegTb.Text != "" && responsibleRegTb.Text != "")
            {
                try
                {
                    await sqlConnection.OpenAsync();
                    SqlParameter sqlParameterSchool = new SqlParameter("@nameSchool", System.Data.SqlDbType.VarChar);
                    SqlParameter sqlParameterPassword = new SqlParameter("@password", System.Data.SqlDbType.VarChar);
                    SqlParameter sqlParameterResponsible = new SqlParameter("@responsible", System.Data.SqlDbType.VarChar);
                    SqlParameter sqlParameterSchoolType = new SqlParameter("@typeSchool", System.Data.SqlDbType.Int);
                    sqlParameterSchool.Value = schoolNameRegTb.Text;
                    sqlParameterPassword.Value = passwordRegTb.Text;
                    sqlParameterResponsible.Value = responsibleRegTb.Text;
                    sqlParameterSchoolType.Value = typeSchoolCb.SelectedIndex + 1;
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.Parameters.Add(sqlParameterSchool);
                    sqlCommand.Parameters.Add(sqlParameterPassword);
                    sqlCommand.Parameters.Add(sqlParameterResponsible);
                    sqlCommand.Parameters.Add(sqlParameterSchoolType);
                    sqlCommand.CommandText = "select Users.id, Users.name , Schools.name, TypesSchool.name, TypesUser.name\r\nfrom Users,Schools, TypesSchool, TypesUser\r\nwhere Users.name=@responsible and Schools.name=@nameSchool and Schools.typeId=@typeSchool and Users.schoolId=Schools.id and TypesUser.id=Users.typeUser and Schools.typeId=TypesSchool.id\r\n";
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Учетная запись уже существует");
                        reader.Close();
                        sqlConnection.Close();
                    }
                    else
                    {
                        reader.Close();
                        sqlCommand.CommandText = "select id, name from schools where name=@nameSchool and typeId=@typeSchool";
                        reader = sqlCommand.ExecuteReader();
                        SqlParameter sqlParametrIdSchool = new SqlParameter("@schoolId", System.Data.SqlDbType.Int);
                        if (reader.HasRows)
                        {
                            reader.Read();
                            sqlParametrIdSchool.Value = (int)reader[0];
                            sqlCommand.Parameters.Add(sqlParametrIdSchool);
                            reader.Close();
                            sqlCommand.CommandText = "insert into Users(name,password,schoolId, typeUser)  values (@responsible,@password,@schoolId,1)";
                            await sqlCommand.ExecuteNonQueryAsync();
                            sqlCommand.CommandText = "select id from Users where name=@responsible and password=@password";
                            reader = sqlCommand.ExecuteReader();
                            reader.Read();
                            parentContainer.user = new Models.User((int)reader[0], responsibleRegTb.Text, schoolNameRegTb.Text, typeSchoolCb.Text, "Пользователь");
                            sqlConnection.Close();
                            CloseLogining(parentContainer);

                        }

                        else
                        {
                            reader.Close();
                            sqlCommand.CommandText = "insert into schools(name, typeId) values(@nameSchool, @typeSchool)";
                            sqlCommand.ExecuteNonQuery();
                            sqlCommand.CommandText = "select id from schools where name=@nameSchool";
                            reader = sqlCommand.ExecuteReader();
                            reader.Read();
                            sqlParametrIdSchool.Value = (int)reader[0];
                            reader.Close();
                            sqlCommand.Parameters.Add(sqlParametrIdSchool);
                            sqlCommand.CommandText = "insert into Users(name,password,schoolId, typeUser)  values (@responsible,@password,@schoolId,1)";
                            await sqlCommand.ExecuteNonQueryAsync();
                            sqlCommand.CommandText = "select id from Users where name=@responsible and password=@password";
                            reader = sqlCommand.ExecuteReader();
                            reader.Read();
                            parentContainer.user = new Models.User((int)reader[0], responsibleRegTb.Text, schoolNameRegTb.Text, typeSchoolCb.Text, "Пользователь");
                            reader.Close();
                            sqlConnection.Close();
                            CloseLogining(parentContainer);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { sqlConnection.Close(); }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }



        }
    }
}
