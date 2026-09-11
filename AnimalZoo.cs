using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public class AnimalZoo
    {
        public virtual void EmitirSom()
        {
            Console.WriteLine("animal emitindo som");
        }
    }
    public class Leao : AnimalZoo
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Leão: Roar!");
        }
    }

    public class Macaco : AnimalZoo
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Macaco: UGH UGH AAH AAH!");
        }
    }

    public class Cobra : AnimalZoo
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Cobra: SSSSSSSSSSSSS!");
        }
    }
}
