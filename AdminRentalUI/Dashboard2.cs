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
    public partial class Dashboard2 : Form
    {
        public Dashboard2()
        {
            //MainDashboard

            InitializeComponent();

            lblTitle.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            formDashboard FormDashboard_Vrb = new formDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FormDashboard_Vrb);
            FormDashboard_Vrb.Show();
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            formDashboard FormDashboard_Vrb = new formDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FormDashboard_Vrb);
            FormDashboard_Vrb.Show();
        }

        //NavBar Hover Animation
        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnVehicleList_Leave(object sender, EventArgs e)
        {
            btnVehicleList.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnBookingDetails_Leave(object sender, EventArgs e)
        {
            btnBookingDetails.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnSetting_Leave(object sender, EventArgs e)
        {
            btnSetting.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Customers";
            this.PnlFormLoader.Controls.Clear();
            FormCustomers FormDashboard_Vrb = new FormCustomers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FormDashboard_Vrb);
            FormDashboard_Vrb.Show();
        }

        private void btnVehicleList_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnVehicleList.Height;
            pnlNav.Top = btnVehicleList.Top;
            btnVehicleList.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Vehicle List";
            this.PnlFormLoader.Controls.Clear();
            formVehicleList FormDashboard_Vrb = new formVehicleList() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FormDashboard_Vrb);
            FormDashboard_Vrb.Show();
        }

        private void btnBookingDetails_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnBookingDetails.Height;
            pnlNav.Top = btnBookingDetails.Top;
            btnBookingDetails.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Booking Details";
            this.PnlFormLoader.Controls.Clear();
            formBookingDetails FormDashboard_Vrb = new formBookingDetails() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FormDashboard_Vrb);
            FormDashboard_Vrb.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSetting.Height;
            pnlNav.Top = btnSetting.Top;
            btnSetting.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Setting";
            this.PnlFormLoader.Controls.Clear();
            formSetting FormDashboard_Vrb = new formSetting() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FormDashboard_Vrb);
            FormDashboard_Vrb.Show();
        }
    }
}
