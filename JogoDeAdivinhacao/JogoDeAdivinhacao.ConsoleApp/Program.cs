
using JogoDeAdivinhacao.ConsoleApp;
/*
*/
Funcoes funcoes = new Funcoes();
bool endGame = false;


ConsoleColor previousColor = Console.ForegroundColor;
previousColor = ConsoleColor.White;



while (endGame == false)
{
    Console.Clear();
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

    

    funcoes.StartGame();
    endGame = funcoes.EndGame();

}
