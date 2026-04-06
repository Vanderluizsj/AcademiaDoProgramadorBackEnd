/*
Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
*/
Double prova1;
Double prova2;
int pesoDaProva1;
int pesoDaProva2;
ConsoleColor previousColor = ConsoleColor.White;

Console.WriteLine("--- Exercicio 5 ---");

System.Console.WriteLine();

Console.Write("Digite a nota da Prova 01: ");
while (!double.TryParse(Console.ReadLine(), out prova1))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido, tente novamente!");
    Console.ForegroundColor = Console.ForegroundColor = previousColor;
}

System.Console.WriteLine();

Console.Write("Digite a nota da Prova 02: ");
while (!double.TryParse(Console.ReadLine(), out prova2))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido, tente novamente!");
    Console.ForegroundColor = Console.ForegroundColor = previousColor;
}

System.Console.WriteLine();

Console.Write("Digite a peso da Prova 01: ");
while (!int.TryParse(Console.ReadLine(), out pesoDaProva1) || pesoDaProva1<1 || pesoDaProva1>10)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido, tente novamente!");
    Console.ForegroundColor = Console.ForegroundColor = previousColor;
}

Console.Write("Digite a peso da Prova 02: ");
while (!int.TryParse(Console.ReadLine(), out pesoDaProva2) || pesoDaProva2<1 || pesoDaProva2>10)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido, tente novamente!");
    Console.ForegroundColor = Console.ForegroundColor = previousColor;
}
System.Console.WriteLine($"A média ponderada é: {((prova1*pesoDaProva1)+(prova2*pesoDaProva2))/2}");