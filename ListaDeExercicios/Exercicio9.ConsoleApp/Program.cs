/*
Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo
de A! e o seu resultado.
a. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
b. Pesquise sobre “fatorial”
*/

int numero;
int fatorial = 0;
string? parar;
ConsoleColor previousColor = ConsoleColor.White;

Console.WriteLine("--- Exercicio 9 ---");

do
{    

System.Console.WriteLine();

Console.Write("Digite o numero inteiro: ");
while (!int.TryParse(Console.ReadLine(), out numero))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Valor inválido, tente novamente!");
    Console.ForegroundColor = Console.ForegroundColor = previousColor;
}

System.Console.WriteLine();

fatorial=numero;

for (int i = numero-1; i > 0; i--)
{   
    fatorial = fatorial * i;

}

System.Console.WriteLine($"O numero digitado foi {numero} e o fatorial é: {fatorial}");

System.Console.WriteLine("\nDeseja digitar um novo numero? ('s' ou 'n')");
parar = Console.ReadLine().ToLower();


} while (parar == "s");

