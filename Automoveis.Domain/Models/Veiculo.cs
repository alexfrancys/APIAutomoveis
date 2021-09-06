using Automoveis.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automoveis.Domain
{
    public abstract class Veiculo
    {
        public Guid Id { get; set; }
        public string Modelo { get; set; }
        public TipoVeiculo TipoVeiculo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public CorVeiculo CorVeiculo { get; set; }

        public Combustivel Combustivel { get; set; }
                
    }
}
