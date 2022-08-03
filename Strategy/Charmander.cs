using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //classe concreta
    //as classes estao implementado a interface ICriacao
    internal class Charmander : ICriacao
    {
        public void CreatePokemon()
        {
            Console.WriteLine("Charmander\nDesde o nascimento, uma chama queima na ponta de sua cauda." +
               "\nPokemon tipo Fogo. \nHabilidades: Ember.");
        }
    }
}
