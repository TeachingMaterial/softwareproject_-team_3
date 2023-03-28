using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OnlineUniversity
{

    public partial class Staff_page : Form
    {
        private bool isClockedIn = false;
        public Staff_page(string username)
        {
            InitializeComponent();
            label1.Text = "Welcome, " + username + "!";
        }

        private void Staff_page_Load(object sender, EventArgs e)
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(isClockedIn)
            {
                MessageBox.Show("You are already clocked in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime currentDateTime = DateTime.Now;
            isClockedIn = true;

            MessageBox.Show("Clock in at: " + currentDateTime );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isClockedIn)
            {
                MessageBox.Show("You must clock in first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime currentDateTime = DateTime.Now;
            isClockedIn = false;

            MessageBox.Show("Clock out at: " + currentDateTime);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            GetPayslip payslip = new GetPayslip();
            payslip.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
