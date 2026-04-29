namespace RoboTupiniquimConsoleApp.Entidades
{
    public class Instrucoes
    {
        public static void NovasInstrucoes(Dictionary<(int, int), string> plano,
            int x,
            int y,
            char direcao)
        {
            do
            {
                string? comandos;
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("Você deve digitar uma série de instruções (E, D, M)"+
                "\n que o robô deve seguir");
                
                Console.WriteLine("---------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("                               Legenda:                              ");
                Console.WriteLine("                 E = ESQUERDA\tD = DIREITA\tM = MOVE                 ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("---------------------------------------------------------------------");
                
                Console.WriteLine("\nDigite a série de instruções (ex: EMEMEMEMM)");

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
            } while (EndGame.Continue());

        }


    }
}