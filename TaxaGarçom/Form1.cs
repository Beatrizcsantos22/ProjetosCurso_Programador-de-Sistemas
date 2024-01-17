using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxaGarçom
{
    public partial class txbTotal : Form
    {
        public txbTotal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Convert.ToDouble(txbDespesa.Text) * 1.10).ToString("N");

        }
    }
}
