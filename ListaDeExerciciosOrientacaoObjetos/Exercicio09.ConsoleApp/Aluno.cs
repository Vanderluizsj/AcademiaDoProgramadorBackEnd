using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio09.ConsoleApp
{
    public class Aluno
    {
        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }
        public decimal Nota3 { get; set; }

        public Aluno(decimal nota1, decimal nota2, decimal nota3)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }
        public decimal CalculaNota()
        {
            return 3/((1/Nota1)+(1/Nota2)+(1/Nota3));
        }

        
    }

    
}