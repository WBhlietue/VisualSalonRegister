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
    public partial class HeaderNonLogin : UserControl
    {
        public HeaderNonLogin()
        {
            InitializeComponent();
            loginBtn.Click += (object o, EventArgs e) =>
            {
                new Login().Show();
            };
            registerBtn.Click += (object o, EventArgs e) =>
            {
                new Register().Show();
            };
        }
    }
}
