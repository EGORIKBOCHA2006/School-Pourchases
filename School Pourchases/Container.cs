using Microsoft.Data.SqlClient;
using Production;
using School_Pourchases.Models;
namespace School_Pourchases
{



    public partial class Container : Form
    {

        public User User;
        public SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-LBTERG7\SQLEXPRESS;Initial Catalog=SchooIItems; Integrated Security=SSPI; TrustServerCertificate=True;");
        public decimal totalCost = 0;
        public int productCount = 0;

        public Container()
        {

            InitializeComponent();
            menuPanel.Visible = false;
            contentPanel.Dock = DockStyle.Fill;
            LoginView loginView = new LoginView(this);
            loginView.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(loginView);


        }

        private void catalogBtn_Click_1(object sender, EventArgs e)
        {
            catalogBtn.BackColor = Color.FromArgb(255, 192, 128);
            cartBtn.BackColor = Color.Wheat;
            profileBtn.BackColor = Color.Wheat;
            contentPanel.Controls.Clear();
            ComponentsView componentsView = new ComponentsView(this);
            componentsView.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(componentsView);

        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            catalogBtn.BackColor = Color.Wheat;
            cartBtn.BackColor = Color.FromArgb(255, 192, 128);
            profileBtn.BackColor = Color.Wheat;
            contentPanel.Controls.Clear();
            CartView componentsView = new CartView(this);
            componentsView.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(componentsView);
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            catalogBtn.BackColor = Color.Wheat;
            cartBtn.BackColor = Color.Wheat;
            profileBtn.BackColor = Color.FromArgb(255, 192, 128);
            contentPanel.Controls.Clear();
            ProfileView componentsView = new ProfileView(this);
            componentsView.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(componentsView);
        }
        public async Task GetRequiredItems()
        {
            User.RequiredCart.Clear();
            try
            {
                await sqlConnection.OpenAsync();
                SqlParameter typeSchoolParameter = new SqlParameter("@typeSchool", System.Data.SqlDbType.Int);
                typeSchoolParameter.Value = User.TypeSchool;
                string command = "SELECT CommonItems.name, CommonItems.cost, CommonItems.description, " +
                        "CommonItems.imageSource, RequiredItems.count, CommonItems.id " +
                        "FROM CommonItems, RequiredItems " +
                        "WHERE CommonItems.id = RequiredItems.idItem " +
                        "AND RequiredItems.typeSchool = @typeSchool";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.Parameters.Add(typeSchoolParameter);
                using (SqlDataReader reader = await sqlCommand.ExecuteReaderAsync())
                {

                    while (reader.Read())
                    {

                       User.RequiredCart.Add(new Production.Product(reader.GetString(0), reader.GetDecimal(1))
                        { Description = reader.GetString(2), ImageSource = reader.GetString(3), Id = reader.GetInt32(5) }, reader.GetInt32(4));
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();

            }

        }
    }
}
