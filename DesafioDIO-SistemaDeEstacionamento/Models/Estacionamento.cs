using System.Text.RegularExpressions;

namespace SistemaDeEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar: (Formato 'ABC-123')");

            var placa = Console.ReadLine();

            Regex regex = new Regex(@"^[A-Z]{3}-\d{3}$");
            if (regex.IsMatch(placa))
            {
                veiculos.Add(placa);
                Console.WriteLine("Placa válida! Veículo estacionado");

            }
            else
            {
                Console.WriteLine("Placa inválida!");
            }

        }

        public void ListarVeiculos()
        {

            if (veiculos.Any())
            {
                if (veiculos.Count == 1) Console.WriteLine($"Temos {veiculos.Count} veículo estacionado, sendo ele:");
                else Console.WriteLine($"Temos {veiculos.Count} veículos estacionados, sendo eles:");

                int contador = 1;
                foreach (string placa in veiculos)
                {
                    Console.WriteLine($"Veículo {contador}: {placa}");
                    contador++;
                }
            }



            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover: (Formato 'ABC-123')");

            var placa = Console.ReadLine();
            Regex regex = new Regex(@"^[A-Z]{3}-\d{3}$");

            if (regex.IsMatch(placa))
            {
                if (veiculos.Any(x => x == placa))
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    int horas = 0;
                    decimal valorTotal = 0;
                    horas = Convert.ToInt32(Console.ReadLine());
                    valorTotal = precoInicial + precoPorHora * horas;

                    veiculos.Remove(placa);
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorTotal.ToString("C")}");
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui.");
                }
            }
            else
            {
                Console.WriteLine("Placa inválida!");
            }


        }
    }
}