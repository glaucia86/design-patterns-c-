using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var con = new SqlConnection();
            con.Open();

            var cmd = new SqlCommand();
            cmd.Execute();

            Console.ReadLine();
        }
    }
}
