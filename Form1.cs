namespace Libary
{
    public partial class Form1 : Form
    {

        public int password = 0 ;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
            
        {


            
           
                    if (textBox1.Text == "admin")
                    {

                        if (textBox2.Text == "12345")
                        {
                            var Form2 = new Form2();
                            Form2.Show();
                            this.Hide();
                        }

                    }
                else  if  (textBox1.Text != "admin")
                {
                password++;
                if (textBox2.Text != "12345")
                    {
                        MessageBox.Show("Please enter your username and password correctly ", "ByDemir", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                       
                    }


                }

                if (password == 3)
                {
                    MessageBox.Show("You have entered an incorrect password more than once, the system is shutting down", "ByDemir", MessageBoxButtons.OK);
                    this.Close();
                }
            }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

     
    }
    }
