using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            var aluno = new Aluno
            {
                Nome = "Glaucia Lemos",
                Matricula = 1235
            };
            aluno.Estudar();
            aluno.Dormir();

            var funcionario = new Funcionario
            {
                Nome = "Jake Lemos",
                Departamento = "Secretaria"
            };
            funcionario.Trabalhar();
            funcionario.Dormir();

            Console.ReadLine();
        }
    }
}
