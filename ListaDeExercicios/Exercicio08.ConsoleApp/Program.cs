/*
Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
*/

Double numero;
string? parar;
ConsoleColor previousColor = ConsoleColor.White;

Console.WriteLine("--- Exercicio 8 ---");

do
{    

System.Console.WriteLine();

Console.Write("Digite o numero: ");
while (!double.TryParse(Console.ReadLine(), out numero))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido, tente novamente!");
    Console.ForegroundColor = Console.ForegroundColor = previousColor;
}

System.Console.WriteLine();


if (numero%2 == 0)
    System.Console.WriteLine($"O numero: {numero} é par");
else
    System.Console.WriteLine($"O numero: {numero} é impar");

System.Console.WriteLine("\nDeseja digitar um novo numero? ('s' ou 'n')");
parar = Console.ReadLine().ToLower();


} while (parar == "s");

