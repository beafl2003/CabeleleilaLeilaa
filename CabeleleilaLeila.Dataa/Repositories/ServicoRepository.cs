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
    public class ServicoRepository
    {

        public DataTable LoadFromDatabase(IConfiguration configuration)
        {

            SqlConnection dbConnection = ConnectionProvider.GetConnection(configuration);
            dbConnection.Open();

            var sql = "SELECT * FROM Servico";
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

        public bool InsertDatabase(IConfiguration configuration, Servico servico)
        {
            SqlConnection dbConnection = ConnectionProvider.GetConnection(configuration);
            dbConnection.Open();
            var sql = $@"
                
                INSERT INTO Servico (Id, CdServico, Descricao, Preco)
                VALUES (@Id, @CdServico, @Descricao, @Preco);
            
            ";
            var rowsAffected = dbConnection.Execute(sql, servico);
            if (dbConnection.State == ConnectionState.Open)
                dbConnection.Close();
            dbConnection.Dispose();
            dbConnection = null;

            if (rowsAffected > 0)
                return true;
            else return false;

        }



        public Servico GetServicoById(IConfiguration configuration, Guid id)
        {
            SqlConnection dbConnection = ConnectionProvider.GetConnection(configuration);

            dbConnection.Open();
            var sql = $@"
                        SELECT 
                           Id,
                           CdServico,
                           Descricao,
                           Preco
                        FROM
                        Servico
                        WHERE Id = @Id              
                        ";

            var prm = new { Id = id };
            var servico = dbConnection.QueryFirstOrDefault<Servico>(sql, prm);
            dbConnection.Dispose();
            dbConnection = null;

            return servico;
        }

        public Servico GetServicoByCodigo(IConfiguration configuration, string codigo)
        {
            SqlConnection dbConnection = ConnectionProvider.GetConnection(configuration);

            dbConnection.Open();
            var sql = $@"
                        SELECT 
                           Id,
                           CdServico,
                           Descricao,
                           Preco
                        FROM
                        Servico
                        WHERE CdServico = @CdServico              
                        ";

            var prm = new { CdServico = codigo };
            var servico = dbConnection.QueryFirstOrDefault<Servico>(sql, prm);
            dbConnection.Dispose();
            dbConnection = null;

            return servico;
        }


        public bool UpdateDatabase(IConfiguration configuration, Servico servico)
        {

            SqlConnection dbConnection = ConnectionProvider.GetConnection(configuration);
            dbConnection.Open();

            var sql = $@"
                
                UPDATE Servico
                SET CdServico = @CdServico, Descricao = @Descricao, Preco = @Preco
                WHERE Id = @Id;
            
            ";

            var command = new SqlCommand(sql, dbConnection);
            command.Parameters.Add(new SqlParameter("@Id", servico.Id));
            command.Parameters.Add(new SqlParameter("@CdServico", servico.CdServico));
            command.Parameters.Add(new SqlParameter("@Descricao", servico.Descricao));
            command.Parameters.Add(new SqlParameter("@Preco", servico.Preco));

            var rowsAffected = command.ExecuteNonQuery();

            if (dbConnection.State == ConnectionState.Open)
                dbConnection.Close();

            dbConnection.Dispose();
            dbConnection = null;

            if (rowsAffected > 0)
                return true;
            else return false;

        }

        public bool DeleteDatabase(IConfiguration configuration, Servico servico)
        {

            SqlConnection dbConnection = ConnectionProvider.GetConnection(configuration);
            dbConnection.Open();

            var sql = $@"
                
                DELETE FROM Servico
                WHERE Id = @Id;
            
            ";

            var command = new SqlCommand(sql, dbConnection);
            command.Parameters.Add(new SqlParameter("@Id", servico.Id));


            var rowsAffected = command.ExecuteNonQuery();

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
