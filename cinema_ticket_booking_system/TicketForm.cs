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
    public partial class TicketForm : Form
    {
        public static String tMovieName;
        public static String tTheaterName;
        public static String tSeatsNo;
        public static String tShowDate;
        public static String tShowTime;
        public static String tTotalAmount;
       
        public TicketForm(String movieName, String theaterName, String seatsNo, String showDate, String showTime, String totalAmount)
        {
            InitializeComponent();
            tMovieName = movieName;
            tTheaterName = theaterName;
            tSeatsNo = seatsNo;
            tShowDate = showDate;
            tShowTime = showTime;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            tTotalAmount = totalAmount;
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            labelMovieName.Text = tMovieName;
            labelTheater.Text = tTheaterName;
            labelSeatNo.Text = tSeatsNo;
            labelShowDate.Text = tShowDate;
            labelShowTime.Text = tShowTime;
            labelTotalAmount.Text = tTotalAmount;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
