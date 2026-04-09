using CorridaDeDados.ConsoleApp;

string jogador;
Funcoes funcoes = new Funcoes();

System.Console.Write("Digite seu nome para iniciar: ");
//jogador = Console.ReadLine();

System.Console.WriteLine();

//System.Console.WriteLine($"Bem vindo {jogador}!");

jogador = funcoes.startGame();


System.Console.WriteLine($"\nO vencedor foi {jogador}");
