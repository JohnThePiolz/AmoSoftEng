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
    public partial class HOMEPAGE : Form
    {
        public HOMEPAGE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Instantiate the Calendar form
            Calendar calendarForm = new Calendar();

            // Show the Calendar form
            calendarForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Close the current form (if needed)
            this.Hide();

            // Instantiate the Data Generator form
            DataGenerator dataGeneratorForm = new DataGenerator();

            // Show the Data Generator form
            dataGeneratorForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Close the current form (if needed)
            this.Hide();

            // Instantiate the login form (Form1)
            Form1 loginForm = new Form1();

            // Show the login form (Form1)
            loginForm.Show();
        }
    }
}
