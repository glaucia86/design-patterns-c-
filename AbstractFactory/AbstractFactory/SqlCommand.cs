using System;

namespace AbstractFactory
{
    /* Concret Product */
    public class SqlCommand : DbCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Executando o comando do sql.....");
        }
    }
}