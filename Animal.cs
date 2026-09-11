using System;
using System.Collections.Generic;
using System.Text;

namespace Herança

{
    public class Animal
    {
        public string Nome { get; set; }

        public void Comer()
        {
            Console.WriteLine("O Animal está comendo");
        }
    }

    public class Gato : Animal
    {
        public void Miar()
        {
            Console.WriteLine("Miau, Meow!");
        }
    }

    public class Cachorro : Animal
    {
        public void Latir()
        {
            Console.WriteLine("Au Au!");
        }
    }
}
