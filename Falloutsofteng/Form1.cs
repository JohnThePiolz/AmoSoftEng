using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Falloutsofteng
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Assuming you have text boxes for username and password
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Hardcoded valid username and password for demonstration purposes
            string validUsername = "user";
            string validPassword = "password";

            // Check if the entered username and password match the valid credentials
            if (username == validUsername && password == validPassword)
            {
                // If login is successful, close the current form and open the homepage
                MessageBox.Show("Login successful!");

                // Close the current login form
                this.Hide();

                // Create and show the homepage form
                HOMEPAGE homePage = new HOMEPAGE();
                homePage.Show();
            }
            else
            {
                // If login fails, show an error message
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
    }
}
