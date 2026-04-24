namespace PedraPapelTesoura.ConsoleApp.entidades
{
    public class Jogador
    {
        public static int ObterEscolha()
        {
            ConsoleColor previousColor = ConsoleColor.White;
            int escolhaDoJogador;
            
            Console.WriteLine("-----------------------------");
            Console.WriteLine("  Escolha uma opção abaixo:  ");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1 - Pedra");
            Console.WriteLine("2 - Papel");
            Console.WriteLine("3 - Tesoura");
            Console.WriteLine("-----------------------------");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Jogada: ");
            Console.ForegroundColor = previousColor;
            while (!int.TryParse(Console.ReadLine(), out escolhaDoJogador)
             || escolhaDoJogador < 1 || escolhaDoJogador > 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido, tente novamente!");
                Console.ForegroundColor = previousColor;
                Console.Write("Digite uma opção válida: ");
                
            }
            return escolhaDoJogador;
        }
    }
}