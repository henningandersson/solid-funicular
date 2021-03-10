using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace test.api.DA.Connections
{
    public static class Connection
    {
        public static IDbConnection GetConnection(string connString)
        {
            return new NpgsqlConnection(connString);
        }
    }
}
