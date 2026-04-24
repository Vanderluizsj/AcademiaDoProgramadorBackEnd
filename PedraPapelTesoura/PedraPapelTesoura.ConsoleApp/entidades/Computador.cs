using System.Security.Cryptography;

namespace PedraPapelTesoura.ConsoleApp.entidades
{
    public class Computador
    {
        public static int ObterEscolha()
        {
            return RandomNumberGenerator.GetInt32(1, 4);
        }
    }
}