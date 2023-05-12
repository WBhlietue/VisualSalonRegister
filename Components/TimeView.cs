using System.Threading;
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
    public partial class TimeView : UserControl
    {
        public TimeView(int status, SalonServiceType type)
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
            if (type != null)
            {
                nameLabel.Text = type.name;
                priceLabel.Text = type.price + "";
            }
            else
            {
                nameLabel.Text = "";
                priceLabel.Text = "";
            }
        }
    }
}
