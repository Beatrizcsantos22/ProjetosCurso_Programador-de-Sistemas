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

namespace FormPassagens_Aereas
{
    public partial class EntradaConsulta : Form
    {
        public EntradaConsulta()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            SqlConnection nec = new SqlConnection(@"Data Source=;Initial Catalog=;Integrated Security=True");
            nec.Open();
            SqlCommand cmd = new SqlCommand("Select * from Comprovante where CodigoPassageiro=@CodigoPassageiro", nec);
            cmd.Parameters.AddWithValue("@CodigoPassageiro", this.txbCodigo.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}


