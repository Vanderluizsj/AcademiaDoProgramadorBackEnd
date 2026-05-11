using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03.ConsoleApp
{
    public class Cilindro
    {
        public decimal Diametro { get; set; }
        public decimal Altura { get; set; }


        public Cilindro(decimal diametro, decimal altura)
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