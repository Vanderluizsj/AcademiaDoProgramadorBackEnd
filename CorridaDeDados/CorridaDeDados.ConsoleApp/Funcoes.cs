using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace CorridaDeDados.ConsoleApp
{
    public class Funcoes
    {
        string robo = "R", player = "P", vezDeJogar, vencedor;
        string[] pistaPlayer = new String[30];
        string[] pistaRobo = new String[30];
        bool fimDeJogo = false;
        int giroDoDado = 0, posicaoAtualRobo = 0, posicaoAtualPlayer = 0, rodada = 0;

        public string startGame()
        {
            vezDeJogar = robo;
            montaPistaInicial();
            while (!fimDeJogo)
            {
                desenhaPista();
                vezDeQuem();
                //fimDeJogo=true;
            }
            return vencedor;
        }

        public void montaPistaInicial()
        {
            pistaRobo[posicaoAtualRobo] = robo;
            pistaPlayer[posicaoAtualPlayer] = player;
            for (int i = 0; i < 30; i++)
            {
                if (i < 9)
                {
                    pistaRobo[i] = Convert.ToString("_");
                    pistaPlayer[i] = Convert.ToString("_");
                }
                else
                {
                    pistaRobo[i] = Convert.ToString("__");
                    pistaPlayer[i] = Convert.ToString("__");
                }

            }
        }
        public void desenhaPista()
        {
            pistaRobo[posicaoAtualRobo] = robo;
            pistaPlayer[posicaoAtualPlayer] = player;
            Console.WriteLine($"\n------------------------------------RODADA: {rodada}--------------------------------------------");
            for (int i = 0; i < 30; i++)
            {
                System.Console.Write(pistaRobo[i] + " ");
            }
            System.Console.WriteLine();
            for (int i = 0; i < 30; i++)
            {
                System.Console.Write(i + 1 + " ");
            }
            System.Console.WriteLine();
            for (int i = 0; i < 30; i++)
            {
                System.Console.Write(pistaPlayer[i] + " ");
            }
            System.Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            rodada++;
        }

        public void vezDeQuem()
        {
            if (vezDeJogar == "R")
            {
                giroDoDado = RandomNumberGenerator.GetInt32(1, 6);
                posicaoAtualRobo += giroDoDado;
                System.Console.WriteLine($"O Robo rolou o dado e obteve um {giroDoDado}!");
                if (posicaoAtualRobo >= 29)
                {
                    posicaoAtualRobo = 29;
                    //pistaRobo[posicaoAtualRobo] = robo;
                    fimDeJogo = true;
                    vencedor = robo;
                }
                else
                {
                    vezDeJogar = player;
                }
                pistaRobo[posicaoAtualRobo] = robo;
            }
            else
            {
                System.Console.WriteLine("Sua vez!");

                Console.WriteLine('\n' + "Precione Enter para rolar o dado...");
                ConsoleKeyInfo tecla;
                do
                {
                    tecla = Console.ReadKey(true);
                }
                while (tecla.Key != ConsoleKey.Enter);
                giroDoDado = RandomNumberGenerator.GetInt32(1, 6);
                posicaoAtualPlayer += giroDoDado;
                System.Console.WriteLine($"Você rolou o dado e obteve um {giroDoDado}!");
                if (posicaoAtualPlayer >= 29)
                {
                    posicaoAtualPlayer = 29;
                    //pistaPlayer[posicaoAtualPlayer] = player;
                    fimDeJogo = true;
                    vencedor = player;
                }
                else
                {
                    vezDeJogar = robo;
                }
                pistaPlayer[posicaoAtualPlayer] = player;
            }
        }
        void precioneEnter()
        {
            Console.WriteLine('\n' + "Precione Enter para continuar...");
            ConsoleKeyInfo tecla;
            do
            {
                tecla = Console.ReadKey(true);
            }
            while (tecla.Key != ConsoleKey.Enter);
        }
    }
}