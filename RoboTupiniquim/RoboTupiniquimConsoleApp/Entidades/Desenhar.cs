
namespace RoboTupiniquimConsoleApp.Entidades
{
    public class Desenhar
    {
        public static void DesenharPlano(
            Dictionary<(int, int), string> plano,
            int roboX,
            int roboY,
            char direcao)
        {
            Console.Clear();

            // janela visível de -5 até +5
            for (int y = 5; y >= -5; y--)
            {
                for (int x = -5; x <= 5; x++)
                {
                    if (x == roboX && y == roboY)
                    {
                        Console.Write(direcao + " ");
                    }
                    else if (plano.ContainsKey((x, y)))
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }

                Console.WriteLine();
            }
            System.Console.WriteLine($"Posição alcançada: {roboX} {roboY} {direcao}");
        }
    }
}
