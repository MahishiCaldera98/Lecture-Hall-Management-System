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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment
{
    public partial class Form6 : Form
    {
        ConnectDb _conn = new ConnectDb();
        public Form6()
        {
            InitializeComponent();
        }
        public DataTable GetValues()
        {
            var sql = "SELECT * FROM schedules";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, _conn.GetConnection());
            DataTable dt = new DataTable();
            sqlda.Fill(dt);

            return dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            _conn.GetConnection();

            var dt = GetValues();

            if (dt.Rows.Count > 0) { 

             
                mo1.Text = dt.Rows[0][2].ToString() ?? "Empty";
                mo2.Text = dt.Rows[1][2].ToString() ?? "Empty";
                mo3.Text = dt.Rows[2][2].ToString() ?? "Empty";
                mo4.Text = dt.Rows[3][2].ToString() ?? "Empty";

                tu1.Text = dt.Rows[4][2].ToString() ?? "Empty";
                tu2.Text = dt.Rows[5][2].ToString() ?? "Empty";
                tu3.Text = dt.Rows[6][2].ToString() ?? "Empty";
                tu4.Text = dt.Rows[7][2].ToString() ?? "Empty";

                we1.Text = dt.Rows[8][2].ToString() ?? "Empty";
                we2.Text = dt.Rows[9][2].ToString() ?? "Empty";
                we3.Text = dt.Rows[10][2].ToString() ?? "Empty";
                we4.Text = dt.Rows[11][2].ToString() ?? "Empty";

                th1.Text = dt.Rows[12][2].ToString() ?? "Empty";
                th2.Text = dt.Rows[13][2].ToString() ?? "Empty";
                th3.Text = dt.Rows[14][2].ToString() ?? "Empty";
                th4.Text = dt.Rows[15][2].ToString() ?? "Empty";

                fr1.Text = dt.Rows[16][2].ToString() ?? "Empty";
                fr2.Text = dt.Rows[17][2].ToString() ?? "Empty";
                fr3.Text = dt.Rows[18][2].ToString() ?? "Empty";
                fr4.Text = dt.Rows[19][2].ToString() ?? "Empty";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mo1_Click(object sender, EventArgs e)
        {
            var dt = GetValues();
            comboBox1.Text = dt.Rows[0][0].ToString();
            comboBox2.Text = dt.Rows[0][1].ToString();
           

        }

        private void mo2_Click(object sender, EventArgs e)
        {
            var dt = GetValues();
            comboBox1.Text = dt.Rows[1][0].ToString();
            comboBox2.Text = dt.Rows[1][1].ToString();

        }

        private void mo3_Click(object sender, EventArgs e)
        {
            var dt = GetValues();
            comboBox1.Text = dt.Rows[2][0].ToString();
            comboBox2.Text = dt.Rows[2][1].ToString();
  
        }

        private void mo4_Click(object sender, EventArgs e)
        {
            var dt = GetValues();
            comboBox1.Text = dt.Rows[3][0].ToString();
            comboBox2.Text = dt.Rows[3][1].ToString();
        }

        private void tu1_Click(object sender, EventArgs e)
        {
            var dt = GetValues();
            comboBox1.Text = dt.Rows[4][0].ToString();
            comboBox2.Text = dt.Rows[4][1].ToString();
        }

        private void tu2_Click(object sender, EventArgs e)
        {
            var dt = GetValues();
            comboBox1.Text = dt.Rows[5][0].ToString();
            comboBox2.Text = dt.Rows[5][1].ToString();
        }

        private void tu3_Click(object sender, EventArgs e)
        {
            var dt = GetValues();
            comboBox1.Text = dt.Rows[6][0].ToString();
            comboBox2.Text = dt.Rows[6][1].ToString();
        }

        private void tu4_Click(object sender, EventArgs e)
        {
            var dt = GetValues();
            comboBox1.Text = dt.Rows[7][0].ToString();
            comboBox2.Text = dt.Rows[7][1].ToString();
        }

        private void we1_Click(object sender, EventArgs e)
        {
            var dt = GetValues();
            comboBox1.Text = dt.Rows[8][0].ToString();
            comboBox2.Text = dt.Rows[8][1].ToString();
        }

        private void we2_Click(object sender, EventArgs e)
        {
            var dt = GetValues();
            comboBox1.Text = dt.Rows[9][0].ToString();
            comboBox2.Text = dt.Rows[9][1].ToString();
        }

        private void we3_Click(object sender, EventArgs e)
        {
            var dt = GetValues();
            comboBox1.Text = dt.Rows[10][0].ToString();
            comboBox2.Text = dt.Rows[10][1].ToString();
        }

        private void we4_Click(object sender, EventArgs e)
        {
            var dt = GetValues();
            comboBox1.Text = dt.Rows[11][0].ToString();
            comboBox2.Text = dt.Rows[11][1].ToString();
        }

        private void th1_Click(object sender, EventArgs e)
        {
            var dt = GetValues();
            comboBox1.Text = dt.Rows[12][0].ToString();
            comboBox2.Text = dt.Rows[12][1].ToString();
        }

        private void th2_Click(object sender, EventArgs e)
        {
            var dt = GetValues();
            comboBox1.Text = dt.Rows[13][0].ToString();
            comboBox2.Text = dt.Rows[13][1].ToString();
        }

        private void th3_Click(object sender, EventArgs e)
        {
            var dt = GetValues();
            comboBox1.Text = dt.Rows[14][0].ToString();
            comboBox2.Text = dt.Rows[14][1].ToString();
        }

        private void th4_Click(object sender, EventArgs e)
        {
            var dt = GetValues();
            comboBox1.Text = dt.Rows[15][0].ToString();
            comboBox2.Text = dt.Rows[15][1].ToString();
        }

        private void fr1_Click(object sender, EventArgs e)
        {
            var dt = GetValues();
            comboBox1.Text = dt.Rows[16][0].ToString();
            comboBox2.Text = dt.Rows[16][1].ToString();
        }

        private void fr2_Click(object sender, EventArgs e)
        {
            var dt = GetValues();
            comboBox1.Text = dt.Rows[17][0].ToString();
            comboBox2.Text = dt.Rows[17][1].ToString();
        }

        private void fr3_Click(object sender, EventArgs e)
        {
            var dt = GetValues();
            comboBox1.Text = dt.Rows[18][0].ToString();
            comboBox2.Text = dt.Rows[18][1].ToString();
        }

        private void fr4_Click(object sender, EventArgs e)
        {
            var dt = GetValues();
            comboBox1.Text = dt.Rows[19][0].ToString();
            comboBox2.Text = dt.Rows[19][1].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var time_slot = comboBox1.Text;
            var day = comboBox2.Text;
            var hall = comboBox3.Text;
            var subject = comboBox4.Text;

            if (time_slot == "" || day == "")
            {
                MessageBox.Show("Please Select Time and Day!", "Error",
         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                var sql = "UPDATE schedules SET lectue_hall_details='" + hall + '/' + subject + "' WHERE time_slot='" + time_slot + "' AND day='" + day + "'";
                SqlCommand cmd = new SqlCommand(sql, _conn.GetConnection());
                cmd.ExecuteNonQuery();
                _conn.CloseConnection();
                MessageBox.Show("Successfully Updated!");

            }
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var time_slot = comboBox1.Text;
            var day = comboBox2.Text;
            var hall = comboBox3.Text;
            var subject = comboBox4.Text;

            if (time_slot == "" || day == "")
            {
                MessageBox.Show("Please Select Time and Day!", "Error",
         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var sql = "UPDATE schedules SET lectue_hall_details='Empty' WHERE time_slot='" + time_slot + "' AND day='" + day + "'";
                SqlCommand cmd = new SqlCommand(sql, _conn.GetConnection());
                cmd.ExecuteNonQuery();
                _conn.CloseConnection();
                MessageBox.Show("Successfully Deleted!");

            }
        }
    }
}
