namespace Polimorfismo
{
    public class Aviao : MeioTransporte
    {
        public override void Mover()
        {
            System.Console.WriteLine(Modelo + "" + " voando....");
        }
    }
}