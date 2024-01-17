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


namespace ContaBancaria_cs
{
    public partial class SacarDeposito_cs : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=;Initial catalog=;integrated security=true");
        SqlCommand comando = new SqlCommand();
        public SacarDeposito_cs()
        {
            InitializeComponent();
            rbnDeposito.Checked = true;

        }
        public SacarDeposito_cs(string texto)
        {
            InitializeComponent();
            txbValor.Text = texto;

        }
        ClassConta objConta = new ClassConta();

        private void button1_Click(object sender, EventArgs e)
        {
            objConta.titular = txbTitular.Text;
            objConta.agencia = txbAgencia.Text;

            if (rbtnSaque.Checked)
            {
                objConta.Sacar(Convert.ToDouble(txbValor.Text));
                txbSaldo.Text = objConta.VerSaldo().ToString();
                txbValor.Text = "";
            }
            else
            {
                objConta.Depositar(Convert.ToDouble(txbValor.Text));
                txbSaldo.Text = objConta.VerSaldo().ToString();
                txbValor.Text = "";
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if (rbtnSaque.Checked)
            {
                txbSaldo.Text = (float.Parse(txbValor.Text) - float.Parse(txbSaldo.Text)).ToString();
            }
            else
            {
                txbSaldo.Text = (float.Parse(txbValor.Text) + float.Parse(txbSaldo.Text)).ToString();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txbTitular.Text == "")
            {
                MessageBox.Show("Preencha o campo Titular Conta.", "Atenção!!", MessageBoxButtons.OK);
                txbTitular.Focus();
                return;
            }
            else if (txbAgencia.Text == "")
            {
                MessageBox.Show("Preencha o Agência.", "Atenção!!", MessageBoxButtons.OK);
                txbAgencia.Focus();
                return;
            }


            string sql = "INSERT INTO TRANSFERENCIA (CodigoCliente,TitularConta,Agencia,Saldo)" +
              " VALUES(@CodigoCliente,@TitularConta,@Agencia,@Saldo)";
            try
            {
                SqlCommand c = new SqlCommand(sql, con);
                c.Parameters.Add(new SqlParameter("@CodigoCliente", this.txbCodCliente.Text));
                c.Parameters.Add(new SqlParameter("@TitularConta", this.txbTitular.Text));
                c.Parameters.Add(new SqlParameter("@Agencia", this.txbAgencia.Text));
                c.Parameters.Add(new SqlParameter("@Saldo", this.txbSaldo.Text));




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

        private void txbCodCliente_TextChanged(object sender, EventArgs e)
        {


        }

        private void txbID_TextChanged(object sender, EventArgs e)
        {

            con.Open();
            if (txbID.Text != "")
            {
                SqlCommand cmd = new SqlCommand("select TitularConta,Agencia,Saldo from Transferencia where CodigoTransferencia=@CodigoTransferencia", con);
                cmd.Parameters.AddWithValue("@CodigoTransferencia", int.Parse(txbID.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    txbTitular.Text = da.GetValue(0).ToString();
                    txbAgencia.Text = da.GetValue(1).ToString();
                    txbSaldo.Text = da.GetValue(2).ToString();
                }
                con.Close();

            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Transferencia where CodigoCliente=@CodigoCliente", nec);
            cmd.Parameters.AddWithValue("@CodigoCliente", this.txbCodCliente.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txbID.Text = "";
            txbCodCliente.Text = "";
            txbTitular.Text = "";
            txbAgencia.Text = "";
            txbSaldo.Text = "";
            txbValor.Text = "";

        }

        private void SacarDeposito_cs_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}


