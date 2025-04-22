namespace School_Pourchases
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
            LoginView loginView = new LoginView();
            loginView.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(loginView);
        
            
        }
    }
}
