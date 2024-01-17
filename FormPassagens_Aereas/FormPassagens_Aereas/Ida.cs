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
    public partial class Ida : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=;Initial catalog=;integrated security=true");


        public Ida()
        {
            InitializeComponent();

        }

        String[] passagem = new string[5];
        int n;
        private void Ida_Load(object sender, EventArgs e)
        {
            FillComboSeacrhCode();
        }

        private void FillComboSeacrhCode()
        {
            cbxDestino.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Lugares from Destino";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            foreach (DataRow dr in dt.Rows)
            {
                cbxDestino.Items.Add(dr["Lugares"].ToString());
            }

            con.Close();
        }

        private void lblConfirmar_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter("Select * from Destino where Lugares ='" + cbxDestino.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txbValor.Text = dt.Rows[0][2].ToString();

            con.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbxHorário_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCarrinho_Click(object sender, EventArgs e)
        {
            txbValorTotal.Text = (float.Parse(txbNumeroPassagem.Text) * float.Parse(txbValor.Text)).ToString();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txbIda.Text = DateTime.Today.ToShortDateString();

            for (n = 0; n < passagem.Length; n++)
            {
                if (passagem[n] == null)
                {
                    if (txbNumeroPassagem.Text != "")
                    {
                        passagem[n] = txbNumeroPassagem.Text;
                        txbNumeroPassagem.Text = "";
                        txbNumeroPassagem.Focus();
                        break;
                    }
                    if (n == passagem.Length)
                    {
                        MessageBox.Show("Você pode comprar até 5 passagens!!", "", MessageBoxButtons.OK);
                        txbNumeroPassagem.Text = "";
                    }

                }
            }
        }


        private void btnComprar_Click(object sender, EventArgs e)
        {

            if (txbCod.Text == "")
            {
                MessageBox.Show("Click em 'Mostrar Código' para realizar a compra", "Atenção!!", MessageBoxButtons.OK);
                txbCod.Focus();
                return;
            }
            else if (txbIda.Text == "")
            {
                MessageBox.Show("Selecione uma data no campo Data de Ida", "Atenção!!", MessageBoxButtons.OK);
                txbIda.Focus();
                return;
            }
            else if (cbxAtual.Text == "")
            {
                MessageBox.Show("Selecione o Campo Localização Atual.", "Atenção!!", MessageBoxButtons.OK);
                cbxAtual.Focus();
                return;
            }

            else if (cbxDestino.Text == "")
            {
                MessageBox.Show("Selecione o campo Destino.", "Atenção!!", MessageBoxButtons.OK);
                cbxDestino.Focus();
                return;
            }

            else if (txbValor.Text == "")
            {
                MessageBox.Show("Click no 'Selecionar Destino' para ver o valor da Passagem", "Atenção!!", MessageBoxButtons.OK);
                txbValor.Focus();
                return;
            }
            else if (txbNumeroPassagem.Text == "")
            {
                MessageBox.Show("Preencha o campo Número de Passagens.", "Atenção!!", MessageBoxButtons.OK);
                txbNumeroPassagem.Focus();
                return;
            }
            else if (txbValorTotal.Text == "")
            {
                MessageBox.Show("Click no 'Adicionar Passagem'para obter o valor total de sua passagem", "Atenção!!", MessageBoxButtons.OK);
                txbNumeroPassagem.Focus();
                return;
            }
            else if (cbxHorario.Text == "")
            {
                MessageBox.Show("Selecione o horário de embarque.", "Atenção!!", MessageBoxButtons.OK);
                cbxHorario.Focus();
                return;
            }
            string sql = "INSERT INTO Comprovante(CodigoPassageiro, DataIda,LocalizacaoAtual,Destino,ValorPassagem,NumeroPassagem,ValorTotal,HorarioEmbarque) VALUES " +
                "(@CodigoPassageiro,@DataIda,@LocalizacaoAtual,@Destino,@ValorPassagem,@NumeroPassagem,@ValorTotal,@HorarioEmbarque)";
            try
            {
                SqlCommand c = new SqlCommand(sql, con);
                c.Parameters.Add(new SqlParameter("@CodigoPassageiro", txbCod.Text));
                c.Parameters.Add(new SqlParameter("@DataIda", this.txbIda.Text));
                c.Parameters.Add(new SqlParameter("@LocalizacaoAtual", this.cbxAtual.Text));
                c.Parameters.Add(new SqlParameter("@Destino", this.cbxDestino.SelectedItem));
                c.Parameters.Add(new SqlParameter("@ValorPassagem", this.txbValor.Text));
                c.Parameters.Add(new SqlParameter("@NumeroPassagem", this.txbNumeroPassagem.Text));
                c.Parameters.Add(new SqlParameter("@ValorTotal", this.txbValorTotal.Text));
                c.Parameters.Add(new SqlParameter("@HorarioEmbarque", this.cbxHorario.SelectedItem));

                con.Open();
                c.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Compra finalizada com sucesso!!, Verifique seu email.", "Atenção!!", MessageBoxButtons.OK);


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro!!" + ex);
            }
            finally
            {
                con.Close();
                frmTelaInicial tc = new frmTelaInicial();
                tc.Show();

            }
        }

        private void txbCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }

        private void btnApagarTudo_Click(object sender, EventArgs e)
        {
            txbIda.Text = "";
            cbxAtual.Items.Clear();
            cbxDestino.Items.Clear();
            cbxHorario.Items.Clear();
            txbNumeroPassagem.Text = "";
            txbValor.Text = "";
            txbValorTotal.Text = "";

        }

        private void txbNumeroPassagem_TextChanged(object sender, EventArgs e)
        {

        }
    }

}








