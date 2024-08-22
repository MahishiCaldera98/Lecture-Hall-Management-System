using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Assignment
{
    public partial class Form2 : Form
    {
        ConnectDb conn = new ConnectDb();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count;
            var uName = name.Text;
            var uID= user_id.Text;
            var username= user_name.Text;
            var password= this.password.Text;
            var confirmed = cpassword.Text;
            int role = 0;

            if (lec.Checked)
            {
                role = 1;
            }

            Form7 form7 = new Form7(role);

            if (uName == "" || uID == "" || username == "" || password == null)
            {
                MessageBox.Show("Please provide all details!", "Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else {

                if (password != confirmed)
                {
                    MessageBox.Show("Password is not matched!", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    try
                    {

                        var sql = "INSERT INTO users VALUES('" + uID + "','" + username + "','" + uName + "','" + password + "','" + role + "')";
                        SqlCommand cmd = new SqlCommand(sql, conn.GetConnection());
                        count = cmd.ExecuteNonQuery();
                        conn.CloseConnection();

                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    MessageBox.Show("Successfully registered!");

                    Form2 form2 = new Form2();
                    form2.Close();
                    form7.Show();


                }

            }

            

            

            
           
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn.GetConnection();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
    }
}
