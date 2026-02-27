using System;
using System.Data;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID");
            table.Columns.Add("Tên");
            table.Columns.Add("Tuổi");
            table.Columns.Add("Ngành");

            dataGridView1.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtID.Text, txtName.Text, txtAge.Text, txtMajor.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Visible = row.Cells[1].Value.ToString()
                    .Contains(txtSearch.Text);
            }
        }
    }
}
