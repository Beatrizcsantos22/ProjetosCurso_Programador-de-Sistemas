using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPassagens_Aereas
{
    public partial class Escolha_CompraCadastrado : Form
    {
        public Escolha_CompraCadastrado()
        {
            InitializeComponent();
            rbtnIda.Checked = false;
            rbtnIdaVolta.Checked = false;
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblIda_CheckedChanged(object sender, EventArgs e)
        {
            Ida bc = new Ida();
            bc.Show();
        }

        private void lblIda_CheckedChanged_1(object sender, EventArgs e)
        {
            Ida max = new Ida();
            max.Show();
        }

        private void lblIdaVolta_CheckedChanged(object sender, EventArgs e)
        {
            IdaVolta Chole = new IdaVolta();
            Chole.Show();
        }
    }
}
