using System;

namespace Polimorfismo
{
    public class Carro : MeioTransporte
    {
        public string Marca { get; set; }

        public override void Mover()
        {
            Console.WriteLine(Modelo + " andando....");
        }
    }
}