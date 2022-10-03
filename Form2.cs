using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Libary
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

           
        }

       




        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int i;
            timer1.Start();
            progressBar1.Value += 15;
           
        }

       private void Timer1_Tick(object sender , EventArgs e)
        {
          
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }
        private void button2_Click(object sender , EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          

           

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
           progressBar1.Value += 15;
            if (progressBar1.Value == 150)
            {
                var form3 = new Form3();
                this.Close();
                form3.Show();
            }
        }
    }
}
