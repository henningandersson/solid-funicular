using test.api.DA.Interfaces;
using test.api.DatabaseEntities;
using test.api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.api.Services
{
    public class TestService : ITestService
    {
        private readonly ITestDA bostadsrattsforeningDA;

        public TestService(ITestDA bostadsrattsforeningDA)
        {
            this.bostadsrattsforeningDA = bostadsrattsforeningDA;
        }

        public Task<Test> GetById(int id)
        {
            return bostadsrattsforeningDA.GetById(id);
        }
    }
}
