using CabeleleilaLeila.Domain;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace CabeleleilaLeila.Data.Repositories
{
    public class UsuarioRepository
    {
          
        public DataTable LoadFromDatabase(IConfiguration configuration)
        {

            SqlConnection dbConnection = ConnectionProvider.GetConnection(configuration);
            dbConnection.Open();

            var sql = "SELECT * FROM Usuario";
            var command = new SqlCommand(sql, dbConnection);
            var adapter = new SqlDataAdapter(command);
            var datatable = new DataTable();
            adapter.Fill(datatable);

            if(dbConnection.State != ConnectionState.Open)
                dbConnection.Close();

            dbConnection.Dispose();
            dbConnection = null;

            return datatable;

        }
        public Usuario GetUsuarioLogin(IConfiguration configuration, string CdUsuario, string senha)
        {
            SqlConnection dbConnection = ConnectionProvider.GetConnection(configuration);
            dbConnection.Open();
            var sql = $@"
                        SELECT 
                           Id,
                           CdUsuario,
                           NomeUsuario,
                           Ativo,
                           Senha,
                           TipoUsuario
                        FROM
                        Usuario
                        WHERE CdUsuario = @CdUsuario and Senha = @Senha               
                        ";

            var prm = new { CdUsuario = CdUsuario, Senha = senha };
            var usuario = dbConnection.QueryFirstOrDefault<Usuario>(sql, prm);
            dbConnection.Dispose();
            dbConnection = null;

            return usuario;
        }

        public Usuario GetUsuarioPorCodigo(IConfiguration configuration, string CdUsuario)
        {
            SqlConnection dbConnection = ConnectionProvider.GetConnection(configuration);
            dbConnection.Open();
            var sql = $@"
                        SELECT 
                           Id,
                           CdUsuario,
                           NomeUsuario,
                           Ativo,
                           Senha,
                           TipoUsuario
                        FROM
                        Usuario
                        WHERE CdUsuario = @CdUsuario              
                        ";

            var prm = new { CdUsuario = CdUsuario};
            var usuario = dbConnection.QueryFirstOrDefault<Usuario>(sql, prm);
            dbConnection.Dispose();
            dbConnection = null;

            return usuario;
        }

        public Usuario GetUsuarioById(IConfiguration configuration, Guid id)
        {
            SqlConnection dbConnection = ConnectionProvider.GetConnection(configuration);

            dbConnection.Open();
            var sql = $@"
                        SELECT 
                           Id,
                           CdUsuario,
                           NomeUsuario,
                           Ativo,
                           Senha,
                           TipoUsuario
                        FROM
                        Usuario
                        WHERE Id = @Id              
                        ";

            var prm = new { Id = id };
            var usuario = dbConnection.QueryFirstOrDefault<Usuario>(sql, prm);
            dbConnection.Dispose();
            dbConnection = null;

            return usuario;
        }

        public bool InsertDatabase(IConfiguration configuration, Usuario usuario)
        {
            SqlConnection dbConnection = ConnectionProvider.GetConnection(configuration);
            dbConnection.Open();
            var sql = $@"
                
                INSERT INTO Usuario (Id, CdUsuario, NomeUsuario, Ativo, TipoUsuario, Senha )
                VALUES (@Id, @CdUsuario, @NomeUsuario, @Ativo, @TipoUsuario, @Senha);
            
            ";
            var rowsAffected = dbConnection.Execute(sql, usuario);
            if (dbConnection.State == ConnectionState.Open)
                dbConnection.Close();
            dbConnection.Dispose();
            dbConnection = null;

            if (rowsAffected > 0)
                return true;
            else return false;

        }

        public bool UpdateDatabase(IConfiguration configuration, Usuario usuario)
        {

            SqlConnection dbConnection = ConnectionProvider.GetConnection(configuration);
            dbConnection.Open();

            var sql = $@"
                
                UPDATE Usuario
                SET CdUsuario = @CdUsuario, NomeUsuario = @NomeUsuario, Ativo = @Ativo, TipoUsuario = @TipoUsuario,
                Senha = @Senha
                WHERE Id = @Id;
            
            ";

            var command = new SqlCommand(sql, dbConnection);
            command.Parameters.Add(new SqlParameter("@Id", usuario.Id));
            command.Parameters.Add(new SqlParameter("@CdUsuario", usuario.CdUsuario));
            command.Parameters.Add(new SqlParameter("@NomeUsuario", usuario.NomeUsuario));
            command.Parameters.Add(new SqlParameter("@Ativo", usuario.Ativo));
            command.Parameters.Add(new SqlParameter("@TipoUsuario", usuario.TipoUsuario));
            command.Parameters.Add(new SqlParameter("@Senha", usuario.Senha));

            var rowsAffected = command.ExecuteNonQuery();

            if (dbConnection.State == ConnectionState.Open)
                dbConnection.Close();

            dbConnection.Dispose();
            dbConnection = null;

            if (rowsAffected > 0)
                return true;
            else return false;

        }

        public bool DeleteDatabase(IConfiguration configuration, Usuario usuario)
        {

            SqlConnection dbConnection = ConnectionProvider.GetConnection(configuration);
            dbConnection.Open();

            var sql = $@"
                
                DELETE FROM Usuario
                WHERE Id = @Id;
            
            ";

            var command = new SqlCommand(sql, dbConnection);
            command.Parameters.Add(new SqlParameter("@Id", usuario.Id));
           

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
