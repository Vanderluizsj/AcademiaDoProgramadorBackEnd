namespace RoboTupiniquimConsoleApp.Entidades
{
    public class EndGame
    {
        public static bool Continue()
        {
            string? continuar;
            Console.WriteLine("Deseja movimentar o robo novamente? ('s' ou 'n')");            
            continuar = Console.ReadLine()?.ToUpper();
            if (continuar == "S")
                return true;
            return false;
        }
    }
}