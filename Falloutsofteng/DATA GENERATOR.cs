using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Falloutsofteng
{
    public partial class DataGenerator : Form
    {
        public DataGenerator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1;Port=3306;Database=clinicalrotationplanner;Uid=root;";

            // Check if at least one text box has input
            if (string.IsNullOrWhiteSpace(textBoxName.Text) &&
                string.IsNullOrWhiteSpace(textBoxSpec.Text) &&
                string.IsNullOrWhiteSpace(textBoxTime.Text) &&
                string.IsNullOrWhiteSpace(textBoxHos.Text))
            {
                MessageBox.Show("Please fill in at least one field.");
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert data for clinical instructors if textbox has value
                    if (!string.IsNullOrWhiteSpace(textBoxName.Text) || !string.IsNullOrWhiteSpace(textBoxSpec.Text))
                    {
                        string instructorInsertQuery = "INSERT INTO clinicalinstructors (InstructorName, Specialty) VALUES (@Name, @Specialty)";
                        using (MySqlCommand instructorCommand = new MySqlCommand(instructorInsertQuery, connection))
                        {
                            instructorCommand.Parameters.AddWithValue("@Name", textBoxName.Text);
                            instructorCommand.Parameters.AddWithValue("@Specialty", textBoxSpec.Text);
                            instructorCommand.ExecuteNonQuery();
                        }
                    }

                    // Insert data for time shifts if textbox has value
                    if (!string.IsNullOrWhiteSpace(textBoxTime.Text))
                    {
                        string timeshiftInsertQuery = "INSERT INTO timeshifts (TimeShiftName) VALUES (@Time)";
                        using (MySqlCommand timeshiftCommand = new MySqlCommand(timeshiftInsertQuery, connection))
                        {
                            timeshiftCommand.Parameters.AddWithValue("@Time", textBoxTime.Text);
                            timeshiftCommand.ExecuteNonQuery();
                        }
                    }

                    // Insert data for hospitals if textbox has value
                    if (!string.IsNullOrWhiteSpace(textBoxHos.Text))
                    {
                        string hospitalInsertQuery = "INSERT INTO hospitals (HospitalName) VALUES (@Hospital)";
                        using (MySqlCommand hospitalCommand = new MySqlCommand(hospitalInsertQuery, connection))
                        {
                            hospitalCommand.Parameters.AddWithValue("@Hospital", textBoxHos.Text);
                            hospitalCommand.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Data inserted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Close the current form (if needed)
            this.Close();

            // Instantiate the HOMEPAGE form
            HOMEPAGE homepageForm = new HOMEPAGE();
            
            // Show the HOMEPAGE form
            homepageForm.Show();
        }
    }
}
