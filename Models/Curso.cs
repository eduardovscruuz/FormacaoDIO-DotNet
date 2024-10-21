using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NugetPropriedadesCSharp.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int QuantidadeDeAlunos(Pessoa aluno)
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);

        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");
            int contador = 1;
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine($"{contador} - {aluno.NomeCompleto}");
                contador++;
            }

        }
    }

}