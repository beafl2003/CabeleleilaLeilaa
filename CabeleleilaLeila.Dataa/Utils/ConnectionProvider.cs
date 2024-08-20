using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace CabeleleilaLeila.Data
{
    public static class ConnectionProvider
    {

        public static SqlConnection GetConnection(IConfiguration configuration)
        {
            var dbConnection = new System.Data.SqlClient.SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            return dbConnection;
        }

       
    }
}