using test.api.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.api.Services.Interfaces
{
    public interface ITestService
    {
        public Task<Test> GetById(int id);
    }
}
