using System;

namespace AbstractFactory
{
    public class MongoConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("Método Open do Mongo Connection foi chamado...");
        }
    }
}