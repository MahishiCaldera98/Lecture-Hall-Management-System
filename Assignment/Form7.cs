using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form7 : Form
    {
        private  int user_type;
        public Form7(int role)
        {
            InitializeComponent();
            user_type = role;
        }

        private void gunaAdvenceTileButton4_Click(object sender, EventArgs e)
        {
            Form5 view1 = new Form5();
            view1.Show();
        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            Form4 view1 = new Form4();
            view1.Show();
        }

        private void gunaAdvenceTileButton3_Click(object sender, EventArgs e)
        {
            if (user_type == 1)
            {
                Form6 form6 = new Form6();
                form6.Show();
            }
            else
            {
                Form3 view3 = new Form3();
                view3.Show();
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
    }
}
