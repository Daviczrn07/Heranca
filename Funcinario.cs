using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }


        public virtual double CalcularBonusAnual()
        {
            return Salario * 0.10;
        }

    }
    public class Gerente : Funcionario
    {
        public new double CalcularBonusAnual()
        {
            return (Salario * 0.15) + 1000.0;
        }
    }

    public class Desenvolvedor : Funcionario
    {
        public new double CalcularBonusAnual()
        {
            return Salario * 0.12;
        }
    }
}

