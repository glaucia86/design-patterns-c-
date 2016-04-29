using System;
using System.Runtime.InteropServices;

namespace Encapsulamento
{
    public class Bateria
    {
        
    }

    public class SuperBateria : Bateria
    {
        
    }

    public class Motor
    {
        
    }

    public class Carro
    {
        /* Aqui estamos encapsulando os detalhes do carro 
         Ou seja, isso é uma composição de componentes */
        private Motor _motor;
        private Bateria _bateria;
        private string _nome;

        public string Nome
        {
            get { return _nome; }
        }

        public void Ignicao()
        {
            Console.WriteLine("Dando ignição no carro......");
        }

        /*Construtor*/
        public Carro(string nome)
        {
            Console.WriteLine("Criando o objeto Carro.....");
            _motor = new Motor();
            _bateria = new Bateria();
            _nome = nome;
        }
        public int NumeroPneus()
        {
            return 4;
        }

        public void Abastecer()
        {
            Console.WriteLine("Abastecer carro.....");
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando carro....");
            Ignicao();
        }

        public void Mover()
        {
            Console.WriteLine("Movendo carro....");
        }
    }
}