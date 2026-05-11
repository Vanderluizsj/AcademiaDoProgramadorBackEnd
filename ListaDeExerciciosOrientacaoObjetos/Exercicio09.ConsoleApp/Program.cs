using Exercicio09.ConsoleApp;

System.Console.WriteLine("Digite a primeira nota do aluno:");
decimal nota1 = Convert.ToDecimal(Console.ReadLine());

System.Console.WriteLine("Digite a segunda nota do aluno:");
decimal nota2  = Convert.ToInt32(Console.ReadLine());

System.Console.
    WriteLine("Digite a terceira nota do aluno:");
decimal nota3  = Convert.ToDecimal(Console.ReadLine());

Aluno aluno = new Aluno(nota1, nota2, nota3);

decimal media = aluno.CalculaNota();

Console.WriteLine($"O média harmónica do aluno é de: {media.ToString("F1")}");