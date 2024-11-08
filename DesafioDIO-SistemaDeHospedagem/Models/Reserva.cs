namespace SistemaDeHospedagem.Models;

public class Reserva
{
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva() { }

    public Reserva(int diasReservados)
    {
        DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        Hospedes = hospedes;

        if (Hospedes.Count > Suite.Capacidade) throw new Exception("ATENÇÃO: Quantidade de hóspedes excedida!");

    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count;

    }

    public decimal CalcularValorDiaria()
    {
        decimal valorTotal = DiasReservados * Suite.ValorDiaria;
        decimal desconto = valorTotal * 0.10M;

        if (DiasReservados >= 10)
        {
            valorTotal -= desconto;
            return valorTotal;
        }

        return valorTotal;
    }

}
