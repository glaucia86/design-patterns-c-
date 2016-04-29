using System;

namespace AbstractFactory
{
    class Program
    {
        /* Client */
        static void Main(string[] args)
        {
            /* Aqui vamos estanciar a nossa Factory */
            DbFactory db = new SqlFactory();

            var con = db.CreateConnection();
            con.Open();

            var cmd = db.CreateCommand();
            cmd.Execute();

            Console.ReadLine();
        }
    }
}
