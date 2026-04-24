namespace PedraPapelTesoura.ConsoleApp.entidades
{
    public class RegrasDoJogo
    {

        public static void ValidaJogada(int escolhaDoJogador, int escolhaDoComputador)
        {
            ConsoleColor previousColor = ConsoleColor.White;
            const int pedra = 1;
            const int papel = 2;
            const int tesoura = 3;
            string[] opcoes = { "", "Pedra", "Papel", "Tesoura" };


            Console.WriteLine("----------------------------------------");
            Console.WriteLine("O Jogador escolheu: " + opcoes[escolhaDoJogador]);
            Console.WriteLine("O Computador escolheu: " + opcoes[escolhaDoComputador]);

            
            if (escolhaDoJogador == escolhaDoComputador)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Empate!!!" +
                $"\nO computador e você escolheram {opcoes[escolhaDoComputador]}");
                Console.ForegroundColor = previousColor;
            }
            else if (escolhaDoJogador == pedra)
            {
                if (escolhaDoComputador == papel)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"Você perdeu!" +
                    $"\nVocê escolheu {opcoes[escolhaDoJogador]} e o computador escolheu {opcoes[escolhaDoComputador]}");
                    Console.ForegroundColor = previousColor;
                    Console.WriteLine("----------------------------------------");
                }
                else
                {
                    Console.WriteLine("----------------------------------------");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Parabens você Venceu!" +
                    $"\nVocê escolheu {opcoes[escolhaDoJogador]} e o computador escolheu {opcoes[escolhaDoComputador]}");
                    Console.ForegroundColor = previousColor;
                    Console.WriteLine("----------------------------------------");
                }
            }
            else if (escolhaDoJogador == papel)
            {
                if (escolhaDoComputador == tesoura)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"Você perdeu!" +
                    $"\nVocê escolheu {opcoes[escolhaDoJogador]} e o computador escolheu {opcoes[escolhaDoComputador]}");
                    Console.ForegroundColor = previousColor;
                    Console.WriteLine("----------------------------------------");
                }
                else
                {
                    Console.WriteLine("----------------------------------------");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Parabens você Venceu!" +
                    $"\nVocê escolheu {opcoes[escolhaDoJogador]} e o computador escolheu {opcoes[escolhaDoComputador]}");
                    Console.ForegroundColor = previousColor;
                    Console.WriteLine("----------------------------------------");
                }
            }
            else if (escolhaDoJogador == tesoura)
            {
                if (escolhaDoComputador == pedra)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"Você perdeu!" +
                    $"\nVocê escolheu {opcoes[escolhaDoJogador]} e o computador escolheu {opcoes[escolhaDoComputador]}");
                    Console.ForegroundColor = previousColor;
                    Console.WriteLine("----------------------------------------");
                }
                else
                {
                    Console.WriteLine("----------------------------------------");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Parabens você Venceu!" +
                    $"\nVocê escolheu {opcoes[escolhaDoJogador ]} e o computador escolheu {opcoes[escolhaDoComputador]}");
                    Console.ForegroundColor = previousColor;
                    Console.WriteLine("----------------------------------------");
                }
            }
        }

    }
}