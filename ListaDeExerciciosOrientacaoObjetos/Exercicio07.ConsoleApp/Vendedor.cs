namespace Exercicio07.ConsoleApp
{
    public class Vendedor
    {
        public decimal SalarioBase { get; set; }
        public decimal Comissao { get; set; }
        public decimal Vendas { get; set; }

        public Vendedor(decimal salaioBase, decimal comissao, decimal vendas)
        {
            SalarioBase = salaioBase;
            Comissao = comissao;
            Vendas = vendas;
        }
        public decimal CalculaSalarioTotal()
        {
            return Vendas*(Comissao/100) + SalarioBase;
        }

        
    }
}