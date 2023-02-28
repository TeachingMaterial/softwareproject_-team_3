using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OnlineUniversity
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void logginbutton_Click(object sender, EventArgs e)
        {
            string user, password;
            user = textBox_User.Text;
            password = textBox_password.Text;

            if (user == "jjuanda19" && password == "project")
            {
                MessageBox.Show("Login Succesfully");
            }
            else
                MessageBox.Show("Error Username or Password");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
