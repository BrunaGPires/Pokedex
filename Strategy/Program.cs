using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PokedexContext pkx = new PokedexContext();

            Console.WriteLine("POKEDEX INICIADA...");

            char ch;
            do
            {
                Console.WriteLine("\nEscolha um pokemon: ");
                Console.WriteLine("1-Charmander | 2-Bulbasauro | 3-Squirtle");
                switch (Console.ReadLine())
                {
                    case "1":
                        pkx.DefinePokemon(new Charmander());
                        break;
                    case "2":
                        pkx.DefinePokemon(new Bulbasauro());
                        break;
                    case "3":
                        pkx.DefinePokemon(new Squirtle());
                        break;
                }
                pkx.CriarDadosPokemon();
                Console.WriteLine();
                Console.WriteLine("Gostaria de ver outro pokemon? [s/n]");
                ch = char.Parse(Console.ReadLine());
            }
            while (ch == 's');
            Console.WriteLine();
            Console.WriteLine("DESLIGANDO POKEDEX...");

            
        }
    }
}
