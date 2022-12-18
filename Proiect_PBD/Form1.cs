using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Proiect_PBD
{
   
    public partial class Meniu : Form
    {
        
        public Meniu()
        {
            InitializeComponent();
            
        }
        public void Calcul_Promovabilitate(string disciplina)
        {

            string connect = @"Data Source=GABI\WINCC;Initial Catalog=Proiect_PBD;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT nota from studenti where disciplina = @disciplina", cnn);
            cmd.Parameters.AddWithValue("disciplina", disciplina);
            SqlDataReader dr = cmd.ExecuteReader(); while (dr.Read())
            {
                int nota = int.Parse(dr["nota"].ToString());

                MessageBox.Show("Promovabilitatea  este: " + (nota * 10) + " %");
            }

            cnn.Close();
            dr.Close();
            cmd.Dispose();
        }
        private void btn_BD_Click(object sender, EventArgs e)
        {
            Form f = new Introducere();
            f.ShowDialog();
            refresh();

        }
        private void refresh()
        {
            string connect = @"Data Source=GABI\WINCC;Initial Catalog=Proiect_PBD;Integrated Security=True";
             SqlConnection cnn = new SqlConnection(connect);
            string tabel_date = "select * from note";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "note");
            dataGridView1.DataSource = ds.Tables["note"].DefaultView;
            cnn.Close();
        }
        private void Meniu_Load(object sender, EventArgs e)
        {
            refresh();

        }

        private void btn_Afisare_nepromovati_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=GABI\WINCC;Initial Catalog=Proiect_PBD;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            string tabel_date = "select * from  note where nota <5";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "note");
            dataGridView1.DataSource = ds.Tables["note"].DefaultView;
            cnn.Close();
        }

        private void btn_Raport_Click(object sender, EventArgs e)
        {
           
            string connect = @"Data Source=GABI\WINCC;Initial Catalog=Proiect_PBD;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connect))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT nume ,prenume , Legitimatie,MAX(an_studiu) FROM note Group BY nume,prenume,Legitimatie ORDER BY nume"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);

                            //Build the Text file data.
                            string txt = string.Empty;

                           /* foreach (DataColumn column in dt.Columns)
                            {
                                //Add the Header row for Text file.
                                txt += column.ColumnName + "\t\t";
                            }
                           */
                            //Add new line.
                            txt += "\r\n";

                            foreach (DataRow row in dt.Rows)
                            {
                                foreach (DataColumn column in dt.Columns)
                                {
                                    //Add the Data rows.
                                    txt += row[column.ColumnName].ToString() + "    ";
                                }

                                //Add new line.
                                txt += "\r\n";
                            }

                            //Download the Text file.
                            string path = @"C:\Users\ursul\OneDrive - Universitatea Politehnica Timisoara\Desktop\Proiect_PBD\Rapoarte\raport_studenti.txt";
                            using (StreamWriter writer= new StreamWriter(path))
                            {
                                writer.WriteLine("DATELE STUDENTIILOR:\n");
                                writer.WriteLine("nume\t\t\tprenume\t Nr.Mat    An ");
                                writer.WriteLine(txt);
                            }
                            
                        }
                    }
                }
            }
        }

        private void btn_golire_tabel_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=GABI\WINCC;Initial Catalog=Proiect_PBD;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            string tabel_date = "DELETE FROM note";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "note");
            //dataGridView1.DataSource = ds.Tables["ProiectPBD"].DefaultView;
            cnn.Close();
            MessageBox.Show("S-a sters baza de date!");
            refresh();
        }

        private void btn_Raport_6_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=GABI\WINCC;Initial Catalog=Proiect_PBD;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connect))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT nume ,prenume, Legitimatie,disciplina,an_studiu,nota FROM note WHERE nota>5 Group BY nume ,prenume , Legitimatie,disciplina,an_studiu,nota ORDER BY nume,prenume,an_studiu,disciplina"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);

                            //Build the Text file data.
                            string txt = string.Empty;

                            /* foreach (DataColumn column in dt.Columns)
                             {
                                 //Add the Header row for Text file.
                                 txt += column.ColumnName + "\t\t";
                             }
                            */
                            //Add new line.
                            txt += "\r\n";

                            foreach (DataRow row in dt.Rows)
                            {
                                foreach (DataColumn column in dt.Columns)
                                {
                                    //Add the Data rows.
                                    txt += row[column.ColumnName].ToString() + "    ";
                                }

                                //Add new line.
                                txt += "\r\n";
                            }

                            //Download the Text file.
                            string path = @"C:\Users\ursul\OneDrive - Universitatea Politehnica Timisoara\Desktop\Proiect_PBD\Rapoarte\raport_studenti_6.txt";
                            using (StreamWriter writer = new StreamWriter(path))
                            {
                                writer.WriteLine("DATELE STUDENTIILOR:\n");
                                writer.WriteLine("nume\t\t\tprenume\t\t\t Nr.Mat    Disciplina      an_studiu           nota ");
                                writer.WriteLine(txt);
                            }

                        }
                    }
                }
            }
        }

        private void btnPromovabilitate_Click(object sender, EventArgs e)
        {
            Form f = new Form3();
            f.ShowDialog();
        }

        private void btn_Prezentari_m_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=GABI\WINCC;Initial Catalog=Proiect_PBD;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            string tabel_date = "select nume, prenume, nr_prezentare from note Where nr_prezentare = (Select MAX(nr_prezentare) FROM ProiectPBD)";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "note");
            dataGridView1.DataSource = ds.Tables["note"].DefaultView;
            cnn.Close();
            
            
        }

        private void Adaugare_nota_Click(object sender, EventArgs e)
        {
            Form f = new Form2();
            f.ShowDialog();
            refresh();
        }
    }
}
