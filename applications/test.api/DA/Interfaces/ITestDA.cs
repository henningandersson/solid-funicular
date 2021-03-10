using test.api.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.api.DA.Interfaces
{
    public interface ITestDA
    {
        public Task<Test> GetById(int id);
    }
}
