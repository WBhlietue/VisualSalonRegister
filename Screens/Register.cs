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
    public partial class Register : Form
    {
        Salon salon;
        public Register()
        {
            salon = Salon.instance;
            InitializeComponent();
            quitBtn.Click += (object o, EventArgs e) =>
            {
                this.Close();
            };
            registerBtn.Click += (object o, EventArgs e) =>
            {
                string email = emailInput.Text;
                string pass = passInput.Text;
                string fname = firstInpupt.Text;
                string lname = lastInput.Text;
                int age = int.Parse(ageInput.Text);
                int phone = int.Parse(phoneInput.Text);
                Customer cus = new Customer(email, pass, fname, lname, age, phone);
                string result = salon.Register(cus);
                if(result == Datas.registerComplete){
                    MainScreen.instance.Login();
                    this.Close();
                }else{
                    MessageBox.Show(result);
                }
            };
            loginBtn.Click += (object o, EventArgs e) =>
            {
                new Login().Show();
                this.Close();
            };
        }
    }
}

// (object o, EventArgs e) =>{};