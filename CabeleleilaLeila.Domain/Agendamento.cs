using CabeleleilaLeila.Domain.Core;
using CabeleleilaLeila.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabeleleilaLeila.Domain
{
    public class Agendamento
    {
        public long NumAgendamento { get; set; }

        public DateTime CriadoEm { get; set; } = DateTime.Now;

        public DateTime? DtAgendamento { get; set; }
        public required Guid ClienteId { get; set; }
        public decimal PrecoTotal { get; set; }

        public TipoAgendamentoEnum Status { get; set; } = TipoAgendamentoEnum.Pendente;


      


    }
}
