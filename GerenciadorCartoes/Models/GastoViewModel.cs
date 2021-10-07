using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorCartoes.Models
{
    public class GastoViewModel
    {
        public int CartaoId { get; set; }
        public string NumeroCartao { get; set; }
        public List<Gasto> ListaGastos { get; set; }

        public int PorcentagemGasta { get; set; }
    }
}
