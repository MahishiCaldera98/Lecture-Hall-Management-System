using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        ConnectDb conn = new ConnectDb();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.GetConnection();
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Form2();
            newForm.Closed += (s, args) => this.Close();
            newForm.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int count;
            var name = user_name.Text;
            var pass = password.Text;

            try
            {

                var sql = "SELECT * FROM users WHERE user_name='" + name + "' AND password='" + pass + "'";
                SqlDataAdapter sqlda = new SqlDataAdapter(sql, conn.GetConnection());
                DataTable dt = new DataTable();
                
                sqlda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login Success!","Title",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    var form7 = new Form7((int)dt.Rows[0][4]);
                    form7.Closed += (s, args) => this.Close();
                    form7.Show();
                }
                else if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Credentials are not matched!", "Error",
          MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void user_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
              
        }
    }
}
