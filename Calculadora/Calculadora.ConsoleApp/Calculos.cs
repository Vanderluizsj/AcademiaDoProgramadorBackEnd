using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Calculadora.ConsoleApp
{
    public class Calculos
    {
        double numero1, numero2;
        ConsoleColor previousColor = Console.ForegroundColor;
        List<string> Historico = new List<string>();
        string operacao = string.Empty;
        public void Somar()
        {
            ConsoleColor previousColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite o primeiro número:");
            Console.ForegroundColor = Console.ForegroundColor = previousColor;
            while (!double.TryParse(Console.ReadLine(), out numero1))    
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido, tente novamente:");
                Console.ForegroundColor = Console.ForegroundColor = previousColor;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite o segundo número:");
            Console.ForegroundColor = Console.ForegroundColor = previousColor;
            while (!double.TryParse(Console.ReadLine(), out numero2))
            {
                Console.ForegroundColor = ConsoleColor.Red;                                     
                Console.WriteLine("Valor inválido, tente novamente:");
                Console.ForegroundColor = Console.ForegroundColor = previousColor;
            }            
            double resultado = numero1 + numero2;
            operacao = $"{numero1} + {numero2} = {resultado}";
            Historico.Add(operacao);
            Console.WriteLine($"Resultado: {resultado}");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public void Subtrair()
        {
            Console.ForegroundColor = ConsoleColor.Green;       
            Console.WriteLine("Digite o primeiro número:");
            Console.ForegroundColor = Console.ForegroundColor = previousColor;
            while (!double.TryParse(Console.ReadLine(), out numero1))            
            {    Console.ForegroundColor = ConsoleColor.Red;               
                Console.WriteLine("Valor inválido, tente novamente:");
                Console.ForegroundColor = Console.ForegroundColor = previousColor;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite o segundo número:");
            Console.ForegroundColor = Console.ForegroundColor = previousColor;
            while (!double.TryParse(Console.ReadLine(), out numero2))         
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido, tente novamente:");
                Console.ForegroundColor = Console.ForegroundColor = previousColor;
            }
            double resultado = numero1 - numero2;
            operacao = $"{numero1} - {numero2} = {resultado}";
            Historico.Add(operacao);
            Console.WriteLine($"Resultado: {resultado}");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
             Console.ReadKey();   
        }  

        public void Multiplicar()
        {   
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite o primeiro número:");
            Console.ForegroundColor = Console.ForegroundColor = previousColor;
            while (!double.TryParse(Console.ReadLine(), out numero1))            
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido, tente novamente:");
                Console.ForegroundColor = previousColor;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite o segundo número:");
            Console.ForegroundColor = Console.ForegroundColor = previousColor;
            while (!double.TryParse(Console.ReadLine(), out numero2))         
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido, tente novamente:");
                Console.ForegroundColor = Console.ForegroundColor = previousColor;
            }
            double resultado = numero1 * numero2;
            operacao = $"{numero1} * {numero2} = {resultado}";
            Historico.Add(operacao);
            Console.WriteLine($"Resultado: {resultado}");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
        }
        public void Tabuada()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite o número para a tabuada:");
            Console.ForegroundColor = Console.ForegroundColor = previousColor;
            while (!double.TryParse(Console.ReadLine(), out numero1))            
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido, tente novamente:");
                Console.ForegroundColor = Console.ForegroundColor = previousColor;
            }
            Console.WriteLine($"Tabuada do {numero1}:");
            for (int i = 1; i <= 10; i++)
            {
                double resultado = numero1 * i;
                Console.WriteLine($"{numero1} x {i} = {resultado}");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
        }

        public void Dividir()
        {   
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite o primeiro número:");
            Console.ForegroundColor = Console.ForegroundColor = previousColor;
            while (!double.TryParse(Console.ReadLine(), out numero1))            
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido, tente novamente:");
                Console.ForegroundColor = Console.ForegroundColor = previousColor;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite o segundo número:");
            Console.ForegroundColor = Console.ForegroundColor = previousColor;
            while (!double.TryParse(Console.ReadLine(), out numero2))         
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido, tente novamente:");
                Console.ForegroundColor = Console.ForegroundColor = previousColor;
            }
            if (numero2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não é possível dividir por zero.");
                Console.ForegroundColor = Console.ForegroundColor = previousColor;
                return;
            }
            double resultado = numero1 / numero2;
            operacao = $"{numero1} / {numero2} = {resultado}";
            Historico.Add(operacao);
            Console.WriteLine($"Resultado: {resultado}");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
        }

        public void Potencia()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite o primeiro número:");
            Console.ForegroundColor = Console.ForegroundColor = previousColor;
            while (!double.TryParse(Console.ReadLine(), out numero1))            
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido, tente novamente:");
                Console.ForegroundColor = Console.ForegroundColor = previousColor;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite o segundo número:");
            Console.ForegroundColor = Console.ForegroundColor = previousColor;
            while (!double.TryParse(Console.ReadLine(), out numero2))         
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido, tente novamente:");
                Console.ForegroundColor = Console.ForegroundColor = previousColor;
            }
            double resultado = Math.Pow(numero1, numero2);
            operacao = $"{numero1} ^ {numero2} = {resultado}";
            Historico.Add(operacao);
            Console.WriteLine($"Resultado: {resultado}");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
        }
        public void RaizQuadrada()
        {
            Console.ForegroundColor = ConsoleColor.Green;   
            Console.WriteLine("Digite o número:");
            Console.ForegroundColor = Console.ForegroundColor = previousColor;
            while (!double.TryParse(Console.ReadLine(), out numero1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido, tente novamente:");
                Console.ForegroundColor = Console.ForegroundColor = previousColor;
            }
            if (numero1 < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não é possível calcular a raiz quadrada de um número negativo.");
                Console.ForegroundColor = Console.ForegroundColor = previousColor;
                return;
            }
            double resultado = Math.Sqrt(numero1);
            operacao = $"√{numero1} = {resultado}";
            Historico.Add(operacao);
            Console.WriteLine($"Resultado: {resultado}");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
        }
        public void ExibirHistorico()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Histórico de Operações");
            Console.WriteLine("-----------------------------------------");
            if (Historico.Count == 0)
            {
                Console.WriteLine("Nenhuma operação realizada ainda.");
            }
            else
            {
                foreach (var operacao in Historico)
                {
                    Console.WriteLine(operacao);
                }
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

    }
}