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
using BDSalon.Components;

namespace BDSalon.Screens
{
    public partial class MainScreen : Form
    {
        public static MainScreen instance;
        public Home home = new Home();
        public OrderPage orders = new OrderPage();
        public TimeTable timeTable = new TimeTable();
        public HeaderNonLogin nonLogin = new HeaderNonLogin();
        public HeaderLogin headerBar = new HeaderLogin();
        public HeaderAdmin headerAdmin = new HeaderAdmin();
        bool orderRefresh = false;
        bool isAmin;
        public MainScreen()
        {
            instance = this;
            InitializeComponent();
            Logout();
        }
        public void Login()
        {
            isAmin = Salon.instance.isAdmin;
            orderRefresh = false;
            SwitchToHome();
        }
        public void SwitchToHome()
        {
            this.Controls.Clear();
            if (isAmin)
            {
                this.Controls.Add(headerAdmin);
                headerAdmin.Set();
            }
            else
            {
                this.Controls.Add(headerBar);
                headerBar.Set();
            }
            this.Controls.Add(home);
        }
        public void SwitchToOrder()
        {
            if (!orderRefresh)
            {
                orderRefresh = true;
                RefreshData();
            }
            this.Controls.Clear();
            if (isAmin)
            {
                this.Controls.Add(headerAdmin);
                headerAdmin.Set();
            }
            else
            {
                this.Controls.Add(headerBar);
                headerBar.Set();
            }
            this.Controls.Add(orders);
        }
        public void SwitchToCustomer()
        {
            if (!orderRefresh)
            {
                orderRefresh = true;
                RefreshData();
            }
            this.Controls.Clear();
            if (isAmin)
            {
                this.Controls.Add(headerAdmin);
                headerAdmin.Set();
            }
            else
            {
                this.Controls.Add(headerBar);
                headerBar.Set();
            }
            this.Controls.Add(orders);
        }
        public void SwitchToTime()
        {
            if (!orderRefresh)
            {
                orderRefresh = true;
                RefreshData();
            }
            this.Controls.Clear();
            this.Controls.Add(headerBar);
            headerBar.Set();
            this.Controls.Add(timeTable);
        }
        public void Logout()
        {
            isAmin = false;
            Salon.instance.Logout();
            this.Controls.Clear();
            this.Controls.Add(nonLogin);
            this.Controls.Add(home);
        }
        public void RefreshData()
        {
            timeTable.RefreshData();
            orders.RefreshData();
        }
    }

}
