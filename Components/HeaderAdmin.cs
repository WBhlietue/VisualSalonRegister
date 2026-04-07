using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDSalon.Screens;

namespace BDSalon.Components
{
    public partial class HeaderAdmin : UserControl
    {
        public HeaderAdmin()
        {
            InitializeComponent();
             homeBtn.Click += (object o, EventArgs e) =>
            {
                MainScreen.instance.SwitchToHome();
            };
            orderBtn.Click += (object o, EventArgs e) =>
            {
                MainScreen.instance.SwitchToOrder();
            };
            logoutBtn.Click += (object o, EventArgs e) =>
            {
                MainScreen.instance.Logout();
            };
            customersBtn.Click += (object o, EventArgs e) =>
            {
                MainScreen.instance.SwitchToCustomer();
            };
        }
        public void Set()
        {
            nameLabel.Text = Salon.customer.firstName;
        }
    }
}
