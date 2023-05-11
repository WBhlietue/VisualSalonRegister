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
using BDSalon.Screens;

namespace BDSalon
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public static List<Form> forms = new List<Form>();
        public Form1()
        {
            instance = this;
            // InitializeComponent();
        }


    }
}
