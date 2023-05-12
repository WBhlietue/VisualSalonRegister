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
    public partial class TimeTable : UserControl
    {
        Salon salon;
        public TimeTable()
        {
            salon = Salon.instance;
            InitializeComponent();
            datePicker.ValueChanged += (object o, EventArgs e) =>
            {
                RefreshData();
            };
            Top = 75;
        }
        public void RefreshData()
        {
            DateTime time = datePicker.Value;
            string date = time.Year + "." + (time.Month < 10 ? "0" : "") + time.Month + "." + (time.Day < 10 ? "0" : "") + time.Day;
            CustomerTime cusTime = new CustomerTime(Salon.customer.email, date);
            table.Controls.Clear();
            List<Order> order = salon.GetAllOrderForCustomerInDay(date);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    int a = i * 6 + j;

                    TimeView v = new TimeView((a < 9 || a > 19 ? 2 :( cusTime.time[a] ? 1 : 0)), Get(a, order));
                    v.timeLabel.Text = (a < 10 ? "0" : "") + a + ":00-" + ((a + 1) == 24 ? "00" : (a + 1 < 10 ? "0" + (a + 1) : "" + a)) + ":00";
                    table.Controls.Add(v, j, i);
                }
            }
        }

        SalonServiceType Get(int time, List<Order> order)
        {
            foreach (var item in order)
            {
                if (time >= item.time && time < Datas.serviceType[item.type].timeLong + item.time)
                {
                    return Datas.serviceType[item.type];
                }
            }
            return null;
        }
    }
}
