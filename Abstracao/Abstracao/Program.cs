using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            var acer = new Notebook("Acer Aspire");
            acer.Porta1 = new iPhone();
            acer.Porta2 = new Mouse();
            acer.Porta3 = new Tablet();

            Console.ReadLine();
        }
    }
}
