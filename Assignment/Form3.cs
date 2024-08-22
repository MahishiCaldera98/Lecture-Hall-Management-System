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

namespace Assignment
{
    public partial class Form3 : Form
    {
        ConnectDb _conn = new ConnectDb();
        public Form3()
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
        private void Form3_Load(object sender, EventArgs e)
        {
            _conn.GetConnection();

            var dt = GetValues();

            if (dt.Rows.Count > 0)
            {


                mo1.Text = dt.Rows[0][2].ToString();
                mo2.Text = dt.Rows[1][2].ToString();
                mo3.Text = dt.Rows[2][2].ToString();
                mo4.Text = dt.Rows[3][2].ToString();

                tu1.Text = dt.Rows[4][2].ToString();
                tu2.Text = dt.Rows[5][2].ToString();
                tu3.Text = dt.Rows[6][2].ToString();
                tu4.Text = dt.Rows[7][2].ToString();

                we1.Text = dt.Rows[8][2].ToString();
                we2.Text = dt.Rows[9][2].ToString();
                we3.Text = dt.Rows[10][2].ToString();
                we4.Text = dt.Rows[11][2].ToString();

                th1.Text = dt.Rows[12][2].ToString();
                th2.Text = dt.Rows[13][2].ToString();
                th3.Text = dt.Rows[14][2].ToString();
                th4.Text = dt.Rows[15][2].ToString();

                fr1.Text = dt.Rows[16][2].ToString();
                fr2.Text = dt.Rows[17][2].ToString();
                fr3.Text = dt.Rows[18][2].ToString();
                fr4.Text = dt.Rows[19][2].ToString();
            }
        }
    }
}
