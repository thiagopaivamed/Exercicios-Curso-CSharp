using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroVeiculos.Models
{
    public class Veiculos
    {
        public int VeiculosId { get; set; }

        public string Nome { get; set; }

        public string Marca { get; set; }

        public string Placa { get; set; }

        public int Quantidade { get; set; }
    }
}
