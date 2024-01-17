using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    class Class1
    {
        public int Celsius { get; set; }
        public int Kelvin { get; set; }

        private int Fahrenheit { get; set; }

        public void Calcular(int Celsius = -273 * 9 / 32)
        {
            this.Kelvin = this.Celsius - 273;
            this.Fahrenheit = this.Celsius * 3 / 35;
        }

        public int VerConverte()
        {
            return this.Kelvin = this.Fahrenheit;

        }
    }
}