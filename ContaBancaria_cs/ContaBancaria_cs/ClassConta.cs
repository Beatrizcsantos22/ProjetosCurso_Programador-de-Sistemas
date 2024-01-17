using System;
using System.Windows.Forms;

namespace ContaBancaria_cs
{
    internal class ClassConta
    {
        public ClassConta()
        {
        }
        public string titular { get; set; }
        public string cpf { get; set; }

        private double saldo;
        public string numconta { get; set; }
        public string agencia { get; set; }

        public void Depositar(double valor)
        {
            this.saldo = this.saldo + valor;
        }

        public void Sacar(double valor)
        {
            this.saldo = this.saldo - valor;
        }

        public double VerSaldo()
        {
            return this.saldo;
        }

        public double  Alterar(double valor)
        {
            this.Depositar(saldo + valor);
            return this.saldo;
            this.Sacar(this.saldo -valor);
            return this.saldo;

        }
    }
}