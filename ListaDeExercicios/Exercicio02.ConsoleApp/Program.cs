/*
Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma
viagem.
O programa deve solicitar ao usuário:
a. A quilometragem inicial do veículo no início da viagem.
b. A quilometragem final ao término da viagem.
c. A quantidade de combustível consumida durante a viagem (em litros).
*/

Double kmInicial;
Double kmFinal;
Double combustivelConsumido;
ConsoleColor previousColor = ConsoleColor.White;

Console.WriteLine("--- Exercicio 2 ---");

System.Console.WriteLine();

Console.Write("Qual a quilometragem inicial do veículo no início da viagem.: ");
while (!double.TryParse(Console.ReadLine(), out kmInicial))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido, tente novamente!");
    Console.ForegroundColor = Console.ForegroundColor = previousColor;
}

System.Console.WriteLine();

Console.Write("Qual a quilometragem final ao término da viagem: ");
while (!double.TryParse(Console.ReadLine(), out kmFinal))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido, tente novamente!");
    Console.ForegroundColor = Console.ForegroundColor = previousColor;
}

System.Console.WriteLine();

Console.Write("Qual a quantidade de combustível consumida durante a viagem (em litros): ");
while (!double.TryParse(Console.ReadLine(), out combustivelConsumido))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido, tente novamente!");
    Console.ForegroundColor = Console.ForegroundColor = previousColor;
}

System.Console.WriteLine("O consumo de combustível por quilômetro"
+ $"percorrido foi: {(kmFinal-kmInicial)/combustivelConsumido}km por litro");