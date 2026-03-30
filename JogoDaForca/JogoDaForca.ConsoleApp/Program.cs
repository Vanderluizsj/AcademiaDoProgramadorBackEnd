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
    textoVerde();
    Console.WriteLine("-----------------------------------------------------------------------");
    Console.WriteLine("--------------------  Bem-vindo ao Jogo da Forca!  --------------------");
    Console.WriteLine("-----------------------------------------------------------------------");

    
    Console.WriteLine("\n*Nesse jogo, você terá que adivinhar as letras de uma palavra secreta!\n");

    textoAmarelo();
    Console.WriteLine("\nVocê tera 5 chances, a cada erro cometido uma" + 
    "parte do boneco aparecera na forca e voce podera continuar até que ele esteja completamente inforcado!\n");

    precioneEnter();

    animacao.AnimacaoForca(tentativas);

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
            textoBranco();
            Console.Write('\n' + "Digite uma letra: ");

            while (!char.TryParse(Console.ReadLine()?.ToUpper(), out letraDigitada))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido, tente novamente!");
                Console.ForegroundColor = Console.ForegroundColor = previousColor;
            }

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
                textoVermelho();
                Console.WriteLine('\n' + $"Letra incorreta! Você tem {tentativas} tentativas restantes.");
                precioneEnter();


                if (tentativas == 0)
                {
                    Console.WriteLine("Game Over! Você esgotou suas tentativas.");
                    fimDeJogo = true;
                    jogadorAcertou=true;
                    //break;
                }
            }
            //limpa e imprime após cada letra ser digitada
            imprimeRodada();

        }

        if (letrasDescobertas.Contains('_'))
        {
            textoAmarelo();
            Console.WriteLine('\n' + "Ainda tem letras para descobrir!");
        }
        else
        {
            textoVerde();
            Console.WriteLine('\n' + "Parabéns, você descobriu a palavra secreta!");
            fimDeJogo = true;
        }
    }
}

void imprimeRodada()
{
    animacao.AnimacaoForca(tentativas);
    for (int contadorDeLetras = 0; contadorDeLetras < palavraSecreta.Length; contadorDeLetras++)
    {
        Console.Write(letrasDescobertas[contadorDeLetras] + " ");
    }
    textoAmarelo();
    Console.WriteLine('\n' + $"tentativas restantes: {tentativas}.");
    precioneEnter();
    
}
void precioneEnter()
{
    textoBranco();
    Console.WriteLine('\n' + "Precione Enter para continuar...");
    ConsoleKeyInfo tecla;
    do
    {
        tecla = Console.ReadKey(true);
    }
    while (tecla.Key != ConsoleKey.Enter);
}

void textoVerde()
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
}
void textoAmarelo()
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
}
void textoVermelho()
{
    Console.ForegroundColor = ConsoleColor.Red;
}
void textoBranco()
{
    Console.ForegroundColor = previousColor;
}