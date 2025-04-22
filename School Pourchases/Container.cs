using System.Security.Cryptography.X509Certificates;
using School_Pourchases.Models;
namespace School_Pourchases
{


    public partial class Container : Form
    {


        public User appUser= new User();
        public Container()
        {
            
            InitializeComponent();
            menuPanel.Visible = false;
            contentPanel.Dock = DockStyle.Fill;
            LoginView loginView = new LoginView(this);
            loginView.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(loginView);
        
            
        }
    }
}
