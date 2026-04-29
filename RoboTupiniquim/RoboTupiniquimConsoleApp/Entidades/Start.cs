
namespace RoboTupiniquimConsoleApp.Entidades
{
    public class Start
    {

        public static void posicaoInicial(Dictionary<(int, int), string> plano)
        {
            int roboX;
            int roboY;
            string? entrada;
            string[] dados;
            char direcao; 
            do
            {
                Console.Clear();
                Console.WriteLine("A posição inicial, dada por 2 inteiros (X e Y) e uma letra (Orientação), separados por espaços.");
                Console.WriteLine("LEGENDA:");
                Console.WriteLine("N = NORTE");
                Console.WriteLine("L = LESTE");
                Console.WriteLine("S = SUL");
                Console.WriteLine("O = OESTE:");

                Console.WriteLine("Digite a posição inicial (ex: 1 2 N):");
                entrada = Console.ReadLine()?.ToUpper();
                if (entrada.Length < 5)
                    continue;
                else
                    dados = entrada.Split(' ');

                if (dados[2] == "N" || dados[2] == "L" || dados[2] == "S" || dados[2] == "O")
                {
                    direcao = Convert.ToChar(dados[2]);
                    if (int.TryParse(dados[0], out roboX) && int.TryParse(dados[1], out roboY))
                        break;
                }
            } while (true);
            Instrucoes.NovasInstrucoes(plano, roboX, roboY, direcao);
        }
    }
}