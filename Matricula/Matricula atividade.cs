using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaAluno
{
    public partial class FrmMatricula : Form
    {
        public FrmMatricula()
        {
            InitializeComponent();
            // Mostrar a data corrente no formato dos ponto: dd/mm/aaa (ToShortDateString)
            // Deixar a label vazia do campo da propriedade Text
            lblHoje.Text = "Hoje é dia: " +
                DateTime.Now.ToShortDateString();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void FrmMatricula_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIndentificar_Click(object sender, EventArgs e)
        {
            if (txdNome.Text == String.Empty)
            {
                //Mostrar mensagem se ficar o textbox vazio
                MessageBox.Show("Todos os dados solicitados devem ser informados.",
                    "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // O objeto da classe irá armazenar o resultado do calculo
                // Data atual menos dtpNascimento que é a data escolhida do nascimento
                //TimeSpam: Representa um intervalo de tempo
                TimeSpan TsQuantidadedia = DateTime.Now.Date - dtpNascimento.Value;

                //Converter o resultado em anos
                //Days => propriedade do objeto de classe TimeSpam 
                // o resultado em dias 
                int idade = (TsQuantidadedia.Days / 365);

                // Mostrar o resultado da idade completa
                //deixar a Label vazia no campo do teste
                lblIdadeAtual.Text = "Sua idade atual é : " + idade + " Anos completos.";

                //Qualificação pela idade 
                //Mostrar na label o resultado

                if (idade > 17)
                {
                    lblIndentifica.Text = "Adulto";

                }
                else if (idade > 13)
                {
                    lblIndentifica.Text = "Juvenil B";
                }
                else if(idade >10)
                {
                    lblIndentifica.Text = "Juvenil A ";
                }
                 else if (idade > 7)
                {
                    lblIndentifica.Text = "Juvenil B";
                }
                else if (idade >= 5)
                {
                    lblIndentifica.Text = "Juvenil A";
                }
                else
                {
                    lblIndentifica.Text = "Não existe categoria";
                }
            }
        }
    }
}


