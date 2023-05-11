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
        Salon salon ;
        public TimeTable()
        {
            salon = Salon.instance;
            InitializeComponent();
            Top = 75;
        }
        public void RefreshData()
        {
            DateTime time = datePicker.Value;
            string date = time.Year + "." + (time.Month < 10 ? "0" : "") + time.Month + "." + (time.Day < 10 ? "0" : "") + time.Day;
            CustomerTime cusTime = new CustomerTime(Salon.customer.email, date);
            table.Controls.Clear();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    TimeView v = new TimeView((i * 6 + j) % 2 == 0 ? 1 : 0);
                    v.timeLabel.Text = (i * 6 + j) + "-" + ((i * 6 + j + 1) == 24? 0 : (i * 6 + j + 1) );
                    table.Controls.Add(v, j, i);
                }
            }
        }
    }
}
