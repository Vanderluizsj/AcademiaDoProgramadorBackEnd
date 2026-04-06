//Crie um programa para calcular o volume de uma caixa retangular
Double altura;
Double largura;
ConsoleColor previousColor = ConsoleColor.White;

Console.WriteLine("--- Exercicio 1 ---");

System.Console.WriteLine();

Console.Write("Digite a altura do retangulo: ");
while (!double.TryParse(Console.ReadLine(), out altura))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido, tente novamente!");
    Console.ForegroundColor = Console.ForegroundColor = previousColor;
}

System.Console.WriteLine();

Console.Write("Digite a largura do retangulo: ");
while (!double.TryParse(Console.ReadLine(), out largura))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido, tente novamente!");
    Console.ForegroundColor = Console.ForegroundColor = previousColor;
}

System.Console.WriteLine($"A area do retangulo é: {largura*altura}");