using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libary
{
    public partial class Form3 : Form
    {
     
        public Form3()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var Form4 = new Form4();
            Form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            var form5 = new Form5();
            form5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            var form6 = new Form6();
            form6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form7 = new Form7();
            form7.Show();
            
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var form8 = new Form8();
            this.Close();
            form8.Show();
            
        }
    }
}
