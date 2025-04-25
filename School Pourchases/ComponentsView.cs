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
        public ComponentsView()
        {
            InitializeComponent();
          
            panelCatalog.AutoScroll = true;
            for (int i=0;i<10;i++)
            {
                Panel panel = new Panel
                {
                    BackColor = Color.Red,
                    Size = new Size(200, 100),
                    
                    Margin = new Padding(0, 0, 0, 10) // Отступ снизу 10px
                };

                Label label = new Label { Text = $"Панель {i + 1}", AutoSize = true };
                panel.Controls.Add(label);

                panelCatalog.Controls.Add(panel);
            }
     
        }
    }
}
