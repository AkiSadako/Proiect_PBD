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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalculare_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=DENIS-PC\SQLEXPRESS;Initial Catalog=Proiect_PBD;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT * from ProiectPBD Where legitimatie=" + txtNrleg.Text + "AND disciplina=" + txtDisciplina.Text))
            {

            }
        }
    }
}
