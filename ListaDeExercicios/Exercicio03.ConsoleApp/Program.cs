/*
Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
F = C*1,8+32
*/

Double tempCelsius;
ConsoleColor previousColor = ConsoleColor.White;

Console.WriteLine("--- Exercicio 3 ---");

System.Console.WriteLine();

Console.Write("Digite o valor da temperatura na escala Celsius: ");
while (!double.TryParse(Console.ReadLine(), out tempCelsius))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido, tente novamente!");
    Console.ForegroundColor = Console.ForegroundColor = previousColor;
}


System.Console.WriteLine($"A temperatura em Fahrenheit é: {tempCelsius*1.8+32}°F");