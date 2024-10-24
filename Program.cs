using ConceitosPOO.Models;

/*------------------- AULA 3 -------------------*/

Aluno a1 = new Aluno();
a1.Nome = "Eduardo";
a1.Idade = 24;
a1.Nota = 8.5;

a1.Apresentar();

Professor pr1 = new Professor();
pr1.Nome = "Leonardo";
pr1.Idade = 30;
pr1.Salario = 2500;

pr1.Apresentar();
Console.WriteLine("");

/*------------------- AULA 2 -------------------*/

ContaCorrente c1 = new ContaCorrente(123, 4000);

/* c1.saldo = 5000; INACESSÍVEL DEVIDO ENCAPSULAMENTO */
c1.ExbirSaldo();
Console.WriteLine("");

c1.Sacar(3000);
c1.ExbirSaldo();
Console.WriteLine("");

c1.Sacar(2000);
c1.ExbirSaldo();
Console.WriteLine("");

/*------------------- AULA 1 -------------------*/

Pessoa pe1 = new Pessoa();

pe1.Nome = "Eduardo";
pe1.Idade = 24;

pe1.Apresentar();
