using System.Security.Cryptography.X509Certificates;
using School_Pourchases.Models;
namespace School_Pourchases
{

    

    public partial class Container : Form
    {

        public User user;
        
        public Container()
        {
            
            InitializeComponent();
            menuPanel.Visible = false;
            contentPanel.Dock = DockStyle.Fill;
            LoginView loginView = new LoginView(this);
            loginView.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(loginView);


        }
        private void caralogBtn_Click_1(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            ComponentsView componentsView = new ComponentsView(this);
            componentsView.Dock= DockStyle.Fill;
            contentPanel.Controls.Add(componentsView);
            
        }
    }
}
