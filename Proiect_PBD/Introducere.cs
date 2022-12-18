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

namespace Proiect_PBD
{
    public partial class Introducere : Form
    {
        public Introducere()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //save button
        {
            string connect = @"Data Source=GABI\WINCC;Initial Catalog=Proiect_PBD;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            SqlCommand sc;
            string persoana = "Insert into studenti ([nume], [prenume], [Legitimatie]) values (@n,@p,@l)";

            sc = new SqlCommand(persoana, cnn);
           sc.Parameters.AddWithValue("@n", textBox1.Text);  
           sc.Parameters.AddWithValue("@p", textBox2.Text);   
            sc.Parameters.AddWithValue("@l", textBox3.Text);
     
            sc.ExecuteNonQuery();


            cnn.Close();
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
