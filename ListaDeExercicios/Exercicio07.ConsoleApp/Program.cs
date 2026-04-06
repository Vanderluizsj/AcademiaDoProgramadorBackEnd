/*
O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar
uma indicação sobre a condição de peso de uma pessoa adulta. A fórmula é IMC = peso /
(altura) 2. Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição
de acordo com a listagem abaixo:
a. IMC em adultos Condição
b. Abaixo de 18,5
c. Abaixo do peso
d. Entre 18,5 e 25 Peso normal
e. Entre 25 e 30
f. Acima do peso
g. Acima de 30 obeso
*/
Double peso;
Double altura;
Double imc;

ConsoleColor previousColor = ConsoleColor.White;

Console.WriteLine("--- Exercicio 7 ---");

System.Console.WriteLine();

Console.Write("Digite o peso: ");
while (!double.TryParse(Console.ReadLine(), out peso))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido, tente novamente!");
    Console.ForegroundColor = Console.ForegroundColor = previousColor;
}

System.Console.WriteLine();

Console.Write("Digite a altura: (Ex: 1,7) ");
while (!double.TryParse(Console.ReadLine(), out altura) || altura>3)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido, tente novamente!");
    Console.ForegroundColor = Console.ForegroundColor = previousColor;
}

System.Console.WriteLine();

imc=peso/(altura*2);

System.Console.WriteLine($"IMC {imc}");
if (imc<18.5)
{
    System.Console.WriteLine($"Abaixo do peso.");
}
else if (imc>=18.5 && imc<25)
{
    System.Console.WriteLine($"Peso normal.");
}else if (imc>=25 && imc<30)
{
    System.Console.WriteLine($"Acima do peso.");
}
else
{
    System.Console.WriteLine($"Obeso.");
}