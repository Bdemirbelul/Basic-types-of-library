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


namespace Libary
{
    
    public partial class Form5 : Form
    {
        string constring = "Data Source=DESKTOP-KIH1OI6;Initial Catalog=deneme1;Integrated Security=True";
        public Form5()
        {
            InitializeComponent();
        }

       void PositionCombobox()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring)) 
            {
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * From position ", sqlcon);
                    DataTable dttb = new DataTable();
                sqlda.Fill(dttb);
               
               
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           dataGridView1.Rows.Add(
            new object[]
            {
                "C",
                "Cengiz kurt",
                211312123	,
                32,
                99
            }

            );
            dataGridView1.Rows.Add(
            new object[]
            {
                "Heart of the jungle",
                "esra gündoğdu",
                4353123   ,
                59,
                120
            }

            );
            dataGridView1.Rows.Add(
            new object[]
            {
                "The blade",
                "Techno",
                23891122123   ,
                189,
                160
            }

            );
            dataGridView1.Rows.Add(
            new object[]
            {
                "My life",
                "Balamir D.B",
                12838123213,
                28,
                310
            }
           

            ); dataGridView1.Rows.Add(
            new object[]
            {
                "Love",
                "Derin ay",
                14341413221   ,
                188,
                230
            }

            );


        }
        private DataTable database()
        {
            DataTable table = new DataTable();

            return table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
           
            this.Close();
            form3.Show();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
