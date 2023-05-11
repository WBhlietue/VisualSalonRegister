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
    public partial class OrderPage : UserControl
    {
        Salon salon;
        public OrderPage()
        {
            salon = Salon.instance;
            InitializeComponent();
            Top = 75;
        }
        public void RefreshData()
        {
            List<Order> orders = salon.GetAllOrderForCustomer();
            foreach (var item in orders)
            {
                OrderView view = new OrderView();
                view.orderDateLabel.Text = item.date;
                view.orderTimeLabel.Text = item.time + "";
                view.orderTypeLabel.Text = Datas.serviceType[item.type].name;
                view.orderPriceLabel.Text = Datas.serviceType[item.type].price + "";
                flow.Controls.Add(view);
            }
            
        }
    }
}
