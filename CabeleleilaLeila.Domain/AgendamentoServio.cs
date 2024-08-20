using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabeleleilaLeila.Domain
{
    public class AgendamentoServio
    {
        public required long NumAgendamento { get; set; }

        public required string CdServico { get; set; }
        public required string Descricao { get; set; }

        public Servico servico { get; set; }

        public decimal Preco { get; set; }

    }
}
