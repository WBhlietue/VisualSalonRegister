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
    public partial class OrderPage : UserControl
    {
        Salon salon;
        bool viewAll = true;
        bool viewCusAll = true;
        bool isHide = true;
        List<Order> orders;
        public OrderPage()
        {
            salon = Salon.instance;
            InitializeComponent();

            stateSelect.SelectedIndex = 0;
            viewAllBtn.Click += (object o, EventArgs e) =>
            {
                viewAll = true;
                RefreshData();
            };

            datePicker.ValueChanged += (object o, EventArgs e) =>
            {
                viewAll = false;
                RefreshData();
            };
            addBtn.Click += (object o, EventArgs e) =>
            {
                new AddOrder().Show();
            };
            stateSelect.SelectedValueChanged += (object o, EventArgs e) =>
            {
                SetData();
            };
            viewCustomerBtn.Click += (object o, EventArgs e) =>
            {
                viewCusAll = true;
                RefreshData();
            };
            customerSelect.SelectedIndexChanged += (object o, EventArgs e) =>
            {
                viewCusAll = false;
                RefreshData();
            };


            Top = 75;
        }
        public void RefreshData()
        {
            if (!salon.isAdmin)
            {
                if (viewAll)
                {
                    orders = salon.GetAllOrderForCustomer();
                }
                else
                {
                    DateTime time = datePicker.Value;
                    string date = time.Year + "." + (time.Month < 10 ? "0" : "") + time.Month + "." + (time.Day < 10 ? "0" : "") + time.Day;

                    orders = salon.GetAllOrderForCustomerInDay(date);
                }
            }
            else
            {
                if (viewAll)
                {
                    if (viewCusAll)
                    {
                        orders = salon.GetAllOrderForAllCustomerForAdmin();
                    }
                    else
                    {
                        orders = salon.GetAllOrderForCustomerForAdmin(customerSelect.SelectedItem + "");
                    }
                }
                else
                {
                    DateTime time = datePicker.Value;
                    string date = time.Year + "." + (time.Month < 10 ? "0" : "") + time.Month + "." + (time.Day < 10 ? "0" : "") + time.Day;
                    if (viewCusAll)
                    {
                        orders = salon.GetAllOrderForAllCustomerForAdminInDay(date);
                    }
                    else
                    {
                        orders = salon.GetAllOrderForCustomerForAdminInDay(customerSelect.SelectedItem + "", date);
                    }
                }
            }

            SetData();
        }
        void SetData()
        {
            if (!Salon.instance.isAdmin)
            {
                customerSelect.Hide();
                viewCustomerBtn.Hide();
                isHide = true;
            }
            else
            {
                if (isHide)
                {
                    isHide = false;
                    customerSelect.Show();
                    viewCustomerBtn.Show();
                    List<Customer> cus = salon.GetAlllCustomer();
                    customerSelect.Items.Clear();
                    foreach (var item in cus)
                    {
                        customerSelect.Items.Add(item.email);
                    }
                }
            }
            int num = stateSelect.SelectedIndex;
            flow.Controls.Clear();
            foreach (var item in orders)
            {
                if (num == 0)
                {

                }
                else if (num == 1)
                {
                    if (item.progress == 1)
                    {
                        continue;
                    }
                }
                else
                {
                    if (item.progress == 0)
                    {
                        continue;
                    }
                }
                OrderView view = new OrderView();
                if(!salon.isAdmin){
                    view.Height /= 2;
                    view.editBtn.Hide();
                    view.emailLabel.Hide();
                }else{
                    view.emailLabel.Text = item.email;
                }
                view.orderDateLabel.Text = item.date;
                view.orderTimeLabel.Text = item.time + "";
                view.orderTypeLabel.Text = Datas.serviceType[item.type].name;
                view.orderProgressLabel.Text = (item.progress == 1 ? "completed" : "onGoing");
                view.orderPriceLabel.Text = Datas.serviceType[item.type].price + "₮";
                var a = item;
                view.deleteBtn.Click += (object o, EventArgs e) =>
                {
                    string result = salon.RemoveOrder(a.date, a.time);
                    MessageBox.Show(result);
                    RefreshData();
                };
                flow.Controls.Add(view);
            }
        }
    }
}
