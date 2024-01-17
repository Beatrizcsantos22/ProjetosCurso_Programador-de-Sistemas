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

namespace FormPassagens_Aereas
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
            rbnIda.Checked = false;
            rbnIdaVolta.Checked = false;

        }

        private void rbnIda_CheckedChanged(object sender, EventArgs e)
        {
            TimeSpan tsdias = DateTime.Now.Date - dtpDataNascimento.Value;
            int dias = tsdias.Days;
            if (txbNome.Text == "")
            {
                MessageBox.Show("Preencha o campo nome.", "Atenção!!", MessageBoxButtons.OK);
                txbNome.Focus();
                return;
            }
            else if (mtbxCpf.Text == "")
            {
                MessageBox.Show("Preencha o Campo CPF.", "Atenção!!", MessageBoxButtons.OK);
                mtbxCpf.Focus();
                return;
            }

            else if (mtxbTelefone.Text == "")
            {
                MessageBox.Show("Preencha o campo Telefone.", "Atenção!!", MessageBoxButtons.OK);
                mtxbTelefone.Focus();
                return;
            }

            else if (dias == 0)
            {
                MessageBox.Show("Data de nascimento igual a de hoje.", "Atenção!!", MessageBoxButtons.OK);
                dtpDataNascimento.Focus();
                return;
            }
            else if (txbEmail.Text == "")
            {
                MessageBox.Show("Preencha o campo Email.", "Atenção!!", MessageBoxButtons.OK);
                txbEmail.Focus();
                return;
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Preencha o campo senha.", "Atenção!!", MessageBoxButtons.OK);
                textBox1.Focus();
                return;
            }
            Ida terceiroform = new Ida();
            terceiroform.ShowDialog();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=;Initial Catalog=;Integrated Security=True");

            string sql = "INSERT INTO Passageiro(Nome,Cpf,Telefone,DataNascimento,Email,Senha) VALUES(@Nome,@Cpf,@Telefone,@DataNascimento,@Email,@Senha)";
            try
            {
                SqlCommand c = new SqlCommand(sql, con);
                c.Parameters.Add(new SqlParameter("@Nome", this.txbNome.Text));
                c.Parameters.Add(new SqlParameter("@Cpf", this.mtbxCpf.Text));
                c.Parameters.Add(new SqlParameter("@Telefone", this.mtxbTelefone.Text));
                c.Parameters.Add(new SqlParameter("@DataNascimento", this.dtpDataNascimento.Text));
                c.Parameters.Add(new SqlParameter("@Email", this.txbEmail.Text));
                c.Parameters.Add(new SqlParameter("@Senha", this.textBox1.Text));

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
            }

        }

        private void rbnIdaVolta_CheckedChanged(object sender, EventArgs e)
        {
            TimeSpan tsdias = DateTime.Now.Date - dtpDataNascimento.Value;
            int dias = tsdias.Days;
            if (txbNome.Text == "")
            {
                MessageBox.Show("Preencha o campo nome.", "Atenção!!", MessageBoxButtons.OK);
                txbNome.Focus();
                return;
            }
            else if (mtbxCpf.Text == "")
            {
                MessageBox.Show("Preencha o Campo CPF.", "Atenção!!", MessageBoxButtons.OK);
                mtbxCpf.Focus();
                return;
            }

            else if (mtxbTelefone.Text == "")
            {
                MessageBox.Show("Preencha o campo Telefone.", "Atenção!!", MessageBoxButtons.OK);
                mtxbTelefone.Focus();
                return;
            }

            else if (dias == 0)
            {
                MessageBox.Show("Data de nascimento igual a de hoje.", "Atenção!!", MessageBoxButtons.OK);
                dtpDataNascimento.Focus();
                return;
            }
            else if (txbEmail.Text == "")
            {
                MessageBox.Show("Preencha o campo Email.", "Atenção!!", MessageBoxButtons.OK);
                txbEmail.Focus();
                return;
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Preencha o campo senha.", "Atenção!!", MessageBoxButtons.OK);
                textBox1.Focus();
                return;
            }

            IdaVolta quartoform = new IdaVolta();
            quartoform.ShowDialog();

        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btncSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

