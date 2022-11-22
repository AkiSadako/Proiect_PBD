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

        private void btn_BD_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=DENIS-PC\SQLEXPRESS;Initial Catalog=Proiect_PBD;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            string persoana = "Insert into ProiectPBD ([nume], [prenume], [Legitimatie], [medie_generala], [media_pe_anul_1],[media_pe_anul_2], [media_pe_anul_3], [disciplina], [an_studiu], [nr_prezentare], [data] ,[nota] ) " +
                "values ('popa','ion','123456',4,5,0,0,'Matematica',1,1,'22/12/2003',4)," +
                " ('adam','gheorghe','123457',7,5,0,0,'Fizica',1,1,'12/12/2003',9)," +
                " ('popa','ion','123456',7,5,0,0,'Chimie',2,1,'01/03/2004',10), " +
                " ('popa','ion','123456',7,5,0,0,'Engleza',3,2,'02/09/2005',9), " +
                " ('Pop','george','123458',7,5,0,0,'Matematica',1,1,'12/12/2002',10) ";
            SqlCommand sc = new SqlCommand(persoana,cnn);
            sc.ExecuteNonQuery();
            cnn.Close();
            cnn.Open();
            string tabel_date = "select * from ProiectPBD";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "ProiectPBD");
            dataGridView1.DataSource = ds.Tables["ProiectPBD"].DefaultView;
            cnn.Close();
        }

        private void Meniu_Load(object sender, EventArgs e)
        {
            string connect = @"Data Source=DENIS-PC\SQLEXPRESS;Initial Catalog=Proiect_PBD;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connect);
            MessageBox.Show("S-a realizat conectarea cu baza de date!");
        }

        private void btn_Afisare_nepromovati_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=DENIS-PC\SQLEXPRESS;Initial Catalog=Proiect_PBD;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            string tabel_date = "select * from ProiectPBD where nota <5";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "ProiectPBD");
            dataGridView1.DataSource = ds.Tables["ProiectPBD"].DefaultView;
            cnn.Close();
        }

        private void btn_Raport_Click(object sender, EventArgs e)
        {
            /*//conectarea cu baza de date
          string connect = @"Data Source=DENIS-PC\SQLEXPRESS;Initial Catalog=Proiect_PBD;Integrated Security=True";
          SqlConnection cnn = new SqlConnection(connect);
          //comenzile
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = cnn;
          cnn.Open();
          //Scriere in fisier
          string path = @"D:\Facultate\Proiect_PBD\Rapoarte\raport_studenti.txt";
          StreamWriter writer = new StreamWriter(path);
          SqlDataReader reader = cmd.ExecuteReader();
          writer.WriteLine("Datele: ");
          while (reader.Read())
          {
              writer.Write(reader["nume"].ToString());
              writer.Write(", " + reader["prenume"].ToString());
              writer.Write(", " + reader["Legitimatie"].ToString());
              writer.Write(", " + reader["medie_generala"].ToString());
              writer.Write(", " + reader["media_pe_anul_1"].ToString());
              writer.Write(", " + reader["media_pe_anul_2"].ToString());
              writer.Write(", " + reader["media_pe_anul_3"].ToString());
              writer.Write(", " + reader["disciplina"].ToString());
              writer.Write(", " + reader["an_studiu"].ToString());
              writer.Write(", " + reader["nr_prezentare"].ToString());
              writer.Write(", " + reader["data"].ToString());
              writer.WriteLine(", " + reader["nota"].ToString());
          }
          writer.WriteLine(DateTime.Now);
          writer.WriteLine("---------------------------------");
          writer.Close();
          reader.Close();
          cnn.Close();*/
            string connect = @"Data Source=DENIS-PC\SQLEXPRESS;Initial Catalog=Proiect_PBD;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connect))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT nume ,prenume , Legitimatie,MAX(an_studiu) FROM ProiectPBD Group BY nume,prenume,Legitimatie ORDER BY nume"))
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
                            string path = @"D:\Facultate\Proiect_PBD\Rapoarte\raport_studenti.txt";
                            using (StreamWriter writer= new StreamWriter(path))
                            {
                                writer.WriteLine("DATELE STUDENTIILOR:\n");
                                writer.WriteLine("nume\t\t\tprenume\t\t\t Nr.Mat    An ");
                                writer.WriteLine(txt);
                            }
                            
                        }
                    }
                }
            }
        }

        private void btn_golire_tabel_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=DENIS-PC\SQLEXPRESS;Initial Catalog=Proiect_PBD;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            string tabel_date = "DELETE FROM ProiectPBD";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "ProiectPBD");
            //dataGridView1.DataSource = ds.Tables["ProiectPBD"].DefaultView;
            cnn.Close();
            MessageBox.Show("Sa sters baza de date!");
        }

        private void btn_Raport_6_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=DENIS-PC\SQLEXPRESS;Initial Catalog=Proiect_PBD;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connect))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT nume ,prenume, Legitimatie,disciplina,an_studiu,nota FROM ProiectPBD WHERE nota>5 Group BY nume ,prenume , Legitimatie,disciplina,an_studiu,nota ORDER BY nume,prenume,an_studiu,disciplina"))
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
                            string path = @"D:\Facultate\Proiect_PBD\Rapoarte\raport_studenti_6.txt";
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
    }
}
