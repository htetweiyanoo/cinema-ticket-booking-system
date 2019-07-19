using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cinema_ticket_booking_system
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txtLPassword.UseSystemPasswordChar = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void chkLShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLShowPassword.Checked)
            {
                txtLPassword.UseSystemPasswordChar = false;
            } else
            {
                txtLPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; username = root; password = ");
            if (radioBtnCustomer.Checked)
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM cinema_ticket_system.users WHERE user_name = '" + txtUsername.Text + "' and password = '" + txtLPassword.Text + "'", connection);
                DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    this.Hide();

                    var moviesForm = new MoviesForm();
                    moviesForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please check username and password!");
                }
            } else if (radioBtnStaff.Checked)
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM cinema_ticket_system.staff WHERE staff_name = '" + txtUsername.Text + "' and staff_password = '" + txtLPassword.Text + "'", connection);
                DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    this.Hide();

                    var staffViewForm = new StaffViewForm();
                    staffViewForm.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Please check username and password!");
                }
            }
            
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SignupForm signUpForm = new SignupForm();
            signUpForm.Show();
            this.Hide();
        }
    }
}
