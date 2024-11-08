using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeCelularesPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string Imei { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void Caracteristicas()
        {
            Console.WriteLine("Características:\n" +
            $"- Modelo: {Modelo}\n" +
            $"- IMEI: {Imei}\n" +
            $"- Número: {Numero}\n" +
            $"- Armazenamento: {Memoria}gb de memória\n");

        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}