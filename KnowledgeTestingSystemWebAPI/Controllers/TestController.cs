using AutoMapper;
using BIL.Interfaces;
using BIL.DTO;
using KnowledgeTestingSystemWebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BIL.Infrastructure;

namespace KnowledgeTestingSystemWebAPI.Controllers
{
    public class TestController : ApiController
    {

        private ITestService _testService;
        public TestController(ITestService testService)
        {
            _testService = testService;
        }


        [HttpGet]
        [Route("api/Test/connections/{id}")]
        public IHttpActionResult GetWithConnection(int id)
        {
            TestDTO testDTOs = _testService.GetTestWithConnection(id);
            return Ok(Mapper.Map<TestVM>(testDTOs));
        }

        [HttpGet]
        [Route("api/Test")]
        public IHttpActionResult Get()
        {
            IEnumerable<TestDTO> testDTOs = _testService.GetTests();
            return Ok(Mapper.Map<IEnumerable<TestVM>>(testDTOs));
        }


        [HttpGet]
        [Route("api/Test/{id}")]
        public IHttpActionResult Get(int id)
        {
            if (id < 0)
            {
                return NotFound();
            }

            TestDTO testDTO;
            try
            {
                testDTO = _testService.GetTest(id);
            }
            catch (BILException myExc)
            {

                return InternalServerError(myExc);
            }
            if (testDTO == null)
            {
                return NotFound();
            }

            return Ok(testDTO);
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
