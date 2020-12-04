using System.Data;
using System.Data.SqlClient;

namespace factory
{
    public class FactoryDbConnection
    {
        public IDbConnection CreateDbConnection()
        {
            IDbConnection myConnection = new SqlConnection();

            myConnection.ConnectionString = @"Server=.\SQLExpress;Database=myFactoryDataBase;Trusted_Connection=True;";
            myConnection.Open();

            return myConnection;
        }
    }
}