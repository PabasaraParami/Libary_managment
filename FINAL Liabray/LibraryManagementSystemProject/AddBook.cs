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
    public partial class AddBook : Form
    {
        DataTable table = new DataTable("table");
        int selectedrow;
        public AddBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDashBoard mainForm = new frmDashBoard();
            mainForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtno.Text) ||
            string.IsNullOrWhiteSpace(txtname.Text) ||
            string.IsNullOrWhiteSpace(txtauthor.Text) ||
            string.IsNullOrWhiteSpace(txtpublic.Text) ||
            string.IsNullOrWhiteSpace(dateTimePicker1.Text) ||
            string.IsNullOrWhiteSpace(txtnumberpage.Text) ||
            string.IsNullOrWhiteSpace(txtprice.Text) ||
            string.IsNullOrWhiteSpace(txtquntity.Text) ||
            string.IsNullOrWhiteSpace(txtisbn.Text) ||
            string.IsNullOrWhiteSpace(txtnumberr.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Add row to DataGridView only if all fields are filled

                table.Rows.Add(txtno.Text, txtname.Text, txtauthor.Text, txtpublic.Text, dateTimePicker1.Text,
                               txtnumberpage.Text, txtprice.Text, txtquntity.Text, txtisbn.Text, txtnumberr.Text);
                dataGridView1.DataSource = table;

                MessageBox.Show("Data added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //save button

            MessageBox.Show("Data Add Successfull", " Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {

            // cler textbox

            txtname.Text = "";
            txtauthor.Text = "";
            txtpublic.Text = "";
            txtno.Text = "";
            txtnumberpage.Text = "";
            txtprice.Text = "";
            txtquntity.Text = "";
            txtisbn.Text = "";
            txtnumberr.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
               == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            DataColumn No = new DataColumn("NO", typeof(Int32));
            table.Columns.Add(No);

            DataColumn Bname = new DataColumn("Book Name", typeof(string));
            table.Columns.Add(Bname);

            DataColumn bauthor = new DataColumn("Book Author", typeof(string));
            table.Columns.Add(bauthor);

            DataColumn bpublication = new DataColumn("Book Publication", typeof(string));
            table.Columns.Add(bpublication);

            DataColumn bpurchase = new DataColumn("Book Purchase Day", typeof(string));
            table.Columns.Add(bpurchase);

            DataColumn bnpage = new DataColumn("Number of Page", typeof(Int32));

            table.Columns.Add(bnpage);

            DataColumn bprice = new DataColumn("Book Price", typeof(Int32));
            table.Columns.Add(bprice);

            DataColumn bqua = new DataColumn("Quantity", typeof(Int32));
            table.Columns.Add(bqua);

            DataColumn bisbn = new DataColumn("ISBN Number", typeof(string));
            table.Columns.Add(bisbn);

            DataColumn bnum = new DataColumn("Number", typeof(string));
            table.Columns.Add(bnum);

            // add the row

            table.Rows.Add(1, "Sadalatha", "Manoj Roopasinghe", "Manoj Publication", dateTimePicker1.Text,
                272, 300, 1, "955-8241-03-2", "N-1");

            table.Rows.Add(2, "Nedma", "Manjula Withanage", "Mewsada Publication", dateTimePicker1.Text,
               247, 1350, 1, "978-624-98053-4-7", "N-2");

            table.Rows.Add(3, "Akalanka", "R.R.Samarakkoon", "Dayawansha Pblication", dateTimePicker1.Text,
               167, 350, 1, "955-551-482-8", "N-3");

            table.Rows.Add(4, "Wathu sudu mala", "Niwtan Gunasekara", " Dayawansha Publication", dateTimePicker1.Text,
               237, 240, 1, "972-8799-05-2", "N-4");

            table.Rows.Add(5, "Sulaga", "Sugath Moragahakumbura", "Thammanna Publication", dateTimePicker1.Text,
               300, 500, 1, "947-7777-43-25", "N-5");

            table.Rows.Add(6, "Ananthaya", "Sisira Malalasekara", "Dayawansha Publication", dateTimePicker1.Text,
               287, 500, 1, "993-8741-81-8", "N-6");



            dataGridView1.DataSource = table;

            // header color change

            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 10, FontStyle.Bold);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;

            if (e.RowIndex == -1)
            {


            }

            else

            {
                DataGridViewRow row = dataGridView1.Rows[selectedrow];

                txtno.Text = row.Cells[0].Value.ToString();
                txtname.Text = row.Cells[1].Value.ToString();
                txtauthor.Text = row.Cells[2].Value.ToString();
                txtpublic.Text = row.Cells[3].Value.ToString();
                dateTimePicker1.Text = row.Cells[4].Value.ToString();
                txtnumberpage.Text = row.Cells[5].Value.ToString();
                txtprice.Text = row.Cells[6].Value.ToString();
                txtquntity.Text = row.Cells[7].Value.ToString();
                txtisbn.Text = row.Cells[8].Value.ToString();
                txtnumberr.Text = row.Cells[9].Value.ToString();

            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to edit the data", "Edit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
              == DialogResult.OK)
            {

                DataGridViewRow newDataRow = dataGridView1.Rows[selectedrow];
                newDataRow.Cells[0].Value = txtno.Text;
                newDataRow.Cells[1].Value = txtname.Text;
                newDataRow.Cells[2].Value = txtauthor.Text;
                newDataRow.Cells[3].Value = txtpublic.Text;
                newDataRow.Cells[4].Value = dateTimePicker1.Text;
                newDataRow.Cells[5].Value = txtnumberpage.Text;
                newDataRow.Cells[6].Value = txtprice.Text;
                newDataRow.Cells[7].Value = txtquntity.Text;
                newDataRow.Cells[8].Value = txtisbn.Text;
                newDataRow.Cells[9].Value = txtnumberr.Text;


            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(imagebmp, 5, 15);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
