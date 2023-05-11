using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDSalon.Screens
{
    public partial class Login : Form
    {
        Salon salon;
        public Login()
        {
            InitializeComponent();
            salon = Salon.instance;
            loginBtn.Click += (object obj, EventArgs args) =>
            {
                string userName = userNameInput.Text;
                string pass = passwordInput.Text;
                (string result, Customer customer) loginResult = salon.Login(userName, pass);
                if (loginResult.result == Datas.loginComplete)
                {
                    MainScreen.instance.Login();
                    this.Close();
                }
                else
                {
                    errorMessageLabel.Text = loginResult.result;
                }
            };
            registerBtn.Click += (object obj, EventArgs args) =>
            {
                new Register().Show();
                this.Close();
            };
            quitBtn.Click += (object obj, EventArgs args) =>
            {
                this.Close();
            };

        }

    }
}
