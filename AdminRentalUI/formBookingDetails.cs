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
    public partial class formBookingDetails : Form
    {
        public formBookingDetails()
        {
            InitializeComponent();
        }


        private void Btn_add_Click(object sender, EventArgs e)
        {
            //BookingAdd ba = new BookingAdd();
            //ba.Show();
            Form formBackground2 = new Form();
            try
            {
                using (BookingAdd badd = new BookingAdd())
                {
                    formBackground2.StartPosition = FormStartPosition.Manual;
                    formBackground2.FormBorderStyle = FormBorderStyle.None;
                    formBackground2.Opacity = .70d;
                    formBackground2.BackColor = Color.Black;
                    formBackground2.WindowState = FormWindowState.Maximized;
                    formBackground2.TopMost = true;
                    formBackground2.Location = this.Location;
                    formBackground2.ShowInTaskbar = false;
                    formBackground2.Show();

                    badd.Owner = formBackground2;
                    badd.ShowDialog();

                    formBackground2.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground2.Dispose();
            }
        }
    }
}
