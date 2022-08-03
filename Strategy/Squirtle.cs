using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //classe concreta
    public class Squirtle : ICriacao
    {
        public void CreatePokemon()
        {
            Console.WriteLine("Squirtle\nQuando se sente ameaçado, puxa seus membros para dentro de sua concha e borrifa água de sua boca." +
                "\nPokemon tipo Água. \nHabilidades: WaterGun.");
        }
    }
}
