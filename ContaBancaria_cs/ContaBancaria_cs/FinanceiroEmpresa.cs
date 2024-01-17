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
using System.Data.Sql;

namespace ContaBancaria_cs
{
    public partial class FinanceiroEmpresa : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=;Initial catalog=;integrated security=true");
        public FinanceiroEmpresa()
        {
            InitializeComponent();
        }



        public void transferir()
        {
            SacarDeposito_cs destino = new SacarDeposito_cs(txbPagamento.Text);
            destino.Show();


        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            transferir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbCodigoEmpresa.Text == "")
            {
                MessageBox.Show("Preencha código empresa ", "Atenção!", MessageBoxButtons.OK);
                txbCodigoEmpresa.Focus();
                return;
            }
            else if (dtpDataPagamento.Text == "")
            {
                MessageBox.Show("Preencha o campo data do pagamento", "Atenção!", MessageBoxButtons.OK);
                dtpDataPagamento.Focus();
                return;
            }
            else if (txbPagamento.Text == "")
            {
                MessageBox.Show("Preencha o campo depositar salário", "Atenção!", MessageBoxButtons.OK);
                txbPagamento.Focus();
                return;
            }
            string sql = "INSERT INTO TransferenciaEmpresa (CodigoCadastroEmpresa,DataPagamento,DepositoSalario,Relatorio)" +
                   " VALUES(@CodigoCadastroEmpresa,@DataPagamento,@DepositoSalario,@Relatorio)";
            try
            {
                SqlCommand c = new SqlCommand(sql, con);
                c.Parameters.Add(new SqlParameter("@CodigoCadastroEmpresa", this.txbCodigoEmpresa.Text));
                c.Parameters.Add(new SqlParameter("@DataPagamento", this.dtpDataPagamento.Text));
                c.Parameters.Add(new SqlParameter("@DepositoSalario", this.txbPagamento.Text));
                c.Parameters.Add(new SqlParameter("@Relatorio", this.txbRegistro.Text));


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
                FrmTelaInicial cop = new FrmTelaInicial();
                cop.Show();
            }

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txbCodigoEmpresa.Text = "";
            dtpDataPagamento.Text = "";
            txbPagamento.Text = "";
            txbRegistro.Text = "";

        }
    }

}


