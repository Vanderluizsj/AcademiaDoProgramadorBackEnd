namespace Exercicio05.ConsoleApp
{
    public class Esfera
    {
        public double Raio { get; set; }


        public Esfera(double raio)
        {
            Raio = raio;
        }
        public double ObterVolume()
        {
            double pi = Math.PI;
            double raioNaTerceira = Math.Pow(Raio, 3);
            return ((4 * pi) * raioNaTerceira)/3;
        }
    }
}