var calculos = new Calculadora.ConsoleApp.Calculos();
int menu;


do
{
    Console.Clear();
    ConsoleColor previousColor = Console.ForegroundColor;
    previousColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("-------------------------------");
    Console.WriteLine("---------Calculadora-----------");
    Console.WriteLine("-------------------------------");
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Tabuada");
    Console.WriteLine("5 - Dividir");
    Console.WriteLine("6 - Potência");
    Console.WriteLine("7 - Raiz Quadrada");
    Console.WriteLine("8 - Histórico de Operações");
    Console.WriteLine("9 - Sair");
    while (!int.TryParse(Console.ReadLine(), out menu) || menu < 1 || menu > 9)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Opção inválida. Tente novamente.");
        Console.ForegroundColor = Console.ForegroundColor = previousColor;
    }
    
    switch (menu)
    {
        case 1:
            calculos.Somar();
            break;
        case 2:
            calculos.Subtrair();
            break;
        case 3:
            calculos.Multiplicar();
            break;
        case 4:
            calculos.Tabuada();
            break;
        case 5:
            calculos.Dividir();
            break;
        case 6:
            calculos.Potencia();
            break;
        case 7:
            calculos.RaizQuadrada();
            break;
        case 8:
            calculos.ExibirHistorico();
            break;
        case 9:
            Console.WriteLine("Saindo...");
            return;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
} while (menu != 9);
