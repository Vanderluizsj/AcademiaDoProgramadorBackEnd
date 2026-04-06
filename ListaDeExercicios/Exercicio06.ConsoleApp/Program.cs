/*
Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor
que C.
*/
Double A;
Double B;
Double C;

ConsoleColor previousColor = ConsoleColor.White;

Console.WriteLine("--- Exercicio 6 ---");

System.Console.WriteLine();

Console.Write("Digite o valor de A: ");
while (!double.TryParse(Console.ReadLine(), out A))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido, tente novamente!");
    Console.ForegroundColor = Console.ForegroundColor = previousColor;
}

System.Console.WriteLine();

Console.Write("Digite o valor de B: ");
while (!double.TryParse(Console.ReadLine(), out B))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido, tente novamente!");
    Console.ForegroundColor = Console.ForegroundColor = previousColor;
}

System.Console.WriteLine();

Console.Write("Digite o valor de C: ");
while (!double.TryParse(Console.ReadLine(), out C))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido, tente novamente!");
    Console.ForegroundColor = Console.ForegroundColor = previousColor;
}
if (A+B<C)
{
    System.Console.WriteLine($"{A + B}(A+B) é menor que {C}(C).");
}
else
{
    System.Console.WriteLine($"{A + B} não é menor que {C}C.");
}