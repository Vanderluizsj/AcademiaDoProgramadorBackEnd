
using Exercicio05.ConsoleApp;

System.Console.WriteLine("Digite o raio da esfera:");
double raio = Convert.ToDouble(Console.ReadLine());

Esfera esfera= new Esfera(raio);

double volumeEsfera = esfera.ObterVolume();

Console.WriteLine($"O volume do cilindro é de: {volumeEsfera.ToString("F2")} cm³");