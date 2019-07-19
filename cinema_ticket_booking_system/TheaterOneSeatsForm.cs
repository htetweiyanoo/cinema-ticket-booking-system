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
using System.Collections;

namespace cinema_ticket_booking_system
{
    public partial class TheaterOneSeatsForm : Form

    {
        MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; username = root; password = ");
        MySqlCommand command;
        int totalPrice;
        public TheaterOneSeatsForm()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            if (btnA1.BackColor == Color.Red)
            {
                btnA1.BackColor = Color.White;
                txtSeatsNo.Text += "A1, ";
                totalPrice += 1500;
                txtTotalPrice.Text = totalPrice.ToString();
            }
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            if (btnA2.BackColor == Color.Red)
            {
                btnA2.BackColor = Color.White;
                txtSeatsNo.Text += "A2, ";
                totalPrice += 1500;
                txtTotalPrice.Text = totalPrice.ToString();
            }

        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            if (btnA3.BackColor == Color.Red)
            {
                btnA3.BackColor = Color.White;
                txtSeatsNo.Text += "A3, ";
                totalPrice += 1500;
                txtTotalPrice.Text = totalPrice.ToString();
            }

        }

        private void btnA4_Click(object sender, EventArgs e)
        {

            if (btnA4.BackColor == Color.Red)
            {
                btnA4.BackColor = Color.White;
                txtSeatsNo.Text += "A4, ";
                totalPrice += 1500;
                txtTotalPrice.Text = totalPrice.ToString();
            }

        }

        private void btnA5_Click(object sender, EventArgs e)
        {
            if (btnA5.BackColor == Color.Red)
            {
                btnA5.BackColor = Color.White;
                txtSeatsNo.Text += "A5, ";
                totalPrice += 1500;
                txtTotalPrice.Text = totalPrice.ToString();
            }

        }

        private void btnA6_Click(object sender, EventArgs e)
        {
            if (btnA6.BackColor == Color.Red)
            {
                btnA6.BackColor = Color.White;
                txtSeatsNo.Text += "A6, ";
                totalPrice += 1500;
                txtTotalPrice.Text = totalPrice.ToString();
            }

        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            if (btnB1.BackColor == Color.Red)
            {
                btnB1.BackColor = Color.White;
                txtSeatsNo.Text += "B1, ";
                totalPrice += 1500;
                txtTotalPrice.Text = totalPrice.ToString();
            }

        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            if (btnB2.BackColor == Color.Red)
            {
                btnB2.BackColor = Color.White;
                txtSeatsNo.Text += "B2, ";
                totalPrice += 1500;
                txtTotalPrice.Text = totalPrice.ToString();
            }

        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            if (btnB3.BackColor == Color.Red)
            {
                btnB3.BackColor = Color.White;
                txtSeatsNo.Text += "B3, ";
                totalPrice += 1500;
                txtTotalPrice.Text = totalPrice.ToString();
            }

        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            if (btnB4.BackColor == Color.Red)
            {
                btnB4.BackColor = Color.White;
                txtSeatsNo.Text += "B4, ";
                totalPrice += 1500;
                txtTotalPrice.Text = totalPrice.ToString();
            }

        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            if (btnB5.BackColor == Color.Red)
            {
                btnB5.BackColor = Color.White;
                txtSeatsNo.Text += "B5, ";
                totalPrice += 1500;
                txtTotalPrice.Text = totalPrice.ToString();
            }

        }

        private void btnB6_Click(object sender, EventArgs e)
        {
            if (btnB6.BackColor == Color.Red)
            {
                btnB6.BackColor = Color.White;
                txtSeatsNo.Text += "B6, ";
                totalPrice += 1500;
                txtTotalPrice.Text = totalPrice.ToString();
            }

        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            if (btnC1.BackColor == Color.Blue)
            {
                btnC1.BackColor = Color.White;
                txtSeatsNo.Text += "C1, ";
                totalPrice += 2500;
                txtTotalPrice.Text = totalPrice.ToString();
            }

        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            if (btnC2.BackColor == Color.Blue)
            {
                btnC2.BackColor = Color.White;
                txtSeatsNo.Text += "C2, ";
                totalPrice += 2500;
                txtTotalPrice.Text = totalPrice.ToString();
            }

        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            if (btnC3.BackColor == Color.Blue)
            {
                btnC3.BackColor = Color.White;
                txtSeatsNo.Text += "C3, ";
                totalPrice += 2500;
                txtTotalPrice.Text = totalPrice.ToString();
            }

        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            if (btnC4.BackColor == Color.Blue)
            {
                btnC4.BackColor = Color.White;
                txtSeatsNo.Text += "C4, ";
                totalPrice += 2500;
                txtTotalPrice.Text = totalPrice.ToString();
            }

        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            if (btnC5.BackColor == Color.Blue)
            {
                btnC5.BackColor = Color.White;
                txtSeatsNo.Text += "C5, ";
                totalPrice += 2500;
                txtTotalPrice.Text = totalPrice.ToString();
            }

        }

