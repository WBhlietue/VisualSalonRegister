using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDSalon.Components
{
    public partial class AddOrderView : UserControl
    {
        public AddOrderView(int status)
        {
            InitializeComponent();
            if (status == 1)
            {
                BackColor = Color.LightCoral;
            }
            else if(status == 2){
                BackColor = Color.LightBlue;
            }
            else
            {
                BackColor = Color.Chartreuse;
            }
        }
    }
}
