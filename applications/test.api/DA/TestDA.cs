using test.api.DA.Connections;
using test.api.DA.Interfaces;
using test.api.DatabaseEntities;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace test.api.DA
{
    public class TestDA : ITestDA
    {
        private readonly IConfiguration config;

        public TestDA(IConfiguration config)
        {
            this.config = config ?? throw new ArgumentNullException(nameof(config));
        }

        public async Task<Test> GetById(int id)
        {
            using (IDbConnection conn = Connection.GetConnection(config.GetConnectionString("DefaultConnection")))
            {
                var query = "SELECT Id, Name FROM test WHERE ID = @ID";
                conn.Open();
                var result = await conn.QueryAsync<Test>(query, new { ID = id });
                return result.FirstOrDefault();
            }
        }
    }
}
