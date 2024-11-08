using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConceitosPOO.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, sou o professor {Nome}, tenho {Idade} anos, com salário de {Salario:C}");
        }
    }
}