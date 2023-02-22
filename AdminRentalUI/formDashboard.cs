using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminRentalUI
{
    public partial class formDashboard : Form
    {
        public formDashboard()
        {
            InitializeComponent();
            chartRevenue.Titles.Add("Revenue");

            chartRevenue.Series["Revenue"].Points.AddXY("1", "3");
            chartRevenue.Series["Revenue"].Points.AddXY("2", "23");
            chartRevenue.Series["Revenue"].Points.AddXY("3", "43");
            chartRevenue.Series["Revenue"].Points.AddXY("4", "63");
            chartRevenue.Series["Revenue"].Points.AddXY("5", "73");
            chartRevenue.Series["Revenue"].Points.AddXY("6", "93");
        }

        private void formDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
