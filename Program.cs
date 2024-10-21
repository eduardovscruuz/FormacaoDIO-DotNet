using System.Text;
using SistemaDeHospedagem.Models;
Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Eduardo", sobrenome: "Cruz");
Pessoa p2 = new Pessoa(nome: "Gabriely", sobrenome: "Antunes");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 1, valorDiaria: 30);

Reserva reserva = new Reserva(diasReservados: 9);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine("\n------- RESUMO DA ESTADIA ------- \n");
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Duração da estadia: {reserva.DiasReservados} dias");
Console.WriteLine($"Valor total a pagar: {reserva.CalcularValorDiaria().ToString("C")} " + (reserva.DiasReservados >= 10 ? "(10% de desconto aplicado)" : ""));
Console.WriteLine("\n--------- VOLTE SEMPRE! --------- \n");