using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herenca_Polifismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro objcarro = new Carro();
            Bicicleta objbicicleta = new Bicicleta();

            objcarro.Anda();
            objbicicleta.Anda();

            Console.ReadKey();
        }
    }
}
