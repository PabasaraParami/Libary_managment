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
    public partial class frmIssueBook : Form
    {
        DataTable table = new DataTable("table");
        public frmIssueBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmDashBoard mainForm = new frmDashBoard();
            mainForm.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Are you sure Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
               == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void txtIssueDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmIssueBook_Load(object sender, EventArgs e)
        {
            DataColumn No = new DataColumn("Member Name", typeof(String));
            table.Columns.Add(No);

            DataColumn Bid = new DataColumn("Book id", typeof(string));
            table.Columns.Add(Bid);

            DataColumn bookn = new DataColumn("Book Name", typeof(string));
            table.Columns.Add(bookn);

            DataColumn bookis = new DataColumn("Book Issues Day", typeof(string));
            table.Columns.Add(bookis);



            table.Rows.Add("A.K.Akram","N22", "Nethma", dateTimePicker1.Text);
            table.Rows.Add("A.K.Akram", "N45", "Sulaga", dateTimePicker1.Text);

            table.Rows.Add( "M.K.G.P.P.Moragahakumbura", "N45", "AKALANKA", dateTimePicker1.Text);
            table.Rows.Add("A.K.Akram", "N22", "Sadalatha", dateTimePicker1.Text);


            dataGridView1.DataSource = table;

            // header color change

            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 10, FontStyle.Bold);
        }

        private void btnaddBook_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtnmane.Text,txtbookid.Text,txtbookname.Text, dateTimePicker1.Text);
            dataGridView1.DataSource = table;

            MessageBox.Show("Data added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Book Issues Successfull", " Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
