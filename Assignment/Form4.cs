using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assignment
{
    public partial class Form4 : Form
    {
        string connectionString = @"Data Source=KESHAN-WORKSPAC\SQLEXPRESS;Initial Catalog=project_999; Integrated Security=True";
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT hall_ID,hall_name FROM lecture_hall", conn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
              
                dt.Columns["hall_ID"].ColumnName = "Hall Id";
                dt.Columns["hall_name"].ColumnName = "Hall Name";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = dt;
            }
        }
    }
}
