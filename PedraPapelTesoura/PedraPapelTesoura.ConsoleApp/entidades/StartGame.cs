namespace PedraPapelTesoura.ConsoleApp.entidades
{
    public class StartGame
    {
        public static void Start()
        {
            Console.Clear();
            Console.WriteLine(" ╔════════════════════════════╗");
            Console.WriteLine(" ║ Jogo Pedra, Papel, Tesoura ║");
            Console.WriteLine(" ╚════════════════════════════╝");          
        }
        public static bool Continuar()
        {
            System.Console.WriteLine("Deseja jogar novamente? 's' ou 'n'");
            string? jogarNovamente = Console.ReadLine()?.ToLower();
            if (jogarNovamente =="s")
            {
                return false;
            }
            return true;            
        }
    }
}