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
        }



        private async void Login_Click(object sender, EventArgs e)
        {
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

                        parentContainer.contentPanel.Controls.Clear();
                        parentContainer.contentPanel.Dock = DockStyle.Right;
                        parentContainer.menuPanel.Visible = true;
                        this.Dispose();
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

                if (true)
                {

                }
                else
                {
                    MessageBox.Show("Заполните поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (true)
            {
                
                parentContainer.contentPanel.Controls.Clear();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Заполните поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
