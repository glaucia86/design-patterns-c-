using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            MeioTransporte carro = new Carro
            {
                Modelo = "Honda Civic"
            };
            carro.Mover();

            MeioTransporte aviao = new Aviao
            {
                Modelo = "F22"
            };
            aviao.Mover();

            Console.ReadLine();
        }
    }
}
