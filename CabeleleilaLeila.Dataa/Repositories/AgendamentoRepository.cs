using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CabeleleilaLeila.Domain;
using Dapper;

namespace CabeleleilaLeila.Data.Repositories
{
    public class AgendamentoRepository
    {

        public DataTable LoadFromDatabase(IConfiguration configuration)
        {

            SqlConnection dbConnection = ConnectionProvider.GetConnection(configuration);
            dbConnection.Open();

            var sql = "SELECT * FROM Agendamento";
            var command = new SqlCommand(sql, dbConnection);
            var adapter = new SqlDataAdapter(command);
            var datatable = new DataTable();
            adapter.Fill(datatable);

            if (dbConnection.State != ConnectionState.Open)
                dbConnection.Close();

            dbConnection.Dispose();
            dbConnection = null;

            return datatable;

        }

        public DataTable LoadAgendaServFromDatabase(IConfiguration configuration)
        {

            SqlConnection dbConnection = ConnectionProvider.GetConnection(configuration);
            dbConnection.Open();

            var sql = $@"
            SELECT 
            Agendamento.NumAgendamento,
            Servico.CdServico,
            Servico.Descricao,
            Servico.Preco
            FROM
            Agendamento
            LEFT JOIN AgendamentoServico ON AgendamentoServico.NumAgendamento = Agendamento.NumAgendamento
            LEFT JOIN Servico ON Servico.CdServico = AgendamentoServico.CdServico

            ";
            var command = new SqlCommand(sql, dbConnection);
            var adapter = new SqlDataAdapter(command);
            var datatable = new DataTable();
            adapter.Fill(datatable);

            if (dbConnection.State != ConnectionState.Open)
                dbConnection.Close();

            dbConnection.Dispose();
            dbConnection = null;

            return datatable;

        }

        public Agendamento GetAgendamentoById(IConfiguration configuration, long num)
        {
            SqlConnection dbConnection = ConnectionProvider.GetConnection(configuration);

            dbConnection.Open();
            var sql = $@"
                        SELECT 
                           NumAgendamento,
                           ClienteId,
                           Status,
                           CriadoEm,
                           DtAgendamento,
                           PrecoTotal
                        FROM
                        Agendamento
                        WHERE NumAgendamento = @NumAgendamento             
                        ";

            var prm = new { NumAgendamento = num };
            var agendamento = dbConnection.QueryFirstOrDefault<Agendamento>(sql, prm);
            dbConnection.Dispose();
            dbConnection = null;

            return agendamento;
        }

        public AgendamentoServio GetAgendamentoServicoEById(IConfiguration configuration, long num)
        {
            SqlConnection dbConnection = ConnectionProvider.GetConnection(configuration);

            dbConnection.Open();
            var sql = $@"
                        SELECT 
                    Agendamento.NumAgendamento,
                    Servico.CdServico,
                    Servico.Descricao,
                    Servico.Preco
                    FROM
                    Agendamento
                    LEFT JOIN AgendamentoServico ON AgendamentoServico.NumAgendamento = Agendamento.NumAgendamento
                    LEFT JOIN Servico ON Servico.CdServico = AgendamentoServico.CdServico
                    WHERE Agendamento.NumAgendamento = @NumAgendamento          
                        ";

            var prm = new { NumAgendamento = num};
            var agendamento = dbConnection.QueryFirstOrDefault<AgendamentoServio>(sql, prm);
            var datatable = new DataTable();
            dbConnection.Dispose();
            dbConnection = null;

            return agendamento;
        }

        public DataTable GetAgendamentoServicoById(IConfiguration configuration, long num)
        {
            SqlConnection dbConnection = ConnectionProvider.GetConnection(configuration);

            dbConnection.Open();
            var sql = $@"
                        SELECT 
                    Agendamento.NumAgendamento,
                    Servico.CdServico,
                    Servico.Descricao,
                    Servico.Preco
                    FROM
                    Agendamento
                    LEFT JOIN AgendamentoServico ON AgendamentoServico.NumAgendamento = Agendamento.NumAgendamento
                    LEFT JOIN Servico ON Servico.CdServico = AgendamentoServico.CdServico
                    WHERE Agendamento.NumAgendamento = {num}          
                        ";

            var command = new SqlCommand(sql, dbConnection);
            var adapter = new SqlDataAdapter(command);
            var datatable = new DataTable();
            adapter.Fill(datatable);

            dbConnection.Dispose();
            dbConnection = null;

            return datatable;
        }

        public bool InsertDatabase(IConfiguration configuration, Agendamento agendamento)
        {
            SqlConnection dbConnection = ConnectionProvider.GetConnection(configuration);
            dbConnection.Open();
            var sql = $@"
                
                INSERT INTO Agendamento (ClienteId, Status, CriadoEm, DtAgendamento, PrecoTotal)
                VALUES (@ClienteId, @Status, @CriadoEm, @DtAgendamento, @PrecoTotal);
            
            ";
            var rowsAffected = dbConnection.Execute(sql, agendamento);
            if (dbConnection.State == ConnectionState.Open)
                dbConnection.Close();
            dbConnection.Dispose();
            dbConnection = null;

            if (rowsAffected > 0)
                return true;
            else return false;

        }

        public bool InsertServicoDatabase(IConfiguration configuration, AgendamentoServio agendamento)
        {
            SqlConnection dbConnection = ConnectionProvider.GetConnection(configuration);
            dbConnection.Open();
            var sql = $@"
                
                INSERT INTO AgendamentoServico (NumAgendamento, CdServico, Preco)
                VALUES (@NumAgendamento, @CdServico, @Preco);
            
            ";
            var rowsAffected = dbConnection.Execute(sql, agendamento);
            if (dbConnection.State == ConnectionState.Open)
                dbConnection.Close();
            dbConnection.Dispose();
            dbConnection = null;

            if (rowsAffected > 0)
                return true;
            else return false;

        }



    }
}
