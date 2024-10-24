using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConceitosPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }

        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor)
        {

            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor desejado é maior que o saldo disponível!");
            }

        }

        public void ExbirSaldo()
        {
            Console.WriteLine($"Seu saldo disponível é de {saldo:C}");
        }
    }
}