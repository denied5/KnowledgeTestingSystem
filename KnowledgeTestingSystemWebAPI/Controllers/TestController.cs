using AutoMapper;
using DAL_EF.DTO;
using DAL_EF.Interfaces;
using KnowledgeTestingSystemWebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KnowledgeTestingSystemWebAPI.Controllers
{
    public class TestController : ApiController
    {

        private ITestService _testService;
        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        // GET: api/Test
        [HttpGet]
        public IEnumerable<TestVM> Get()
        {
            IEnumerable<TestDTO> testDTOs = _testService.GetTests();
            return Mapper.Map<IEnumerable<TestVM>>(testDTOs);
        }

        // GET: api/Test/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Test
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Test/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Test/5
        public void Delete(int id)
        {
        }
    }
}
