using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    internal class Retangulo : FormaGeometrica
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public override double CalcularArea()
        {
            return Altura * Largura;
        }
    }
}
