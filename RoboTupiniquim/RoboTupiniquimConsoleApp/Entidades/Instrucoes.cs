using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboTupiniquimConsoleApp.Entidades
{
    public class Instrucoes
    {
        public static void NovasInstrucoes(Dictionary<(int, int), string> plano,
            int x,
            int y,
            char direcao)
        {

            string? comandos;

            Console.WriteLine("Você deve digitar uma série de instruções (E, D, M) que o robô deve seguir");
            Console.WriteLine("Legenda: ");
            Console.WriteLine("E = ESQUERDA");
            Console.WriteLine("D = DIREITA");
            Console.WriteLine("M = MOVE");

            Console.WriteLine("Digite a série de instruções (ex: EMEMEMEMM)");

            comandos = Console.ReadLine()?.ToUpper();
            if (!string.IsNullOrEmpty(comandos))
            {
                foreach (char comando in comandos)
                {
                    if (comando == 'E')
                    {
                        if (direcao == 'N') direcao = 'O';
                        else if (direcao == 'O') direcao = 'S';
                        else if (direcao == 'S') direcao = 'L';
                        else if (direcao == 'L') direcao = 'N';
                    }
                    else if (comando == 'D')
                    {
                        if (direcao == 'N') direcao = 'L';
                        else if (direcao == 'L') direcao = 'S';
                        else if (direcao == 'S') direcao = 'O';
                        else if (direcao == 'O') direcao = 'N';
                    }
                    else if (comando == 'M')
                    {
                        if (direcao == 'N') y++;
                        else if (direcao == 'S') y--;
                        else if (direcao == 'L') x++;
                        else if (direcao == 'O') x--;
                    }

                    // Marca a posição visitada
                    plano[(x, y)] = "*";

                    Desenhar.DesenharPlano(plano, x, y, direcao);

                    Thread.Sleep(500);
                }
            }
        }
    }
}