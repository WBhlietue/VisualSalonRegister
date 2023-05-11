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
        public OrderPage()
        {
            salon = Salon.instance;
            InitializeComponent();
            viewAllBtn.Click += (object o, EventArgs e) =>
            {
                viewAll = true;
                RefreshData();
            };
            selectDateBtn.Click += (object o, EventArgs e) =>
            {
                viewAll = false;
                RefreshData();
            };
            addBtn.Click += (object o, EventArgs e) =>
            {
                new AddOrder().Show();
            };
            Top = 75;
        }
        public void RefreshData()
        {
            List<Order> orders;
            if (viewAll)
            {
                orders = salon.GetAllOrderForCustomer();
            }
            else
            {
                DateTime time = datePicker.Value;
                string date = time.Year + "." + (time.Month < 10 ? "0" : "") + time.Month + "." + (time.Day < 10 ? "0" : "") + time.Day;
                orders = salon.GetAllOrderForAllCustomerForAdminInDay(date);
            }
            flow.Controls.Clear();
            foreach (var item in orders)
            {
                OrderView view = new OrderView();
                view.orderDateLabel.Text = item.date;
                view.orderTimeLabel.Text = item.time + "";
                view.orderTypeLabel.Text = Datas.serviceType[item.type].name;
                view.orderPriceLabel.Text = Datas.serviceType[item.type].price + "";
                view.deleteBtn.Click += (object o, EventArgs e) =>
                {
                    salon.RemoveOrder(item.date, item.time);
                    RefreshData();
                };
                flow.Controls.Add(view);
            }

        }
    }
}
