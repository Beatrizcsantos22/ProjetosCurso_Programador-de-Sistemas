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
    public partial class Cadastro_cs : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=;Initial catalog=;integrated security=true");
        public Cadastro_cs()
        {
            InitializeComponent();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            TimeSpan tsdias = DateTime.Now.Date - dtpDataNascimento.Value;
            int dias = tsdias.Days;
            if (txbNome.Text == "")
            {
                MessageBox.Show("Preencha o campo nome.", "Atenção!!", MessageBoxButtons.OK);
                txbNome.Focus();
                return;
            }
            else if (mtbCpf.Text == "")
            {
                MessageBox.Show("Preencha o Campo CPF.", "Atenção!!", MessageBoxButtons.OK);
                mtbCpf.Focus();
                return;
            }


            else if (dias == 0)
            {
                MessageBox.Show("Data de nascimento igual a de hoje.", "Atenção!!", MessageBoxButtons.OK);
                dtpDataNascimento.Focus();
                return;
            }
            else if (mtbTelefone.Text == "")
            {
                MessageBox.Show("Preencha o campo Telefone.", "Atenção!!", MessageBoxButtons.OK);
                mtbTelefone.Focus();
                return;
            }
            else if (txbEmail.Text == "")
            {
                MessageBox.Show("Preencha o campo Email.", "Atenção!!", MessageBoxButtons.OK);
                txbEmail.Focus();
                return;
            }
            else if (tbxSenha.Text == "")
            {
                MessageBox.Show("Preencha o campo senha.", "Atenção!!", MessageBoxButtons.OK);
                tbxSenha.Focus();
                return;

            }

            else if (txbCartão.Text == "")
            {
                MessageBox.Show("Click no botão Confirma para gerar o seu numero do cartão", "Atenção!", MessageBoxButtons.OK);
                txbCartão.Focus();
                return;

            }
            string sql = "INSERT INTO Cliente (Nome,Cpf,DataNascimento,Telefone,Endereco,Email,Senha,CartaoCredito)" +
                " VALUES(@Nome,@Cpf,@DataNascimento,@Telefone,@Endereco,@Email,@Senha,@CartaoCredito )";
            try
            {
                SqlCommand c = new SqlCommand(sql, con);
                c.Parameters.Add(new SqlParameter("@Nome", this.txbNome.Text));
                c.Parameters.Add(new SqlParameter("@Cpf", this.mtbCpf.Text));
                c.Parameters.Add(new SqlParameter("@DataNascimento", this.dtpDataNascimento.Text));
                c.Parameters.Add(new SqlParameter("@Telefone", this.mtbTelefone.Text));
                c.Parameters.Add(new SqlParameter("@Endereco", this.txbEndereco.Text));
                c.Parameters.Add(new SqlParameter("@Email", this.txbEmail.Text));
                c.Parameters.Add(new SqlParameter("@Senha", this.tbxSenha.Text));
                c.Parameters.Add(new SqlParameter("@CartaoCredito", this.tbxSenha.Text));


                con.Open();
                c.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Salvo com sucesso!!");


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro!!" + ex);
            }
            finally
            {
                con.Close();
                Entrada_Conta ds = new Entrada_Conta();
                ds.Show();
            }

        }

        private void btnApagarTudo_Click(object sender, EventArgs e)
        {
            txbNome.Text = "";
            mtbCpf.Text = "";
            dtpDataNascimento.Value = DateTime.Now.Date;
            mtbTelefone.Text = "";
            txbEndereco.Text = "";
            txbEmail.Text = "";
            tbxSenha.Text = "";

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Random numAleatorio = new Random();
            int valorInteiro = numAleatorio.Next(38605, 100238);
            double valorQuebrado = numAleatorio.NextDouble();
            txbCartão.Text = valorInteiro.ToString();

        }
    }
}

