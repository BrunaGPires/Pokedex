using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //context
    public class PokedexContext
    {
        //instancia de icriacao
        private ICriacao _icriacao;

        public PokedexContext()
        {
        }

        //escolhe o pokemon
        public void DefinePokemon(ICriacao icriacao)
        {
            _icriacao = icriacao;
        }
        
        //imprime o método no console
        public void CriarDadosPokemon()
        {
            _icriacao.CreatePokemon();
        }
    }
}
