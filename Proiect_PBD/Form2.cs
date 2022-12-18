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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Shown += OnShown;

        }

        private void btnAdaugare_nota_Click(object sender, EventArgs e) //save button 
        {
            string connect = @"Data Source=GABI\WINCC;Initial Catalog=Proiect_PBD;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            SqlCommand sc;
            string persoana = "select * from studenti where legitimatie= '" + comboBoxlegitimatie.Text+"'";
            SqlCommand oCmd = new SqlCommand(persoana, cnn);

            string nume, prenume;
            using (SqlDataReader oReader = oCmd.ExecuteReader()) // 
            {
                oReader.Read();


                    nume = oReader["nume"].ToString();
                    prenume = oReader["prenume"].ToString();
                cnn.Close();
            }

            cnn.Open();
            persoana = "Insert into note ([nume],[prenume], [legitimatie], [disciplina] ,[an_studiu],[nota],[nr_prezentare]) values (@n,@p,@l,@d,@an,@nota,@nr)";

            sc = new SqlCommand(persoana, cnn);
            sc.Parameters.AddWithValue("@n", nume);
            sc.Parameters.AddWithValue("@p", prenume);
            sc.Parameters.AddWithValue("@l", comboBoxlegitimatie.Text);
            sc.Parameters.AddWithValue("@d", comboBoxdisciplina.Text);
            sc.Parameters.AddWithValue("@an", comboBoxan.Text);
            sc.Parameters.AddWithValue("@nota", textBox1.Text);
            sc.Parameters.AddWithValue("@nr", textBox2.Text);

            
            sc.ExecuteNonQuery();

            cnn.Close();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void OnShown(object sender, EventArgs e)
        {
            //ca sa imi arate toate materiile direct cand se incarca forma 
           
            string connect = @"Data Source=GABI\WINCC;Initial Catalog=Proiect_PBD;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            string stmt = "select DISTINCT legitimatie from studenti "; // ca sa nu ne genereze 100 de legitimatii cand noi punem 10 note pt un student 

            SqlCommand oCmd = new SqlCommand(stmt, cnn);

            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    
                   legitimatii l= new legitimatii();
                    l.legitimatie = oReader["legitimatie"].ToString();
                    comboBoxlegitimatie.Items.Add(l);
                    //Invoke(new Action(() => comboBoxlegitimatie.Items.Add(l,false)));
                }
            
                cnn.Close();
            }
        }
    }

    
}
