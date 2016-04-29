using System;

namespace Heranca
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public void Dormir()
        {
            Console.WriteLine("Nome " + Nome + " está dormindo.");
        }
    }
}