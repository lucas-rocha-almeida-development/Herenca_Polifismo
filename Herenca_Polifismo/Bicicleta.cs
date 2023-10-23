using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herenca_Polifismo
{
    internal class Bicicleta : Veiculo
    {
        override public void Anda()
        {
            Console.WriteLine("A bicicleta esta andando!*metodo da classe filha- bicicleta*!");

        }

    }
}
