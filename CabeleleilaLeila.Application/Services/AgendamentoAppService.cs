using CabeleleilaLeila.Data.Repositories;
using CabeleleilaLeila.Domain;
using CabeleleilaLeila.Domain.Core;
using CabeleleilaLeila.Domain.Enums;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabeleleilaLeila.Application.Services
{
    public class AgendamentoAppService
    {

        #region fields 
        private readonly CabeleleilaLeila.Data.Repositories.AgendamentoRepository _agendamentoRepository;
        #endregion

        #region constructor

        public AgendamentoAppService()
        {
            _agendamentoRepository = new Data.Repositories.AgendamentoRepository();
        }
        #endregion


        #region methods

        public DataTable LoadFromDatabase(IConfiguration config)
        {
            return _agendamentoRepository.LoadFromDatabase(config);
        }

        public DataTable LoadAgendaServFromDatabase(IConfiguration config)
        {
            return _agendamentoRepository.LoadAgendaServFromDatabase(config);
        }

        public Agendamento GetAgendamentoById(IConfiguration config, long num)
        {
            var agendamento = _agendamentoRepository.GetAgendamentoById(config, num);
            return agendamento;
        }

        public DataTable GetAgendamentoServicoById(IConfiguration config, long num)
        {
            var agendamento = _agendamentoRepository.GetAgendamentoServicoById(config, num);
            return agendamento;
        }

        public AgendamentoServio GetAgendamentoServicoEById(IConfiguration config, long num)
        {
            var agendamento = _agendamentoRepository.GetAgendamentoServicoEById(config, num);
            return agendamento;
        }

        public Result NovoAgendamento(IConfiguration config, Guid clienteId, TipoAgendamentoEnum status, DateTime dtAgendamento,decimal preco)
        {
            var agendamento = new Agendamento()
            {
                ClienteId = clienteId,
                Status = status,
                DtAgendamento = dtAgendamento,
                PrecoTotal = preco,
                CriadoEm = DateTime.Now

            };


            if (_agendamentoRepository.InsertDatabase(config, agendamento))
                return Result.Factory.True();
            else
                return Result.Factory.False();

        }

        public Result NovoAgendamentoServico(IConfiguration config, long numAgendamento, string cdServico, decimal preco)
        {
            var agendamento = new AgendamentoServio()
            {
                NumAgendamento = numAgendamento,
                CdServico = cdServico,
                Preco = preco

            };


            if (_agendamentoRepository.InsertServicoDatabase(config, agendamento))
                return Result.Factory.True();
            else
                return Result.Factory.False();

        }
        #endregion
    }
}
