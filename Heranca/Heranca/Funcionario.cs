using System;

namespace Heranca
{
    public class Funcionario : Pessoa
    {
        public string Departamento { get; set; }

        public void Trabalhar()
        {
            Console.WriteLine("Nome " + Nome + " trabalhando.");
        }
    }
}