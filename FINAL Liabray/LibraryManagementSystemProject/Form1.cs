using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystemProject
{
    public partial class frmLogin : Form
    {
        public object Me { get; private set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPass.Text;

            // Simulate authentication (Replace this with actual database verification)
            if (username == "admin" && password == "password")
            {
                MessageBox.Show("Login Successful!");
                // Open the main application form or perform any other action

                frmDashBoard mainForm = new frmDashBoard();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCreateAccount mainForm = new frmCreateAccount();
            mainForm.Show();
            this.Hide();

        }
    }
}
