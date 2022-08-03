using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //strategy
    public interface ICriacao
    {
        //assinatura de método
        void CreatePokemon();
        //CreatePokemon que vai receber os dados e vai fazer a impressao dele
    }
}
