using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetorUni
{
    public partial class FrmVetor : Form
    {
        public FrmVetor()
        {
            InitializeComponent();


        }
        //Incializa o vetor para 100 posição
        public int[] lista = new int[100];

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Carregar a posição 0 do indice do vetor o valor digitado 
            //no TextBox 
            lista[0] = Convert.ToInt32(txdNumero.Text);
            // Incializar o componente ProgresTar
            pgbProgresso.Minimum = 0;
            pgbProgresso.Maximum = 100;
            pgbProgresso.Value = 0;
            //Incia a contar a partir do indice 1 até uma posição anterior 
            // ao tamanho do vetor.
            //Não podemos ir até 100 pois os indices do vetor vão de 0 a 99
            for (int i = 1; i < lista.Length; i++)
            {
                //Carregar na posição i do vetor a soma da posição anterior 
                // mas o valor do TextBox 
                lista[i] = lista[i - 1] + Convert.ToInt32(txdNumero.Text);
                // Incrementar a progreshar
                pgbProgresso.Value++;


            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            // Incializa o componente progreshar
            pgbProgresso.Minimum = 0;
            pgbProgresso.Maximum = 100;
            pgbProgresso.Value = 0;
            //Incializar a exibição dos valores na ListBox
            for (int i = 0; i < lista.Length; i++) 
            {
                //Carrega na ListBox as informaçãoes no vetor lista
                //Começando pela posição zero do indice
                lsbLista.Items.Add(lista[i]);
                //Incrementar a progreshar
                pgbProgresso.Value++;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpar TextBox , ListBox,Progreshar
              txdNumero.Text = "";
            lsbLista.Items.Clear();
            pgbProgresso.Value = 0;
        }
    }
}