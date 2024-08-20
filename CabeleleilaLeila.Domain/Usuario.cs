using CabeleleilaLeila.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CabeleleilaLeila.Domain.Core;
using CabeleleilaLeila.Domain.Infra.Helpers;

namespace CabeleleilaLeila.Domain
{
    public class Usuario
    {
        public Guid Id { get; set; }

        public required string CdUsuario { get; set; }

        public string NomeUsuario { get; set; } = string.Empty;

        public required string Senha { get; set; }

        public UsuarioStatusEnum Ativo { get; set; } = UsuarioStatusEnum.Ativo;

        public TipoUsuarioEnum TipoUsuario { get; set; } = TipoUsuarioEnum.Comum;

        public Result IsValid()
        {

            var messages = new List<string>();

            if (Id == Guid.Empty)
                messages.Add("Id está vazio");

            if (string.IsNullOrEmpty(CdUsuario))
                messages.Add("Código do usuário está vazio");
            if (CdUsuario.Length < 2)
                messages.Add("Código de usuário não deverá ter menos que dois caracteres");
            if (CdUsuario.Length > 10)
                messages.Add("Código de usuário não pode ultrapassar 10 caracteres");
            if (string.IsNullOrEmpty(Senha))
                messages.Add("A senha não poderá estar em branco");
            if (Senha.Length < 4)
                messages.Add("A senha deve ter no mínimo 4 caracteres");
            if (Senha.Length > 10)
                messages.Add("A senha não pode ultrapassar 10 caracteres");
            if (!StringExtensions.HasUpperCase(Senha))
                messages.Add("Deve se ter pelo menos uma letra maiúscula na senha.");


            return Result.Factory.New(messages);


        }

    }
}
