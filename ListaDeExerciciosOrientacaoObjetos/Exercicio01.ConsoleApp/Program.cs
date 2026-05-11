using Exercicio01.ConsoleApp;

System.Console.WriteLine("Digite o Comprimento da caixa:");
decimal comprimento = Convert.ToDecimal(Console.ReadLine());

System.Console.WriteLine("Digite a largura da caixa:");
decimal largura  = Convert.ToDecimal(Console.ReadLine());

System.Console.WriteLine("Digite a altura da caixa:");
decimal altura  = Convert.ToDecimal(Console.ReadLine());

CaixaRetangular caixa = new CaixaRetangular(comprimento, largura, altura);

decimal volumeCaixa = caixa.ObterVolume();

Console.WriteLine($"O volume da caixa é de: {volumeCaixa.ToString("F2")} cm³");