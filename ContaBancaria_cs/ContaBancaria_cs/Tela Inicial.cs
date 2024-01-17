using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaBancaria_cso 
{
    public partial class FrmTelaInicial : Form
    {
        public FrmTelaInicial()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_cs mp = new Cadastro_cs();
            mp.Show();
        }

        private void sacarEDepositarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entrada_Conta jb = new Entrada_Conta();
            jb.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroEmpresa ce = new CadastroEmpresa();
            ce.Show();
        }

        private void administraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          FinanceiroEmpresa sd = new FinanceiroEmpresa(); 
            sd.Show();
        }

        private void cartãoItauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Posso_Ajudar br = new Posso_Ajudar (); 
            br.Show();
        }
    }
}
