using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoDaForca.ConsoleApp
{
    public class Animacao
    {
        char[,] animacaoForca = new char[9, 13];
        int contadorDeAcionamento = 0;
        public void AnimacaoForca()
        {
            switch (contadorDeAcionamento)
            {
                case 0:
                    contadorDeAcionamento++;
                    for (int linha = 0; linha < animacaoForca.GetLength(0); linha++)
                    {
                        for (int coluna = 0; coluna < animacaoForca.GetLength(1); coluna++)
                        {
                            animacaoForca[linha, coluna] = ' ';
                        }
                    }

                    for (int linha = 0; linha < animacaoForca.GetLength(0); linha++)
                    {
                        animacaoForca[linha, 0] = '|';
                    }

                    for (int coluna = 0; coluna < animacaoForca.GetLength(1); coluna++)
                    {
                        animacaoForca[0, coluna] = '-';
                    }

                    animacaoForca[1, 1] = '/';
                    break;
                case 1:
                    contadorDeAcionamento++;
                    animacaoForca[1, 11] = '|';
                    break;
                case 2:
                    contadorDeAcionamento++;
                    animacaoForca[2, 11] = 'O';
                    break;
                case 3:
                    contadorDeAcionamento++;
                    animacaoForca[3, 11] = '|';
                    break;
                case 4:
                    contadorDeAcionamento++;
                    animacaoForca[3, 10] = '/';
                    animacaoForca[3, 12] = '\\';
                    break;

                default:
                    animacaoForca[4, 10] = '/';
                    animacaoForca[4, 12] = '\\';
                    contadorDeAcionamento=0;
                    break;
            }

            Console.Clear(); // limpa antes de desenhar
            for (int linha = 0; linha < animacaoForca.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < animacaoForca.GetLength(1); coluna++)
                {
                    Console.Write(animacaoForca[linha, coluna]);
                }
                Console.WriteLine();
            }

        }

    }
}