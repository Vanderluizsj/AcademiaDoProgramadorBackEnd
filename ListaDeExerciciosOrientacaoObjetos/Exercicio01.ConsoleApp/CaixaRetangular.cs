namespace Exercicio01.ConsoleApp
{
    public class CaixaRetangular
    {
        public decimal Comprimento { get; set; }
        public decimal Largura { get; set; }
        public decimal Altura { get; set; }


        public CaixaRetangular(decimal comprimento, decimal largura, decimal altura)
        {
            Comprimento = comprimento;
            Largura = largura;
            Altura = altura;
        }

        public decimal ObterVolume()
        {
            return Comprimento * Largura * Altura;
        }
    }
}