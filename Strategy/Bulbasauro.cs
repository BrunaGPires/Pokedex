using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //classe concreta
    internal class Bulbasauro : ICriacao
    {
        public void CreatePokemon()
        {
            Console.WriteLine("Bulbasauro\nEnquanto é jovem, usa os nutrientes que estão armazenados na semente nas costas para crescer." +
                "\nPokemon tipo Grama. \nHabilidades: VineWhip.");
        }
    }
}
