using Exercicio10.ConsoleApp;

System.Console.WriteLine("Digite a primeira nota do aluno:");
decimal valorNota1 = Convert.ToDecimal(Console.ReadLine());

System.Console.WriteLine("Digite o numero inteiro referente ao peso da primeira nota do aluno:");
int pesoNota1  = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Digite a segunda nota do aluno:");
decimal valorNota2 = Convert.ToDecimal(Console.ReadLine());

System.Console.WriteLine("Digite o numero inteiro referente ao peso da segunda nota do aluno:");
int pseoNota2  = Convert.ToInt32(Console.ReadLine());

Nota nota1 = new Nota(valorNota1, pesoNota1);
Nota nota2 = new Nota(valorNota1, pesoNota1);
Aluno aluno = new Aluno(nota1, nota2);

decimal media = aluno.CalculaNota();

Console.WriteLine($"O média ponderada do aluno é de: {media.ToString("F1")}");