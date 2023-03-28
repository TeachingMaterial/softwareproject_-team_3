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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        string[] names_students = { "Juan Gallego","Christofer Reilly" };
        string[] names_Proffesors = { "Harry Smith"};
        string[] students = { "jg0001", "cr0002" };
        string[] passwords = { "project","password123" };
        string[] staff = {"professor","professor2" };
        string[] staffpasswords = {"professor01","professor02" };
        string[] admin = {"admin","admin2" };
        string[] adminpasswords = {"admin01" , "admin02" };
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


            string user = textBox_User.Text;
            string password = textBox_password.Text;
            string username = "";


            //Find the index of the user in the array
            int index = Array.IndexOf(students, user);
            int staffindex = Array.IndexOf(staff, user);
            int adminindex = Array.IndexOf(admin, user);
            
            // Check if the user is a student

            if (index != -1 && user.Equals(students[index]))
            {
                
                if (password.Equals(passwords[index]))
                {
                    username = names_students[index];
                    MessageBox.Show("Login Succesfully");
                    Student_page student = new Student_page(username);
                    student.Show();
                }
                else
                {
                    MessageBox.Show("Password incorrect");
                }

            }
            //Find the index of the user satff in the array
            
            else if (staffindex != -1 && user.Equals(staff[staffindex]))
            {
                if (password.Equals(staffpasswords[staffindex]))
                {
                    username = names_Proffesors[staffindex];
                    MessageBox.Show("Login Succesfully");
                    Staff_page staff = new Staff_page(username);
                    staff.Show();

                }
                else
                {
                    MessageBox.Show("Password incorrect");
                }
            }

            //Find the index of the user admind in the array
            
            else if(adminindex != -1 && user.Equals(admin[adminindex]))
            {
                if (password.Equals(adminpasswords[adminindex]))
                {
                    MessageBox.Show("Login Succesfully");
                    Admin_Page admin = new Admin_Page();
                    admin.Show();

                }
                else 
                {
                    MessageBox.Show("Password incorrect");
                }
            }
            else 
            { 
                MessageBox.Show("User not recognized"); 
            }
                
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
