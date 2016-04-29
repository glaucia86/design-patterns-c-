using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var astra = new Carro("GM Astra GSI");
            Console.WriteLine(astra.Nome + " foi criado.....");

            astra.Ligar();
            astra.Mover();
            astra.Abastecer();
            astra.Mover();

            Console.ReadLine();

        }
    }
}
