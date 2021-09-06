using Automoveis.Domain.Enums;


namespace Automoveis.Domain.Models
{
    class Caminhao : Veiculo
    {
        public double Motor { get; set; }

        public Caminhao(string modelo, TipoVeiculo tipoVeiculo, string marca, int ano, CorVeiculo corVeiculo, double motor, Combustivel combustivel)
        {
            Modelo = modelo;
            TipoVeiculo = tipoVeiculo;
            Marca = marca;
            Ano = ano;
            CorVeiculo = corVeiculo;
            Motor = motor;
            Combustivel = combustivel;
        }

    }
}
