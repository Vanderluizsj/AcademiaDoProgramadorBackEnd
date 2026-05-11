using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio10.ConsoleApp
{
    public class Nota
    {
        public decimal ValorNota { get; set; }
        public decimal Peso { get; set; }
        public Nota(decimal nota, decimal peso)
        {
            Peso = peso;
            ValorNota = nota;
        }
        public decimal CalculaValorNota()
        {
            return ValorNota*Peso;
        }

    }
}