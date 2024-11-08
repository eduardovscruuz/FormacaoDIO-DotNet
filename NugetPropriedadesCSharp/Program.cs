using NugetPropriedadesCSharp.Models;
using Newtonsoft.Json;


Pessoa p1 = new Pessoa(nome: "Leonardo", sobrenome: "Buta");

Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Cruz");

Curso cursoDeingles = new Curso();
cursoDeingles.Nome = "Inglês";
cursoDeingles.Alunos = new List<Pessoa>();

// cursoDeingles.AdicionarAluno(p1);
// cursoDeingles.AdicionarAluno(p2);
// cursoDeingles.ListarAlunos();


DateTime dataAtual = DateTime.Now;

List<Vendas> listaVendas = new List<Vendas>();

Vendas v1 = new Vendas(1, "Materiais de escritório", 25.00M, dataAtual);
Vendas v2 = new Vendas(2, "Materiais de construção", 55.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);