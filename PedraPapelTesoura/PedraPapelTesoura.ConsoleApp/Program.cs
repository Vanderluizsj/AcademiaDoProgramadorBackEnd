using System.Security.Cryptography;

string? jogarNovamente;
int escolhaComputador = 0;
const int pedra = 1;
const int papel = 2;
const int tesoura = 3;
string[] opcoes = {"", "Pedra", "Papel", "Tesoura"};


do
{
    int escolhaDoJogador = 0;

    ConsoleColor previousColor = ConsoleColor.White;


    Console.Clear();
    Console.WriteLine("-----------------------------");
    Console.WriteLine("Pedra, Papel, Tesoura");
    Console.WriteLine("-----------------------------");
    Console.WriteLine("1 - Pedra");
    Console.WriteLine("2 - Papel");
    Console.WriteLine("3 - Tesoura");
    Console.WriteLine("-----------------------------");
    Console.Write("Digite uma opção válida: ");

    //1. escolha jogador
    while (!int.TryParse(Console.ReadLine(), out escolhaDoJogador))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Valor inválido, tente novamente!");
        Console.ForegroundColor = previousColor;
    }

    //2. escolha computador
    escolhaComputador = RandomNumberGenerator.GetInt32(1, 4);    

    //3. vencedor
    if (escolhaDoJogador == escolhaComputador)
    {
        Console.WriteLine($"Empate! O computador e você escolheram {opcoes[escolhaComputador]}");
    } 
    else if (escolhaDoJogador == pedra)
    {
        if (escolhaComputador == papel)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Você perdeu!" +
            $" Você escolheu {opcoes[escolhaDoJogador]} e o computador escolheu {opcoes[escolhaComputador]}");
            Console.WriteLine("----------------------------------------");
        }
        else
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Parabens você Venceu!" +
            $" Você escolheu {opcoes[escolhaDoJogador]} e o computador escolheu {opcoes[escolhaComputador]}");
            Console.WriteLine("----------------------------------------");
        }
    }
    else if (escolhaDoJogador == papel)
    {
        if (escolhaComputador == tesoura)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Você perdeu!" +
            $" Você escolheu {opcoes[escolhaDoJogador]} e o computador escolheu {opcoes[escolhaComputador]}");
            Console.WriteLine("----------------------------------------");
        }
        else
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Parabens você Venceu!" +
            $" Você escolheu {opcoes[escolhaDoJogador]} e o computador escolheu {opcoes[escolhaComputador]}");
            Console.WriteLine("----------------------------------------");
        }
    }
    else if (escolhaDoJogador == tesoura)
    {
        if (escolhaComputador == pedra)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Você perdeu!" +
            $" Você escolheu {opcoes[escolhaDoJogador]} e o computador escolheu {opcoes[escolhaComputador]}");
            Console.WriteLine("----------------------------------------");
        }
        else
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Parabens você Venceu!" +
            $" Você escolheu {opcoes[escolhaDoJogador+1]} e o computador escolheu {opcoes[escolhaComputador+1]}");
            Console.WriteLine("----------------------------------------");
        }
    }


    System.Console.WriteLine("Deseja jogar novamente? 's' ou 'n'");
    jogarNovamente = Console.ReadLine()?.ToLower();

} while (jogarNovamente == "s");