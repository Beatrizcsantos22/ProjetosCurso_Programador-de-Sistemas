using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaForEath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        //Inicializar vetor para 5 posições
        String[] Local = new string[5];
        int n;




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Inicia  o contador para o posicionamento do indice
            for (n = 0; n < Local.Length; n++)
            {
                // Testa se a posição está vazia
                if (Local[n] == null)
                {

                    //Testa o TextBox se foi preenchido
                    if (txbVisitar.Text != "")
                    {
                        //Vetor recebe conteudo do TextBox
                        Local[n] = txbVisitar.Text;
                        //Limpa o textbox e foca nele novamente
                        txbVisitar.Text = "";
                        txbVisitar.Focus();
                        //Interromper o contador
                        break;
                    }
                    else
                    {
                        //TextBox não está prenchido mostrar a mensagem
                        MessageBox.Show("Prencha o local desejado", "",
                           MessageBoxButtons.OK);
                        txbVisitar.Focus();
                        break;
                    }
                }

            }
            // Testar se já foi preenchido o vetor inteiro
            if (n == Local.Length)
            {
                MessageBox.Show("Já foram incluidos cincos locais.", "", MessageBoxButtons.OK);
                txbVisitar.Text = "";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpar barras zerar o vetor 
            for (n = 0; n < Local.Length; n++)
            {
                Local[n] = null;
            }
            lbsLocais.Items.Clear();
            //Zerar o contador
            n = 0;
            //Mostrar a mensagem
            MessageBox.Show("O vetor e a lista estão limpas ", "", MessageBoxButtons.OK);
            txbVisitar.Focus();
            btnMostrar.Enabled = true;
            
            //Clicar Mostar e digitar esse codigo!!!!!
        }
       //Mostrar a primeira posição está vazia
        if (Local[0]==null)
            {
         // Mostrar mensagem e a lista que esta vazia
         MessageBox.Show("Sua está vazia ,","",MessagemBox.Buttons.OK);
            txbVisitar.Focus();
            }
     else
    {
//Percorrer todas as posições do vetor
//Atribuindo a variavel do seu conteudo
foreach(string m in Local)
        {
 //DEsabilitar o botão mostrar
 btnMonstrar.Enable=false
        //Tratamento de erros e execuções 
        //Se acontecer erro dentro do try passsa o controle para o cath
        try{
}
lsbLocais.Items.add(m){


catch (ArgumentException)
     //No tratamento de execões o progrmador ira 
     // que desenvolver o que quee fazer 

    MessageBox.Show("Sua lista esta imcompleta ", "", MessageBoxButtons.OK);
    //Limpar a lista Box
    lsbLocais.Items.Clear();
    //Dar o foco no text Box 
    txbVisitar.Focus();
    //Habilitar o botão mostrar 
    btnMostrar.Enable = true;
    //Interromper o foreacth
    break;

    }

}

}

}

}

}
