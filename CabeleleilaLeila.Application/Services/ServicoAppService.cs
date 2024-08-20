using CabeleleilaLeila.Data.Repositories;
using CabeleleilaLeila.Domain.Core;
using CabeleleilaLeila.Domain.Enums;
using CabeleleilaLeila.Domain;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Permissions;

namespace CabeleleilaLeila.Application.Services
{
    public class ServicoAppService
    {

        #region fields 
        private readonly CabeleleilaLeila.Data.Repositories.ServicoRepository _servicoRepository;

        #endregion

        #region constructor

        public ServicoAppService()
        {
            _servicoRepository = new Data.Repositories.ServicoRepository();
        }
        #endregion

        #region methods

        public DataTable LoadFromDatabase(IConfiguration config)
        {
            return _servicoRepository.LoadFromDatabase(config);
        }

        public Servico GetServicoById(IConfiguration config, Guid id)
        {
            var usuario = _servicoRepository.GetServicoById(config, id);
            return usuario;
        }

        

       public Servico GetServicoByCodigo(IConfiguration config, string code)
        {
            var usuario = _servicoRepository.GetServicoByCodigo(config, code);
            return usuario;
        }
        public Result NovoServico(IConfiguration config, string cdServico, string descricao, decimal preco)
        {
            var servico = new Servico()
            {
                Id = Guid.NewGuid(),
                CdServico = cdServico,
                Descricao = descricao,
                Preco = preco

            };

            var r = servico.IsValid();
            if (!r.Success)
                return r;

            _servicoRepository.InsertDatabase(config, servico);

            return Result.Factory.True();

        }

        public Result UpdateServico(IConfiguration config, string cdServico, string descricao, decimal preco, Guid id)
        {

            var servico = _servicoRepository.GetServicoById(config, id);
            if (servico == null)
                return Result.Factory.False("Not Found");

            servico.CdServico = cdServico;
            servico.Descricao = descricao;
            servico.Preco = preco;
           


            var r = servico.IsValid();
            if (!r.Success)
                return r;

            _servicoRepository.UpdateDatabase(config, servico);

            return Result.Factory.True();

        }

        public Result DeleteServico(IConfiguration config, Guid id)
        {

            var servico = _servicoRepository.GetServicoById(config, id);
            if (servico == null)
                return Result.Factory.False("Not Found");



            _servicoRepository.DeleteDatabase(config, servico);

            return Result.Factory.True();

        }

        #endregion

    }
}
