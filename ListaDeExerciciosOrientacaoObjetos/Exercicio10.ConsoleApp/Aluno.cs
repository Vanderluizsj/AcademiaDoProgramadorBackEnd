using Exercicio10.ConsoleApp;
namespace Exercicio10.ConsoleApp
{
    public class Aluno
    {
        public Nota Nota1 { get; set; }
        public Nota Nota2 { get; set; }

        public Aluno(Nota nota1, Nota nota2)
        {
            Nota1 = nota1;
            Nota2 = nota2;
        }
        public decimal CalculaNota()
        {
            return (Nota1.CalculaValorNota()+Nota2.CalculaValorNota())/(Nota1.Peso+Nota2.Peso);
        }

        
    }

    
}