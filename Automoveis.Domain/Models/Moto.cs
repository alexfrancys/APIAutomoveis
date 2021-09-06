using Automoveis.Domain.Enums;


namespace Automoveis.Domain.Models
{
    class Moto : Veiculo
    {
        public int Cilindradas { get; set; }

        public Moto(string modelo, TipoVeiculo tipoVeiculo, string marca, int ano, CorVeiculo corVeiculo, Combustivel combustivel, int cilindradas)
        {
            Modelo = modelo;
            TipoVeiculo = tipoVeiculo;
            Marca = marca;
            Ano = ano;
            CorVeiculo = corVeiculo;
            Combustivel = combustivel;
            Cilindradas = cilindradas;
        }
    }
}
