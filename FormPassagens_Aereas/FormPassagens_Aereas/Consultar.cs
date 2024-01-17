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
    public partial class Consultar : Form
    {
        SqlCommand com = new SqlCommand();
        public Consultar()
        {
            InitializeComponent();

        }

        private void Consultar_Load(object sender, EventArgs e)
        {

        }

        private void tbxUserEnter(object sender, EventArgs e)
        {
            if (txbCodigoPasseiro.Text.Equals(@"CodigoPassageiro"))
            {
                txbCodigoPasseiro.Text = "";
            }
        }

        private void txbUserleave(object sender, EventArgs e)
        {
            if (txbCodigoPasseiro.Text.Equals(""))
            {
                txbCodigoPasseiro.Text = @"CodigoPassageiro";
            }
        }

        private void txbusersenha(object sender, EventArgs e)
        {
            if (txbSenha.Text.Equals("Senha"))
            {
                txbSenha.Text = "";

            }
        }

        private void txbLeaveSenha(object sender, EventArgs e)
        {
            if (txbSenha.Text.Equals(""))
            {
                txbSenha.Text = "Senha";

            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            SqlConnection nec = new SqlConnection(@"Data Source=;Initial Catalog=;Integrated Security=True");

            com.CommandText = "select * from Passageiro where CodigoPassageiro=@CodigoPassageiro and Senha=@Senha";

            com.Parameters.AddWithValue("@CodigoPassageiro", this.txbCodigoPasseiro.Text);
            com.Parameters.AddWithValue("@senha", this.txbSenha.Text);

            try
            {
                nec.Open();
                com.Connection = nec;


                SqlDataReader dr = com.ExecuteReader();


                if (dr.Read())
                {
                    if (txbCodigoPasseiro.Text.Equals(dr["CodigoPassageiro"].ToString()) && txbSenha.Text.Equals(dr["Senha"].ToString()))
                    {
                        MessageBox.Show("Sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        EntradaConsulta ex = new EntradaConsulta();
                        ex.Show();

                    }

                    else
                    {
                        MessageBox.Show("Confirme usuario e senha!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                nec.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Confirme usuario e senha!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void txbCodigoPasseiro_TextChanged(object sender, EventArgs e)
        {
            int codigopaciente = 0;
            bool valido = int.TryParse(txbCodigoPasseiro.Text, out codigopaciente);
            if (!valido)
            {
                MessageBox.Show("Codigo invalido, tente novamente");

            }
            return;
        }
    }
}




