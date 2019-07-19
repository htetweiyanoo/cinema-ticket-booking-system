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
    public partial class StaffViewForm : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; username = root; password = ");
        MySqlCommand command;

        public StaffViewForm()
        {
            InitializeComponent();
            try
            {
                string selectQuery = "SELECT * FROM cinema_ticket_system.staff_view";
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);

                openConnection();

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "staff_view");
                dataGridView1.DataSource = dataSet.Tables["staff_view"];
                closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            if(connection.State == ConnectionState.Open)
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
                if(command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }
                else
                {
                    MessageBox.Show("Query Not Executed");
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


        private void btnEdit_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE cinema_ticket_system.staff_view SET cinema_name = '"+txtCinemaName.Text+"'," +
                " tickets = '"+txtTickets.Text+"', income = '"+txtIncome.Text+ "'" +
                " WHERE movie_name = '" + txtMovieName.Text + "'";
            executeQuery(updateQuery);
            txtMovieName.Text = "";
            txtCinemaName.Text = "";
            txtTickets.Text = "";
            txtIncome.Text = "";
            this.ActiveControl = txtMovieName;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO cinema_ticket_system.staff_view(movie_name, cinema_name, tickets, income) VALUES('" + txtMovieName.Text + "', '" + txtCinemaName.Text + "', '" + txtTickets.Text + "', '" + txtIncome.Text + "')";
            executeQuery(insertQuery);
            txtMovieName.Text = "";
            txtCinemaName.Text = "";
            txtTickets.Text = "";
            txtIncome.Text = "";
            this.ActiveControl = txtMovieName;
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                string selectQuery = "SELECT * FROM cinema_ticket_system.staff_view";
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);

                openConnection();

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "staff_view");
                dataGridView1.DataSource = dataSet.Tables["staff_view"];
                closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM cinema_ticket_system.staff_view WHERE movie_name = " +
                "'" + txtMovieName.Text + "'";
            executeQuery(deleteQuery);
            txtMovieName.Text = "";
            txtCinemaName.Text = "";
            txtTickets.Text = "";
            txtIncome.Text = "";
            this.ActiveControl = txtMovieName;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}



