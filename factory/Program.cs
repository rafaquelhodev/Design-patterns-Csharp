using System;
using System.Data;
using System.Data.SqlClient;

namespace factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbConnection myConnection = new FactoryDbConnection().CreateDbConnection();

            IDbCommand command = myConnection.CreateCommand();
            command.CommandText = "select * from table";


        }
    }
}
