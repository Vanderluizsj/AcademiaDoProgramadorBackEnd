using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio08.ConsoleApp
{
    public class LataDeOleo
    {
        public decimal Diametro { get; set; }
        public decimal Altura { get; set; }


        public LataDeOleo(decimal diametro, decimal altura)
        {
            Diametro = diametro;
            Altura = altura;
        }
        public decimal ObterVolume()
        {
            return Diametro * Altura;
        }
    }
}