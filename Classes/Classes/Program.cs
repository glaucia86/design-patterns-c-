using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;

            var calculdora = new Calculadora();

            var resultado = calculdora.Somar(num1, num2);

            Console.WriteLine("O resultado da soma do número {0} com o número {1} é {2}", num1, num2, resultado);
            Console.ReadLine();
        }
    }
}
