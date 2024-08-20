using CabeleleilaLeila.Domain.Core;
using CabeleleilaLeila.Domain.Infra.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabeleleilaLeila.Domain
{
    public class Servico
    {

        public Guid Id { get; set; }

        public required string CdServico { get; set; }

        public string Descricao { get; set; } = string.Empty;

        public required decimal Preco { get; set; }

        public Result IsValid()
        {

            var messages = new List<string>();

            if (Id == Guid.Empty)
                messages.Add("Id está vazio");

            if (string.IsNullOrEmpty(CdServico))
                messages.Add("Código do serviço está vazio");
            if (CdServico.Length < 2)
                messages.Add("Código de serviço não deverá ter menos que dois caracteres");
            if (CdServico.Length > 10)
                messages.Add("Código de serviço não pode ultrapassar 10 caracteres");
           


            return Result.Factory.New(messages);


        }


    }
}
