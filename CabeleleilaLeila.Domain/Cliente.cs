using CabeleleilaLeila.Domain.Core;
using CabeleleilaLeila.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CabeleleilaLeila.Domain
{
    public class Cliente
    {
        public Guid Id { get; set; }

        public required string Code { get; set; }   

        public string Name { get; set; }

       // public string CPF { get; set; }

        public DateTime BirthDate { get; set; } 

        public string Email { get; set; } = string.Empty;

        public string Cell { get; set; }

        public StatusClienteEnum Active { get; set; } = StatusClienteEnum.Ativo;

       
        public Guid UsuarioId { get; set; }

        public Result IsValid()
        {
            var messages = new List<string>();

             if (Id == Guid.Empty)
                messages.Add("Id está vazio");

            if (string.IsNullOrEmpty(Code))
                messages.Add("Código do cliente está vazio");
            if (Code.Length < 2)
                messages.Add("Código de cliente não deverá ter menos que dois caracteres");
            if (Code.Length > 10)
                messages.Add("Código de cliente não pode ultrapassar 10 caracteres");

            return Result.Factory.New(messages);


        }




    }
}



