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
    public partial class CustomerPage : UserControl
    {
        public CustomerPage()
        {
            InitializeComponent();
            Top = 75;
            RefreshData();
        }
        public void RefreshData()
        {
            flowLayoutPanel1.Controls.Clear();
            List<Customer> cus = Salon.instance.GetAlllCustomer();
            CustomerView top = new CustomerView();
            top.nameLabel.Text = "Name";
            top.emailLabel.Text = "Email";
            top.ageText.Text = "Age";
            top.phoneText.Text = "Phone";
            top.delBtn.Hide();
            flowLayoutPanel1.Controls.Add(top);

            for (int i = 0; i < cus.Count; i++)
            {
                CustomerView view = new CustomerView();
                view.nameLabel.Text = cus[i].firstName + " " + cus[i].lastName;
                view.emailLabel.Text = cus[i].email;
                view.ageText.Text = cus[i].age.ToString();
                view.phoneText.Text = cus[i].phone.ToString();
                int a = i;
                view.delBtn.Click += (object o, EventArgs e) =>
                {
                    Salon.instance.DeleteUserFormAdmin(cus[a].email);
                    RefreshData();
                };
                flowLayoutPanel1.Controls.Add(view);
            }
        }
    }
}
