
using Exercicio04.ConsoleApp;

System.Console.WriteLine("Digite o km inicial do veiculo:");
int kmInicial = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Digite o km final do veiculo:");
int kmFinal  = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Digite a quantidade de litros gasta para percorrer o percurso:");
decimal litros  = Convert.ToDecimal(Console.ReadLine());

Veiculo veiculo = new Veiculo(kmInicial, kmFinal);

decimal consumo = veiculo.CalculaConsumo(litros);

Console.WriteLine($"O carro percorre: {consumo} km por litro.");