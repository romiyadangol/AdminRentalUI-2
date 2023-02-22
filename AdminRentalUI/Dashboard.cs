using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AdminRentalUI
{
    public partial class Dashboard : Form
    {
        //WindowCurveEdges
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
             int nHeightEllipse

          );
        //EndOfWindowCurveEdges

        //MainDashboard
        public Dashboard()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            lblTitle.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            formDashboard FormDashboard_Vrb = new formDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FormDashboard_Vrb);
            FormDashboard_Vrb.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        //NavBar Buttons
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
            Application.Exit();
        }

        private void panel3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void Dashboard_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
