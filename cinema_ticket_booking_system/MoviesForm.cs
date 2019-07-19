using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema_ticket_booking_system
{
    public partial class MoviesForm : Form
    {
        public MoviesForm()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void btnTheaterOne_Click(object sender, EventArgs e)
        {
            var theaterOneSeatsForm = new TheaterOneSeatsForm();
            theaterOneSeatsForm.Show();
            this.Hide();
        }

        private void btnTheaterTwo_Click(object sender, EventArgs e)
        {
            var theaterTwoSeatsForm = new TheaterTwoSeatsForm();
            theaterTwoSeatsForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
