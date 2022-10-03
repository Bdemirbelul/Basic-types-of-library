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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            int accountotal = 0;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void account_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Form3 = new Form3();
            this.Close();
            Form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked ||  checkBox3.Checked ||  checkBox4.Checked || checkBox5.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Derin Belül")
            {
                if (textBox2.Text == "1512005")
                {
                    if ( textBox3.Text == "0104")
                    {
                        MessageBox.Show("Payment done successfully");
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
                        checkBox3.Checked = false;
                        checkBox4.Checked = false;
                        checkBox5.Checked = false;
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("Error ");
                }
            }
            else
            {
                MessageBox.Show("Payment can't be done , wrong username");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                account.Text = "15TL";
            }
            if (checkBox2.Checked)
            {
                account.Text = "20TL";
            }
            if (checkBox3.Checked)
            {
                account.Text = "25TL";

            }
            if (checkBox4.Checked)
            {
                account.Text = "30TL";

            }
            if (checkBox5.Checked)
            {
                account.Text = "35TL";
            }
            if (checkBox1.Checked && checkBox2.Checked)
            {
                account.Text = "35TL";
            }
            if (checkBox1.Checked && checkBox3.Checked)
            {
                account.Text = "40TL";
            }
            if (checkBox1.Checked && checkBox4.Checked)
            {
                account.Text = "45TL";
            }
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked)
            {
                account.Text = "120TL";
            }

        }
    }
}
