using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio04.ConsoleApp
{
    public class Veiculo
    {
        public int KmInicial { get; set; }
        public int KmFinal { get; set; }

        public Veiculo(int kmInicial, int kmFinal)
        {
            KmInicial = kmInicial;
            KmFinal = kmFinal;
        }
        public decimal CalculaConsumo(decimal quantidadeLitros)
        {
            return (KmFinal-KmInicial)/quantidadeLitros;
        }
    }

}