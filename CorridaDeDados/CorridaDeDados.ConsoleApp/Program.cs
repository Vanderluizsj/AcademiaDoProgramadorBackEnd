namespace CorridaDeDados.ConsoleApp;

using CorridaDeDados.ConsoleApp.Entidades;

class Program
{
    static void Main(string[] args)
    {
        string[] pista = new String[30];
        int posicaoAtualJogador = 0;
        int posicaoAtualComputador = 0;
        int posicao = 0;
        while (true)
        {
            Jogador.posicao = 0;
            Computador.posicao = 0;

            for (int i = 1; i < 30; i++)
            {
                pista[i] = "-";
            }

            while (true)
            {
                // 1. Rodada do Jogador
                posicao = Jogador.ExecutarRodada();

                if (Jogador.VenceuPartida())
                    break;
                else
                {
                    pista[posicaoAtualJogador] = "-";
                    posicaoAtualJogador = posicao;
                    pista[posicaoAtualJogador] = "J";
                    for (int i = 1; i < 30; i++)
                    {
                        System.Console.Write(pista[i] + " ");
                    }
                    precioneEnter();
                }

                // 2. Rodada do Computador
                posicao = Computador.ExecutarRodada();

                if (Computador.VenceuPartida())
                    break;
                else
                {
                    pista[posicaoAtualComputador] = "-";
                    posicaoAtualComputador = posicao;
                    pista[posicaoAtualComputador] = "R";
                    for (int i = 1; i < 30; i++)
                    {
                        System.Console.Write(pista[i] + " ");
                    }
                    precioneEnter();
                }
            }

            Console.WriteLine("--------------------------------------");
            Console.Write("Deseja continuar? (s/N): ");
            string? opcaoContinuar = Console.ReadLine()?.ToUpper();

            if (opcaoContinuar != "S")
                break;
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
