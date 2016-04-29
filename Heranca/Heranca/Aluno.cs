using System;

namespace Heranca
{
    public class Aluno : Pessoa
    {
        public int Matricula { get; set; }

        public void Estudar()
        {
            Console.WriteLine("Nome " + Nome + " estudando.");
        }
    }
}