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
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
            listAttendance();
        }

        private void listAttendance()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=P@ssw0rd2017;database=attendanceqr;";
            string query = "SELECT * FROM record";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            MySqlDataReader reader;
            viewAttendance.Items.Clear();
            viewAttendance.FullRowSelect = true;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        String dateRecord = reader.GetString(5);
                        dateRecord = dateRecord.Replace(" 12:00:00 AM", "");

                        string[] row = {reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), dateRecord };
                        var listViewItem = new ListViewItem(row);
                        viewAttendance.Items.Add(listViewItem);
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

        private void viewAttendance_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.R) || keyData == Keys.F5)
            {
                listAttendance();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Attendance_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenu newMenu = new MainMenu();
            newMenu.ShowDialog();
        }
    }
}
