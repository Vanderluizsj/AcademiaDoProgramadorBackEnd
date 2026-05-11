using Exercicio03.ConsoleApp;

System.Console.WriteLine("Digite o diametro do cilindro:");
decimal diametro = Convert.ToDecimal(Console.ReadLine());

System.Console.WriteLine("Digite a altura do cilindro:");
decimal altura  = Convert.ToDecimal(Console.ReadLine());

Cilindro cilindro = new Cilindro(diametro, altura);

decimal volumeCilindro = cilindro.ObterVolume();

Console.WriteLine($"O volume do cilindro é de: {volumeCilindro.ToString("F2")} cm³");