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
using System.Data.Sql;

namespace ContaBancaria_cs
{
    public partial class CadastroEmpresa : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=;Initial catalog=;integrated security=true");
        public CadastroEmpresa()
        {
            InitializeComponent();
        }

        private void btnAvanca_Click(object sender, EventArgs e)
        {


            if (txbNome.Text == "")
            {
                MessageBox.Show("Preencha o campo nome ", "Atenção!", MessageBoxButtons.OK);
                txbNome.Focus();
                return;
            }
            else if (mtbCpf.Text == "")
            {
                MessageBox.Show("Preencha o campo Cpf", "Atenção!", MessageBoxButtons.OK);
                mtbCpf.Focus();
                return;
            }
            else if (mtbCep.Text == "")
            {
                MessageBox.Show("Preencha o campo Cep", "Atenção!", MessageBoxButtons.OK);
                mtbCep.Focus();
                return;
            }
            else if (mtbTelefone.Text == "")
            {
                MessageBox.Show("Preencha o campo Telefone", "Atenção!", MessageBoxButtons.OK);
                mtbTelefone.Focus();
                return;

            }
            else if (txbEndereco.Text == "")
            {
                MessageBox.Show("Preencha o campo Endereço", "Atenção!", MessageBoxButtons.OK);
                txbEndereco.Focus();
                return;
            }
            else if (txbEmail.Text == "")
            {
                MessageBox.Show("Preencha o campo Email", "Atenção!", MessageBoxButtons.OK);
                txbEmail.Focus();
                return;
            }
            else if (txbSenha.Text == "")
            {
                MessageBox.Show("Preencha o campo Senha", "Atenção!", MessageBoxButtons.OK);
            }
            string sql = "INSERT INTO CadastroEmpresa (NomeEmpresa,Cpf,Cep,Telefone,Endereco,Email,Senha)" +
                    " VALUES(@NomeEmpresa,@Cpf,@Cep,@Telefone,@Endereco,@Email,@Senha )";
            try
            {
                SqlCommand c = new SqlCommand(sql, con);
                c.Parameters.Add(new SqlParameter("@NomeEmpresa", this.txbNome.Text));
                c.Parameters.Add(new SqlParameter("@Cpf", this.mtbCpf.Text));
                c.Parameters.Add(new SqlParameter("@Cep", this.mtbCep.Text));
                c.Parameters.Add(new SqlParameter("@Telefone", this.mtbTelefone.Text));
                c.Parameters.Add(new SqlParameter("@Endereco", this.txbEndereco.Text));
                c.Parameters.Add(new SqlParameter("@Email", this.txbEmail.Text));
                c.Parameters.Add(new SqlParameter("@Senha", this.txbSenha.Text));


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
                FinanceiroEmpresa adm = new FinanceiroEmpresa();
                adm.Show();
            }

        }

        private void btnApagarTudo_Click(object sender, EventArgs e)
        {
            txbNome.Text = "";
            mtbCpf.Text = "";
            mtbCep.Text = "";
            mtbTelefone.Text = "";
            txbEndereco.Text = "";
            txbEmail.Text = "";
            txbSenha.Text = "";
        }
    }
}
