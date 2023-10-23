using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Herenca_Polifismo
{ // classe mae
    internal class Veiculo
    {
        virtual public void Anda()
        {
            
            Console.WriteLine("O Veiculo está andando *Metodo classe mãe*!!");
        }
    }
}
