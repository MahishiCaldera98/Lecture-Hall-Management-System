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
    public partial class Form5 : Form
    {
        string connectionString = @"Data Source=KESHAN-WORKSPAC\SQLEXPRESS;Initial Catalog=project_999; Integrated Security=True";
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT user_id,name FROM users", conn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);

                dataGridView1.DataSource = dt;

            }
        }
    }
}
