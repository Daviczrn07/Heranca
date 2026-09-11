namespace Herança
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cachorro meuDog = new Cachorro();

            meuDog.Nome = "Brunão";
            Console.WriteLine($"Cachorro: {meuDog.Nome}");
            meuDog.Comer();
            Console.WriteLine($"{meuDog.Nome}:");
            meuDog.Latir();

            Gato meuGato = new Gato();

            meuGato.Nome = "Davizão";
            Console.WriteLine($"Gato: {meuGato.Nome}");
            meuGato.Comer();
            Console.WriteLine($"{meuGato.Nome}:");
            meuGato.Miar();


        }
    }
}
