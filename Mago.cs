using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    internal class Mago : Personagem
    {
        public int PontoDeMagia { get; set; }

        public Mago(string nome, int pontosDeVida, int forcaDeAtaque, int pontosDeMagia)
           : base(nome, pontosDeVida, forcaDeAtaque)
        {
            PontoDeMagia = pontosDeMagia;
        }

        public override void Atacar(Personagem alvo)
        {
            int dano = ForcaDeAtaque;
            AplicarDano(alvo, dano);

            int mpRecuperado = (int)(dano * 0.1);
            PontoDeMagia += mpRecuperado;
            Console.WriteLine($"{Nome} recuperou {mpRecuperado} de MP! MP atual: {PontoDeMagia}");
        }
    }
}
