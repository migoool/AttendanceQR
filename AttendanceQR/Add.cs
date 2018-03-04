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

namespace AttendanceQR
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }


        private void registerButton_Click(object sender, EventArgs e)
        {
            String fname = firstnameText.Text;
            String midname = middlenameText.Text;
            String lname = lastnameText.Text;
            String course = courseText.Text;
            String year = yearText.Text;
            String section = sectionText.Text;


            string message = "Review your information \n\n Name \t:  " + fname + " " + midname + " "+ lname + 
                            "\n Course \t: " + course + 
                            "\n Year \t: " + year +
                            "\n Section \t: " + section;
            string caption = "Informations";


            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=P@ssw0rd2017;database=attendanceqr;";
                string query = "INSERT INTO users (`firstname`, `middlename`, `lastname`, `course`, `year`, `section`)" +
                    "VALUES ( '" + fname + "', '" + midname + "', '" + lname + "', '" + course + "', '" + year + "', '" + section + "')";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;

                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    databaseConnection.Close();
                    addNewUser();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void addNewUser()
        {
            string message = "USER ADDED SUCCESSFULLY \n Do you want to add another user?";
            string caption = "User Registration";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                firstnameText.Clear();
                middlenameText.Clear();
                lastnameText.Clear();
                courseText.SelectedIndex = -1;
                yearText.SelectedIndex = -1;
                sectionText.Clear();
            }
            else
            {
                Application.Exit();
                MainMenu newMenu = new MainMenu();
                newMenu.ShowDialog();

            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            firstnameText.Clear();
            middlenameText.Clear();
            lastnameText.Clear();
            courseText.SelectedIndex = -1;
            yearText.SelectedIndex = -1;
            sectionText.Clear();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            MainMenu newMenu = new MainMenu();
            newMenu.ShowDialog();
            
        }

        private void Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenu newMenu = new MainMenu();
            newMenu.ShowDialog();
        }

    }
}
