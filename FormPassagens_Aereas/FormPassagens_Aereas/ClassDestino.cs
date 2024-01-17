using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPassagens_Aereas
{
    class ClassDestino
    {
        public ClassDestino() { }

        public ClassDestino (int codigoDestino,int codigoPassageiro,int codigoPassagem, string lugares, decimal valorDestino)
        {
            this.CodigoDestino = codigoDestino;
            this.CodigoPassageiro = codigoPassageiro;
            this.CodigoPassagem = codigoPassagem;
            this.Lugares = lugares;
            this.ValorDestino = valorDestino;
        }

        public int CodigoDestino { get; set; }
        public int CodigoPassageiro { get; set; }
        public int CodigoPassagem{ get; set; }

        public string Lugares{ get; set; }
        public decimal ValorDestino { get; set; }

    }
}
