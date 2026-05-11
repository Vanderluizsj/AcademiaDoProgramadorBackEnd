using Exercicio07.ConsoleApp;

System.Console.WriteLine("Digite o Salario Base do vendedor em reais:");
decimal salarioBase = Convert.ToDecimal(Console.ReadLine());

System.Console.WriteLine("Digite o numero total de vendas em reais:");
decimal vendas  = Convert.ToInt32(Console.ReadLine());

System.Console.
    WriteLine("Digite o numero inteiro que representa o percentual que sera aplicado sobre o total de vendas: (ex 5 para 5%)");
decimal comissao  = Convert.ToDecimal(Console.ReadLine());

Vendedor vendedor = new Vendedor(salarioBase, comissao, vendas);

decimal salario = vendedor.CalculaSalarioTotal();

Console.WriteLine($"O salario total é de: {salario.ToString("F2")}R$");