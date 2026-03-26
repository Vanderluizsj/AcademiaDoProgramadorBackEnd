using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace JogoDeAdivinhacao.ConsoleApp
{
    public class Funcoes
    {

        int nivelDificuldade;
        int numeroDigitado;
        int contadorTentativas = 0;
        int numeroSecreto;
        bool repetido = false;
        List<int> numerosDigitados = new List<int>();
        int pontuacao = 1000;
        int diferenca;

        private readonly ConsoleColor previousColor = Console.ForegroundColor;

        public void NivelDificuldade()
        {

            while (!int.TryParse(Console.ReadLine(), out nivelDificuldade) || nivelDificuldade < 1 || nivelDificuldade > 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido, tente novamente!");
                Console.ForegroundColor = Console.ForegroundColor = previousColor;
            }
            if (nivelDificuldade == 1)
            {
                nivelDificuldade = 10;
                numeroSecreto = RandomNumberGenerator.GetInt32(1, 20);
            }
            else if (nivelDificuldade == 2)
            {
                nivelDificuldade = 5;
                numeroSecreto = RandomNumberGenerator.GetInt32(1, 50);
            }
            else
            {
                nivelDificuldade = 3;
                numeroSecreto = RandomNumberGenerator.GetInt32(1, 100);
            }
        }

        public bool NumeroRepetido(int numeroDigitado)
        {


            foreach (int numero in numerosDigitados)
            {
                if (numero == numeroDigitado)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Você já digitou esse número, tente outro!");
                    Console.ForegroundColor = Console.ForegroundColor = previousColor;
                    Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
                    Console.ReadKey();
                    return true;
                }
            }
            numerosDigitados.Add(numeroDigitado);
            return false;
        }

        public void ValidaResposta()
        {
            if (numeroDigitado == numeroSecreto)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("------       Você acertou!        ------");
                Console.WriteLine("----------------------------------------");
                ResultadoFinal();
                Console.ForegroundColor = Console.ForegroundColor = previousColor;

                contadorTentativas = 0;
                nivelDificuldade = 0;

            }
            else if (numeroDigitado > numeroSecreto)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("O número digitado é maior que o número secreto.");
                Console.WriteLine("-----------------------------------------------");
                Console.ForegroundColor = Console.ForegroundColor = previousColor;
                contadorTentativas++;
                AjustaPontuacao();
                Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("O número digitado é menor que o número secreto.");
                Console.WriteLine("-----------------------------------------------");
                Console.ForegroundColor = Console.ForegroundColor = previousColor;
                contadorTentativas++;
                AjustaPontuacao();
                Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
                Console.ReadKey();
            }
        }
        public void AjustaPontuacao()
        {
            diferenca = Math.Abs(numeroSecreto - numeroDigitado);
            if (diferenca <= 10)
            {
                pontuacao -= 100;
            }
            else if (diferenca >= 5 && diferenca <= 9)
            {
                pontuacao -= 50;
            }
            else
            {
                pontuacao -= 20;
            }
        }
        public void ResultadoFinal()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Sua pontuação final é: {pontuacao} pontos.");
            Console.WriteLine("----------------------------------------");
            Console.ForegroundColor = Console.ForegroundColor = previousColor;
        }

        public void StartGame()
        {
            NivelDificuldade();
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("---------------Jogo iniciado!----------------");
                Console.WriteLine("---------------------------------------------");
                Console.ForegroundColor = Console.ForegroundColor = previousColor;

                Console.WriteLine("Tentativas restantes: " + (nivelDificuldade - contadorTentativas) + "\n");

                Console.Write("Digite um número: ");
                while (!int.TryParse(Console.ReadLine(), out numeroDigitado))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valor inválido, tente novamente!");
                    Console.ForegroundColor = Console.ForegroundColor = previousColor;
                }

                repetido = NumeroRepetido(numeroDigitado);

                if (repetido == false)
                {
                    ValidaResposta();
                }


                if (contadorTentativas == nivelDificuldade)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("GAME OVER! O número secreto era: " + numeroSecreto + ".\n");
                    Console.ForegroundColor = Console.ForegroundColor = previousColor;
                    ResultadoFinal();

                    numerosDigitados.Clear();
                    contadorTentativas = 0;
                    nivelDificuldade = 0;
                    pontuacao = 1000;
                }

            } while (contadorTentativas != nivelDificuldade);
        }

        public bool EndGame()
        {
            Console.Write("Deseja jogar novamente? (S/N) :");
            string? resposta = Console.ReadLine().ToUpper();

            while (resposta != "S" && resposta != "N" && string.IsNullOrEmpty(resposta))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido, tente novamente!");
                Console.ForegroundColor = Console.ForegroundColor = previousColor;
                resposta = Console.ReadLine().ToUpper();
            }

            if (resposta == "S")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Obrigado por jogar! Até a próxima!");
                return true;
            }
        }

    }
}