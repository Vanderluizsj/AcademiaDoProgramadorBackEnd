/*
Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário
base e o total de vendas. A comissão é calculada com um percentual (informado pelo
usuário) sobre o total de vendas.
*/
Double salarioBase;
Double comissao;
Double totalVendas;
ConsoleColor previousColor = ConsoleColor.White;

Console.WriteLine("--- Exercicio 4 ---");

System.Console.WriteLine();

Console.Write("Digite o o salário base do vendedor: ");
while (!double.TryParse(Console.ReadLine(), out salarioBase))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido, tente novamente!");
    Console.ForegroundColor = Console.ForegroundColor = previousColor;
}

System.Console.WriteLine();

Console.Write("Digite o valor total das vendas realizadas pelo vendedor: ");
while (!double.TryParse(Console.ReadLine(), out totalVendas))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido, tente novamente!");
    Console.ForegroundColor = Console.ForegroundColor = previousColor;
}

System.Console.WriteLine();

Console.Write("Digite o numero referente ao percentual de comissão: ");
while (!double.TryParse(Console.ReadLine(), out comissao))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido, tente novamente!");
    Console.ForegroundColor = Console.ForegroundColor = previousColor;
}

System.Console.WriteLine($"O salario total do vendedor é: {salarioBase+(totalVendas*(comissao/100))}");