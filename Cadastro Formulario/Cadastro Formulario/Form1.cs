using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            lblDataNascimento.Text = "A Data de nascimento é  : " +
            DateTime.Now.ToShortDateString();
            rdbManha.Checked = false;
            rdbTarde.Checked = false;
            rbdNoite.Checked = false;
        }
        DateTime DNasc;
        String[] disciplinas = new string[9];
        int n;
        bool rbManha, rbTarde, rbNoite;
        int quantidade;
        int preenche = 0;
        string[] disciplina = new string[15];
        string nome, cpf, endereco, escola, materias;

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txbNome.Text = "";
            nome = "";
            txbCpf.Text = "";
            cpf = "";
            txbEndereco.Text = "";
            endereco = "";
            lblData .Value = DateTime.Now.Date;
            txbEscola.Text = "";
            escola = "";
            rdbManha.Checked = false;
            rbManha = false;
            rdbTarde.Checked = false;
            rbTarde = false;
            rbdNoite.Checked = false;
            rbNoite = false;
            txbQuantidade.Text = "";
            materias = "";
            lstLista .Items.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int i, x;
            txbNome.Text = nome;
            txbCpf.Text = cpf;
            txbEndereco.Text = endereco;
            lblData .Value = DNasc;
            txbEscola.Text = escola;
            rdbManha.Checked = rbManha;
            rdbTarde.Checked = rbTarde;
            rbdNoite.Checked = rbNoite;
            txbQuantidade.Text = materias;
            x = Convert.ToInt32(txbQuantidade.Text);
            for (i = 0; i < x; i++)
            {
                lstLista .Items.Add(disciplina[i]);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            nome = txbNome.Text;
            cpf = txbCpf.Text;
            endereco = txbEndereco.Text;
            DNasc = lblData .Value;
            escola = txbEscola.Text;
            rbManha = rdbManha.Checked;
            rbTarde = rdbTarde.Checked;
            rbNoite = rbdNoite.Checked;
            txbQuantidade.Enabled = true;
            materias = txbQuantidade.Text;
            txbNomeDisciplina.Enabled = true;

            txbNome.Text = "";
            txbCpf.Text = "";
            txbEndereco.Text = "";
            lblData.Value = DateTime.Now.Date;
            txbEscola.Text = "";
            rdbManha.Checked = false;
            rdbTarde.Checked = false;
            rbdNoite.Checked = false;
            lstLista .Items.Clear();
        }

        private void lblQuantidade_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            TimeSpan tsdias = DateTime.Now.Date - lblData.Value;
            int dias = tsdias.Days;
            if (txbNome.Text == "")
            {
                MessageBox.Show("Preencha o campo nome.", "Atenção!", MessageBoxButtons.OK);
                txbNome.Focus();
                return;
            }
            else if (txbCpf.Text == "")
            {
                MessageBox.Show("Preencha o campo CPF.", "Atenção!", MessageBoxButtons.OK);
                txbCpf.Focus();
                return;
            }
            else if (txbEndereco.Text == "")
            {
                MessageBox.Show("Preencha o campo endereço.", "Atenção!", MessageBoxButtons.OK);
                txbEndereco.Focus();
                return;
            }
            else if (dias == 0)
            {
                MessageBox.Show("Data de Nascimento igual a de hoje.", "Atenção!", MessageBoxButtons.OK);
                lblData.Focus();
                return;
            }
            else if (txbEscola.Text == "")
            {
                MessageBox.Show("Preencha o campo nome da Escola.", "Atenção!", MessageBoxButtons.OK);
                txbEscola.Focus();
                return;
            }
            else if (rdbManha.Checked == false && rdbTarde.Checked == false && rbdNoite.Checked == false)
            {
                MessageBox.Show("Escolha um turno.", "Atenção!", MessageBoxButtons.OK);
                return;
            }

            if (txbQuantidade.Text == "")
            {
                MessageBox.Show("Preencha o campo quantidade.", "Atenção!", MessageBoxButtons.OK);
                txbQuantidade.Focus();
                return;
            }
            else
            {
                quantidade = Convert.ToInt32(txbQuantidade.Text);
            }
            if (preenche == quantidade)
            {
                MessageBox.Show("Limite de quantidade atingida.", "Atenção!", MessageBoxButtons.OK);
                txbNomeDisciplina.Text = "";
                txbNomeDisciplina.Enabled = false;
                return;
            }
            if (txbNomeDisciplina.Text != "")
            {
                if (preenche < quantidade)
                {
                    disciplina[preenche] = txbNomeDisciplina.Text;
                    txbQuantidade.Enabled = false;
                    txbNomeDisciplina.Text = "";
                    txbNomeDisciplina.Focus();
                    preenche++;
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo disciplina.", "Atenção!", MessageBoxButtons.OK);
                txbNomeDisciplina.Focus();
                return;
            }

        }
    }
}
