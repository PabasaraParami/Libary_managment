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
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBook mainForm = new AddBook();
            mainForm.Show();

            
            this.Hide();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            frmAddMember mainForm = new frmAddMember();
            mainForm.Show();
            this.Hide();
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            frmIssueBook mainForm = new frmIssueBook();
            mainForm.Show();
            this.Hide();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            frmReturnBook mainForm = new frmReturnBook();
            mainForm.Show();
            this.Hide();
        }
    }
}
