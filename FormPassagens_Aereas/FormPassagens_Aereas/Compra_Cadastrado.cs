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
    public partial class Compra_Cadastrado : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=;Initial catalog=;integrated security=true");

        SqlCommand com = new SqlCommand();
        public Compra_Cadastrado()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {


        }


        private void Compra_Cadastrado_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Passageiro(Nome,Cpf,Telefone,Email,Senha,DataNascimento) VALUES " +
                "(@Nome,@Cpf,@Telefone,@Email,@Senha,@DataNascimento)";
            try
            {
                SqlCommand c = new SqlCommand(sql, con);
                c.Parameters.Add(new SqlParameter("@Nome", this.txbNome.Text));
                c.Parameters.Add(new SqlParameter("@Cpf", this.mtbxCpf.Text));
                c.Parameters.Add(new SqlParameter("@Telefone", this.mtxbTelefone.Text));
                c.Parameters.Add(new SqlParameter("@Email", this.txbEmail.Text));
                c.Parameters.Add(new SqlParameter("@Senha", this.txbSenha.Text));
                c.Parameters.Add(new SqlParameter("@DataNascimento", this.dtpDataNascimento.Text));
                ;

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
                Escolha_CompraCadastrado tc = new Escolha_CompraCadastrado();
                tc.Show();

            }

        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {

            con.Open();
            if (txbCodigoCliente.Text != "")
            {
                SqlCommand cmd = new SqlCommand("select Nome,Cpf,Telefone,Email, Senha DataNascimento from Passageiro where CodigoPassageiro=@CodigoPassageiro", con);
                cmd.Parameters.AddWithValue("@CodigoPassageiro", int.Parse(txbCodigoCliente.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    txbNome.Text = da.GetValue(0).ToString();
                    mtbxCpf.Text = da.GetValue(1).ToString();
                    mtxbTelefone.Text = da.GetValue(2).ToString();
                    txbEmail.Text = da.GetValue(3).ToString();
                    txbSenha.Text = da.GetValue(4).ToString();


                }
                con.Close();

            }
        }

    }
}


