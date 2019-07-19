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
    public partial class SignupForm : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; username = root; password = ");
        public SignupForm()
        {
            InitializeComponent();
            txtSPassword.UseSystemPasswordChar = true;
            txtRePassword.UseSystemPasswordChar = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSShowPassword.Checked)
            {
                txtSPassword.UseSystemPasswordChar = false;
            } else
            {
                txtSPassword.UseSystemPasswordChar = true;
            }
        }

        private void chkShowRePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowRePassword.Checked)
            {
                txtRePassword.UseSystemPasswordChar = false;
            } else
            {
                txtRePassword.UseSystemPasswordChar = true;
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtSPassword.Text == txtRePassword.Text)
            {
                if (radioBtnCustomer.Checked)
                {
                    string insertQuery = "INSERT INTO cinema_ticket_system.users(user_name, password, retype_password) VALUES('" + txtUsername.Text + "', '" + txtSPassword.Text + "', '" + txtRePassword.Text + "')";
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    try
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Sign up compelete...");
                        }
                        else
                        {
                            MessageBox.Show("Sorry! Sign up fail...");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    connection.Close();

                    var moviesForm = new MoviesForm();
                    moviesForm.Show();
                    this.Hide();
                }else if (radioBtnStaff.Checked)
                {
                    string insertQuery = "INSERT INTO cinema_ticket_system.staff(staff_name, staff_password, staff_retype_password) VALUES('" + txtUsername.Text + "', '" + txtSPassword.Text + "', '" + txtRePassword.Text + "')";
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    try
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Sign up compelete...");
                        }
                        else
                        {
                            MessageBox.Show("Sorry! Sign up fail...");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    connection.Close();

                    var staffViewForm = new StaffViewForm();
                    staffViewForm.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Your password mismatch!");
            }
        }

        private void btnToLogin_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
