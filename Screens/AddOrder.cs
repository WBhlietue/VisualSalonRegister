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
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
            if (!Salon.instance.isAdmin)
            {

            }
            for (int i = 9; i < 20; i++)
            {
                timeSelect.Items.Add(i);
            }
            foreach (var item in Datas.serviceType)
            {
                typeSelect.Items.Add(item.name);
            }
            RefreshTable();
            typeSelect.SelectedIndexChanged += (object o, EventArgs e) =>
            {
                priceLabel.Text = "Price: " + Datas.serviceType[typeSelect.SelectedIndex].price + "₮";
                timeLabel.Text = "Time: " + Datas.serviceType[typeSelect.SelectedIndex].timeLong + " hours";
            };
            typeSelect.SelectedIndex = 0;
            datePicker.ValueChanged += (object o, EventArgs e) =>
            {
                RefreshTable();
            };
            addBtn.Click += (object o, EventArgs e) =>
            {
                DateTime time = datePicker.Value;
                DateTime now = DateTime.Now;
                string date = time.Year + "." + (time.Month < 10 ? "0" : "") + time.Month + "." + (time.Day < 10 ? "0" : "") + time.Day;
                if (time.Year < now.Year)
                {
                    MessageBox.Show("You can't select this day, please select future");
                }
                else
                {
                    if (time.Month < now.Month)
                    {
                        MessageBox.Show("You can't select this day, please select future");
                    }
                    else
                    {
                        if (time.Day < now.Day)
                        {
                            MessageBox.Show("You can't select this day, please select future");
                        }
                        else
                        {
                            if (time.Year == now.Year && time.Month == now.Month && time.Day == now.Day)
                            {
                                if (timeSelect.SelectedIndex + 9 <= now.Hour)
                                {
                                    MessageBox.Show("You can't select this time, please select future");
                                }
                                else
                                {
                                    string result = Salon.instance.AddOrder(date, timeSelect.SelectedIndex+9, typeSelect.SelectedIndex);
                                    if (result == Datas.addOrderComplete)
                                    {
                                        MainScreen.instance.RefreshData();
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show(result);
                                    }
                                }
                            }
                            else
                            {
                                string result = Salon.instance.AddOrder(date, timeSelect.SelectedIndex+9, typeSelect.SelectedIndex);
                                if (result == Datas.addOrderComplete)
                                {
                                    MainScreen.instance.RefreshData();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show(result);
                                }
                            }
                        }
                    }
                }

            };
        }
        void RefreshTable()
        {
            DateTime time = datePicker.Value;
            string date = time.Year + "." + (time.Month < 10 ? "0" : "") + time.Month + "." + (time.Day < 10 ? "0" : "") + time.Day;
            List<Order> orders = Salon.instance.GetAllOrderForCustomerInDay(date);
            tableView.Controls.Clear();
            for (int i = 0; i < 24; i++)
            {
                int a = Get(i, orders);
                AddOrderView v = new AddOrderView(a);
                v.label1.Text = i + "";
                tableView.Controls.Add(v, i, 0);
            }

        }
        int Get(int time, List<Order> order)
        {
            if(time < 9 || time > 19){
                return 2;
            }
            foreach (var item in order)
            {
                if (time >= item.time && time < Datas.serviceType[item.type].timeLong + item.time)
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}
