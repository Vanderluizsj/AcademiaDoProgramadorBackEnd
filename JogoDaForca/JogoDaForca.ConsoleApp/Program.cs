using JogoDaForca.ConsoleApp;

string palavraSecreta = "ABACATE";
bool fimDeJogo = false;
char[] letrasDescobertas = new char[palavraSecreta.Length];
int tentativas = 5;
string? jogarNovamente;
ConsoleColor previousColor = ConsoleColor.White;
Animacao animacao = new Animacao();

Console.Clear();

do
{

    animacao.AnimacaoForca();

    for (int contadorDeLetras = 0; contadorDeLetras < letrasDescobertas.Length; contadorDeLetras++)
    {
        letrasDescobertas[contadorDeLetras] = '_';
        Console.Write(letrasDescobertas[contadorDeLetras] + " ");
    }

    StartGame();

    Console.Write("Deseja jogar novamente? 's' ou 'n'");
    jogarNovamente = Console.ReadLine()?.ToUpper();

} while (jogarNovamente == "S");

Console.WriteLine("Obrigado por jogar!!!");

Console.WriteLine("Até a proxima.");

void StartGame()
{
    while (!fimDeJogo)
    {

        bool jogadorAcertou = false;
        char letraDigitada;

        while (!jogadorAcertou)
        {
            Console.Write('\n' + "Digite uma letra: ");

            while (!char.TryParse(Console.ReadLine()?.ToUpper(), out letraDigitada))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido, tente novamente!");
                Console.ForegroundColor = Console.ForegroundColor = previousColor;
            }
            //char letraDigitada = char.Parse(Console.ReadLine().ToUpper());

            for (int contadorDeLetras = 0; contadorDeLetras < palavraSecreta.Length; contadorDeLetras++)
            {
                if (letraDigitada == palavraSecreta[contadorDeLetras])
                {
                    letrasDescobertas[contadorDeLetras] = letraDigitada;
                }
            }
            if (letrasDescobertas.Contains(letraDigitada))
            {
                jogadorAcertou = true;
            }
            else
            {
                tentativas--;
                animacao.AnimacaoForca();
                Console.WriteLine('\n' + $"Letra incorreta! Você tem {tentativas} tentativas restantes.");              


                if (tentativas == 0)
                {
                    Console.WriteLine("Game Over! Você esgotou suas tentativas.");
                    fimDeJogo = true;
                    break;
                }
            }

            for (int contadorDeLetras = 0; contadorDeLetras < palavraSecreta.Length; contadorDeLetras++)
            {
                Console.Write(letrasDescobertas[contadorDeLetras] + " ");
            }

            Console.WriteLine('\n' + "Precione Enter para continuar...");
            ConsoleKeyInfo tecla;
            do
            {
                tecla = Console.ReadKey(true);
            }
            while (tecla.Key != ConsoleKey.Enter);

        }

        if (letrasDescobertas.Contains('_'))
        {
            Console.WriteLine('\n' + "Ainda tem letras para descobrir!");
        }
        else
        {
            Console.WriteLine('\n' + "Parabéns, você descobriu a palavra secreta!");
            fimDeJogo = true;
        }
    }
}