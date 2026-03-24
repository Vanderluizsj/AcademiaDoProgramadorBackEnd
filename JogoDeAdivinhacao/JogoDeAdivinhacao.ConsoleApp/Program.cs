using System.Security.Cryptography;
/*
*/
int nivelDificuldade;
int numeroDigitado;
int contadorTentativas = 0;
int numeroSecreto = RandomNumberGenerator.GetInt32(1, 21);
ConsoleColor previousColor = Console.ForegroundColor;
previousColor = ConsoleColor.White;

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("-----------------------------------------------------------------------");
Console.WriteLine("-------------------Bem-vindo ao Jogo de Adivinhação!-------------------");
Console.WriteLine("-----------------------------------------------------------------------");
Console.ForegroundColor = Console.ForegroundColor = previousColor;


Console.WriteLine("\n---    Nesse jogo, você terá que adivinhar um número secreto!    ------\n");


Console.WriteLine("-----------------------------------------------------------------------");
Console.WriteLine("O jogador tem um número limitado de tentativas para adivinhar o número.");
Console.WriteLine("-----------------------------------------------------------------------");
Console.WriteLine(" 1 - Fácil (intervalo 1 a 20): ≈ 10 tentativas.");
Console.WriteLine(" 2 - Médio (intervalo 1 a 50): ≈ 5 tentativas.");
Console.WriteLine(" 3 - Difícil (intervalo 1 a 100): ≈ 3 tentativas.");
Console.WriteLine("-----------------------------------------------------------------------");
Console.Write("Escolha um nível de dificuldade: ");
while (!int.TryParse(Console.ReadLine(), out nivelDificuldade) || nivelDificuldade < 1 || nivelDificuldade > 3)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido, tente novamente!");
    Console.ForegroundColor = Console.ForegroundColor = previousColor;
}
if (nivelDificuldade == 1)
{
    nivelDificuldade = 10;
}
else if (nivelDificuldade == 2)
{
    nivelDificuldade = 5;
}
else
{
    nivelDificuldade = 3;
}

do
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("---------------Jogo iniciado!----------------");
    Console.WriteLine("---------------------------------------------");
    Console.ForegroundColor = Console.ForegroundColor = previousColor;

    Console.WriteLine("Tentativas restantes: " + (nivelDificuldade - contadorTentativas) + "\n");

    Console.Write("Digite um número: ");
    while (!int.TryParse(Console.ReadLine(), out numeroDigitado))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Valor inválido, tente novamente!");
        Console.ForegroundColor = Console.ForegroundColor = previousColor;
    }



    if (numeroDigitado == numeroSecreto)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("------       Você acertou!        ------");
        Console.WriteLine("----------------------------------------");
        Console.ForegroundColor = Console.ForegroundColor = previousColor;
        Environment.Exit(0);
    }
    else if (numeroDigitado > numeroSecreto)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("O número digitado é maior que o número secreto.");
        Console.WriteLine("-----------------------------------------------");
        Console.ForegroundColor = Console.ForegroundColor = previousColor;
        contadorTentativas++;
        Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
        Console.ReadKey();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("O número digitado é menor que o número secreto.");
        Console.WriteLine("-----------------------------------------------");
        Console.ForegroundColor = Console.ForegroundColor = previousColor;
        contadorTentativas++;
        Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
        Console.ReadKey();
    }
    if (contadorTentativas == nivelDificuldade)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("GAME OVER! O número secreto era: " + numeroSecreto + ".\n");
        Console.ForegroundColor = Console.ForegroundColor = previousColor;
        Console.WriteLine("Pressione Enter para sair...");
        if (Console.ReadKey().Key == ConsoleKey.Enter)
        {
            Environment.Exit(0);
        }
    }

} while (contadorTentativas != nivelDificuldade);


