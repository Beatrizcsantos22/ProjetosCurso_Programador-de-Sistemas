using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class1 objCoverte = new Class1();
        int cel, kel, fah;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            cel = int.Parse(txbCelsius.Text);
            kel = cel + 273;
            fah = ((((cel * 9) / 5 + 32)));
            txbKelvin.Text = kel.ToString();
            txbFahrenheit.Text = fah.ToString();

        }
    }
}
