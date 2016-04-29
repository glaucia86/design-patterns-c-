namespace Abstracao
{
    public class Notebook
    {
        private string _nome;

        public USB Porta1
        {
            get { return null; }
            set { }
        }

        public USB Porta2
        {
            get { return null; }
            set { }
        }

        public USB Porta3
        {
            get { return null; }
            set { }
        }

        public string GetNome()
        {
            return _nome;
        }

        /*Criando aqui uma classe do tipo 'abstract' */

        public abstract class USB
        {
            public abstract void Plugar();
        }

        public Notebook(string nome)
        {
            _nome = nome;
        }   
    }

    public class iPhone : Notebook.USB
    {
        public override void Plugar()
        {
            
        }
    }

    public class Mouse : Notebook.USB
    {
        public override void Plugar()
        {

        }
    }

    public class Teclado : Notebook.USB
    {
        public override void Plugar()
        {

        }
    }

    public class Tablet : Notebook.USB
    {
        public override void Plugar()
        {

        }
    }
}