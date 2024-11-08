using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConceitosPOO.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, sou o aluno {Nome}, tenho {Idade} anos, com nota {Nota}");
        }
    }
}