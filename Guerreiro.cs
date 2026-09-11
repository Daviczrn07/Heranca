using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    internal class Guerreiro : Personagem
    {
        public int Defesa { get; set; }

        public Guerreiro(string nome, int pontosDeVida, int forcaDeAtaque, int defesa)
            : base(nome, pontosDeVida, forcaDeAtaque)
        {
            Defesa = defesa;
        }
        public override void Atacar(Personagem alvo)
        {
            int danoBase = ForcaDeAtaque;
            int danoComBonus = (int)(danoBase * 1.2);

            Console.WriteLine($"{Nome} usa um Poderoso Golpe (bônus de 20% de dano)!");
            AplicarDano(alvo, danoComBonus);
        }
    }
}
