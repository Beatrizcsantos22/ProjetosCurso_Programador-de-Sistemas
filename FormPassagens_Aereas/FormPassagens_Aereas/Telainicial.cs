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
    public partial class frmTelaInicial : Form
    {
        public frmTelaInicial()
        {
            InitializeComponent();
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro novo = new FrmCadastro();
            novo.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void relatarProblemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ocorrencia form = new Ocorrencia();
            form.ShowDialog();
        }

        private void consultarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar bn = new Consultar();
            bn.ShowDialog();
        }

        private void frmTelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void comprarJáCadastradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compra_Cadastrado mt = new Compra_Cadastrado();
            mt.Show();
        }
    }
}
