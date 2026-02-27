using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentManagerPro
{
    public partial class Form1 : Form
    {
        string role;
        string connectionString =
        @"Data Source=.;Initial Catalog=StudentDB;Integrated Security=True";

        public Form1(string userRole)
        {
            InitializeComponent();
            role = userRole;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();

            if(role != "Admin")
                btnDelete.Enabled = false;
        }

        void LoadData()
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da =
                new SqlDataAdapter("SELECT * FROM Students", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query =
                "INSERT INTO Students(Name,Age,Major) VALUES(@n,@a,@m)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@a", txtAge.Text);
                cmd.Parameters.AddWithValue("@m", txtMajor.Text);

                cmd.ExecuteNonQuery();
            }

            LoadData();
        }
    }
}
