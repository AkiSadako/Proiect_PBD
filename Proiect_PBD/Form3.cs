using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect_PBD
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalculare_Click(object sender, EventArgs e)
        {
            int i = 0;
            float suma = 0;
            string connect = @"Data Source=DENIS-PC\SQLEXPRESS;Initial Catalog=Proiect_PBD;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT nota from ProiectPBD where disciplina = @disciplina",cnn);
            cmd.Parameters.AddWithValue("disciplina",txtDisciplina.Text);
            SqlDataReader dr = cmd.ExecuteReader(); while(dr.Read())
            {
                int nota = int.Parse(dr["nota"].ToString());
                if (nota > 5)
                {
                    suma = + 1;
                    

                }
                i++;
                float p = suma / i;
                MessageBox.Show("Promovabilitatea  este: " + (p*100)+" %");
            }
            
            cnn.Close();
            dr.Close();
            cmd.Dispose();
        }
    }
}
