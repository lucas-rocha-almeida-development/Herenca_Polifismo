using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herenca_Polifismo
{//classe filha
    internal class Carro : Veiculo
    {
        override public void Anda()
        {
            
            Console.WriteLine("O Carro esta andando!*metodo classe filha- Carro*!");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("*****Podemos chamar 2 metodos especificos na classe filha, utilizando o base.metodo\n" +
                "definido na classe mae*******");
            Console.WriteLine("**************************************************************");
            base.Anda();//metodo da classe mae sera chamado

        }

    }
}
