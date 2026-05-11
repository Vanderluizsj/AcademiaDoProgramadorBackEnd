using Exercicio08.ConsoleApp;

System.Console.WriteLine("Digite o diametro da lata:");
decimal diametro = Convert.ToDecimal(Console.ReadLine());

System.Console.WriteLine("Digite a altura da lata:");
decimal altura  = Convert.ToDecimal(Console.ReadLine());

LataDeOleo lataDeOleo = new LataDeOleo(diametro, altura);

decimal volumeLataDeOleo = lataDeOleo.ObterVolume();

Console.WriteLine($"O volume da lata de oleo é de: {volumeLataDeOleo.ToString("F2")} cm³");