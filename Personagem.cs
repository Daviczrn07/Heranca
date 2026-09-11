using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    internal class Personagem
    {
        public string Nome { get; set; }
        public int PontosDeVida { get; set; }
        public int ForcaDeAtaque { get; set; }

        public Personagem(string nome, int pontosDeVida, int forcaDeAtaque)
        {
            Nome = nome;
            PontosDeVida = pontosDeVida;
            ForcaDeAtaque = forcaDeAtaque;
        }
        public virtual void Atacar(Personagem Alvo)
        {
            int dano = ForcaDeAtaque;
            AplicarDano(Alvo, dano);
        }
        protected void AplicarDano(Personagem alvo, int dano)
        {
            alvo.PontosDeVida -= dano;
            if (alvo.PontosDeVida < 0)
                alvo.PontosDeVida = 0;

            Console.WriteLine($"{Nome} atacou {alvo.Nome} causando {dano} de dano! " +
                               $"PV restante de {alvo.Nome}: {alvo.PontosDeVida}");
        }
        public bool EstaVivo()
        {
            return PontosDeVida > 0;

        }
    }
}
