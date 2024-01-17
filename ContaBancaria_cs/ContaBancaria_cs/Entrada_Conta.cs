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

namespace ContaBancaria_cs
{
    public partial class Entrada_Conta : Form
    {

        SqlConnection nec = new SqlConnection(@"Data Source=;Initial Catalog=;Integrated Security=True");

        SqlCommand com = new SqlCommand();
        public Entrada_Conta()
        {
            InitializeComponent();
        }

        private void txbUserEnter(object sender, EventArgs e)
        {
            if (txbCodigo.Text.Equals(@"CodigoCliente"))
            {
                txbCodigo.Text = "";

            }
        }

        private void UserLeave(object sender, EventArgs e)
        {

            if (txbCodigo.Text.Equals(""))
            {
                txbCodigo.Text = @"CodigoCliente";
            }
        }

        private void txbSenhaEnter(object sender, EventArgs e)
        {
            if (txbSenha.Text.Equals("Senha"))
            {
                txbSenha.Text = "";

            }
        }

        private void txbSenhaLeave(object sender, EventArgs e)
        {
            if (txbSenha.Text.Equals(""))
            {
                txbSenha.Text = "Senha";

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            com.CommandText = "select * from Cliente where CodigoCliente=@CodigoCliente and Senha=@Senha";

            com.Parameters.AddWithValue("@CodigoCliente", this.txbCodigo.Text);
            com.Parameters.AddWithValue("@senha", this.txbSenha.Text);

            try
            {
                nec.Open();
                com.Connection = nec;


                SqlDataReader dr = com.ExecuteReader();


                if (dr.Read())
                {
                    if (txbCodigo.Text.Equals(dr["CodigoCliente"].ToString()) && txbSenha.Text.Equals(dr["Senha"].ToString()))
                    {
                        MessageBox.Show("Sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        SacarDeposito_cs ex = new SacarDeposito_cs();
                        ex.Show();

                    }

                    else
                    {
                        MessageBox.Show("Confirme usuario e senha!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                nec.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Confirme usuario e senha!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}



