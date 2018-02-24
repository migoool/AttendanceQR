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
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            listUsers();
        }

        private void View_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenu newMenu = new MainMenu();
            newMenu.ShowDialog();
        }

        private void listUsers()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=P@ssw0rd2017;database=attendanceqr;";
            string query = "SELECT * FROM users";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            MySqlDataReader reader;
            viewUsers.Items.Clear();
            viewUsers.FullRowSelect = true;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetString(3));

                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6) };
                        var listViewItem = new ListViewItem(row);
                        viewUsers.Items.Add(listViewItem);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewUsers.SelectedIndices.Count <= 0)
            {
                return;
            }


            int intselectedindex = viewUsers.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
         
                this.Size = new Size(800, 460);
                this.Location = new Point(300, 130);

               
                firstnameText.Clear();
                middlenameText.Clear();
                lastnameText.Clear();
                courseText.SelectedIndex = -1;
                yearText.SelectedIndex = -1;
                sectionText.Clear();

                String id = viewUsers.Items[intselectedindex].SubItems[0].Text;
                String fname = viewUsers.Items[intselectedindex].SubItems[1].Text;
                String middle = viewUsers.Items[intselectedindex].SubItems[2].Text;
                String lname = viewUsers.Items[intselectedindex].SubItems[3].Text;

                String course = viewUsers.Items[intselectedindex].SubItems[4].Text;
                String year = viewUsers.Items[intselectedindex].SubItems[5].Text;
                String section = viewUsers.Items[intselectedindex].SubItems[6].Text;

                userIDText.Text = id;
                firstnameText.AppendText(fname);
                middlenameText.AppendText(middle);
                lastnameText.AppendText(lname);

                courseText.Text = course;
                yearText.Text = year;
                sectionText.AppendText(section);

                

            }
        }



        private void updateUser(string id, string fname, string middle, string lname, string course, string year, string section)
        {
            int userID = Int32.Parse(id);

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=P@ssw0rd2017;database=attendanceqr;";
            string query = "UPDATE `users` " +
                "SET `firstname`='" + fname + "', `middlename`='" + middle + "' ,`lastname`='" + lname + 
                "' ,`course`='" + course + "' ,`year`='" + year + "' ,`section`='" + section +
                "' WHERE id = '" + userID + "'";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                this.Size = new Size(535, 460);
                this.Location = new Point(380, 130);
                listUsers();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Size = new Size(535, 460);
            this.Location = new Point(380,130);


        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            String id = userIDText.Text;
            String fname = firstnameText.Text;
            String middle = middlenameText.Text;
            String lname =  lastnameText.Text;
            String course =  courseText.Text;
            String year =  yearText.Text;
            String section = sectionText.Text;  
            updateUser(id, fname, middle, lname, course, year, section);
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            String userID = userIDText.Text;
            String fname = firstnameText.Text;
            String middle = middlenameText.Text;
            String lname = lastnameText.Text;

            removeUserDB(userID, fname, middle, lname);
        }

        private void removeUserDB(string userID, string fname , string middle, string lname)
        {
            int id = Int32.Parse(userID);
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=P@ssw0rd2017;database=attendanceqr;";
            string query = "Delete from users Where id = '" + id + "'";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            string message = "Are you sure you want to delete \n " + lname + " , " + fname + " " + middle + "?";
            string caption = "DELETE USER";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();

                    this.Size = new Size(535, 460);
                    this.Location = new Point(380, 130);
                    listUsers();
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                this.Size = new Size(535, 460);
                this.Location = new Point(380, 130);
                listUsers();
            }
           
        }
    }
}