        private void btnC6_Click(object sender, EventArgs e)
        {
            if (btnC6.BackColor == Color.Blue)
            {
                btnC6.BackColor = Color.White;
                txtSeatsNo.Text += "C6, ";
                totalPrice += 2500;
                txtTotalPrice.Text = totalPrice.ToString();
            }

        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            if (btnD1.BackColor == Color.Blue)
            {
                btnD1.BackColor = Color.White;
                txtSeatsNo.Text += "D1, ";
                totalPrice += 2500;
                txtTotalPrice.Text = totalPrice.ToString();
            }

        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            if (btnD2.BackColor == Color.Blue)
            {
                btnD2.BackColor = Color.White;
                txtSeatsNo.Text += "D2, ";
                totalPrice += 2500;
                txtTotalPrice.Text = totalPrice.ToString();
            }

        }

        private void btnD3_Click(object sender, EventArgs e)
        {
            if (btnD3.BackColor == Color.Blue)
            {
                btnD3.BackColor = Color.White;
                txtSeatsNo.Text += "D3, ";
                totalPrice += 2500;
                txtTotalPrice.Text = totalPrice.ToString();
            }

        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            if (btnD4.BackColor == Color.Blue)
            {
                btnD4.BackColor = Color.White;
                txtSeatsNo.Text += "D4, ";
                totalPrice += 2500;
                txtTotalPrice.Text = totalPrice.ToString();
            }

        }

        private void btnD5_Click(object sender, EventArgs e)
        {
            if (btnD5.BackColor == Color.Blue)
            {
                btnD5.BackColor = Color.White;
                txtSeatsNo.Text += "D5, ";
                totalPrice += 2500;
                txtTotalPrice.Text = totalPrice.ToString();
            }

        }

        private void btnD6_Click(object sender, EventArgs e)
        {
            if (btnD6.BackColor == Color.Blue)
            {
                btnD6.BackColor = Color.White;
                txtSeatsNo.Text += "D6, ";
                totalPrice += 2500;
                txtTotalPrice.Text = totalPrice.ToString();
            }

        }

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void executeQuery(String query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Congratulations! Booking Cinema Ticket Successfully...");
                }
                else
                {
                    MessageBox.Show("Sorry! Booking Cinema Ticket Fail!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(dateTimePicker1.Text.Length > 0)
            {
                if (comboBoxTime.Text.Length > 0)
                {
                    if (txtSeatsNo.Text.Length > 0)
                    {
                        string message = "Are you sure what selected?";
                        string title = "Confirm Booking";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {
                            string insertQuery = "INSERT INTO cinema_ticket_system.ticket(movie_name, theater, seat_no, show_date, show_time, total_amount) VALUES ('" + labelMovieName.Text + "', '" + labelTheaterName.Text + "', '" + txtSeatsNo.Text + "','" + dateTimePicker1.Text + "','" + comboBoxTime.Text + "', '" + txtTotalPrice.Text + "')";
                            executeQuery(insertQuery);
                            TicketForm ticketForm = new TicketForm(labelMovieName.Text, labelTheaterName.Text, txtSeatsNo.Text, dateTimePicker1.Text, comboBoxTime.Text, txtTotalPrice.Text);
                            ticketForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            var theaterOneSeatsForm = new TheaterOneSeatsForm();
                            theaterOneSeatsForm.Show();
                            this.Hide();
                        }
                    } else
                    {
                        MessageBox.Show("Please select seats.");
                    }
                } else
                {
                    MessageBox.Show("Please select showing time.");
                }
            }
            else
            {
                MessageBox.Show("Please select showing date.");
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnReChoose_Click(object sender, EventArgs e)
        {
            btnA1.BackColor = Color.Red;
            btnA2.BackColor = Color.Red;
            btnA3.BackColor = Color.Red;
            btnA4.BackColor = Color.Red;
            btnA5.BackColor = Color.Red;
            btnA6.BackColor = Color.Red;
            btnB1.BackColor = Color.Red;
            btnB2.BackColor = Color.Red;
            btnB3.BackColor = Color.Red;
            btnB4.BackColor = Color.Red;
            btnB5.BackColor = Color.Red;
            btnB6.BackColor = Color.Red;

            btnC1.BackColor = Color.Blue;
            btnC2.BackColor = Color.Blue;
            btnC3.BackColor = Color.Blue;
            btnC4.BackColor = Color.Blue;
            btnC5.BackColor = Color.Blue;
            btnC6.BackColor = Color.Blue;
            btnD1.BackColor = Color.Blue;
            btnD2.BackColor = Color.Blue;
            btnD3.BackColor = Color.Blue;
            btnD4.BackColor = Color.Blue;
            btnD5.BackColor = Color.Blue;
            btnD6.BackColor = Color.Blue;
            txtSeatsNo.Text = "";
            txtTotalPrice.Text = "";
            comboBoxTime.Text = "";
            dateTimePicker1.Text = "";
        }
    }
}
