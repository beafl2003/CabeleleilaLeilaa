using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabeleleilaLeila.Data.Repositories
{
    public class ClienteRepository
    {

        public DataTable LoadFromDataBase(IConfiguration configuration) { 
        
            SqlConnection sqlConnection = ConnectionProvider.GetConnection(configuration);
            sqlConnection.Open();
            var query = "SELECT * FROM Cliente";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }   

            return dataTable;

        }
    }
}
