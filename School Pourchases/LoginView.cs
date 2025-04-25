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
    public partial class LoginView : UserControl
    {
        Container parentContainer;
        public LoginView(Container parentContainer)
        {
            this.parentContainer = parentContainer;
            InitializeComponent();
        }



        private void Login_Click(object sender, EventArgs e)
        {
            if (true)
            {
                parentContainer.appUser.SchoolName = schoolTb.Text;
                parentContainer.contentPanel.Controls.Clear();
                parentContainer.contentPanel.Dock = DockStyle.Right;
                parentContainer.menuPanel.Visible = true;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Заполните поля","Ошибка",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (true)
            {
                parentContainer.appUser.SchoolName = schoolTb.Text;
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
