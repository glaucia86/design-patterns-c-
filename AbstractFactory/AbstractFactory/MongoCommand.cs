using System;

namespace AbstractFactory
{
    public class MongoCommand : DbCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Executando o comando do sql do Mongo.....");
        }
    }
}