using AutoMapper;
using DAL_EF.DTO;
using DAL_EF.Interfaces;
using DAL_EF.Services;
using KnowledgeTestingSystemWebAPI.ViewModels;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KnowledgeTestingSystemWebAPI.Controllers
{
    public class AnswerController : ApiController
    {

        private IAnswerService _answerService;
        public AnswerController(IAnswerService answerService)
        {
            _answerService = answerService;
        }

        // GET: api/Answer
        [HttpGet]
        public IEnumerable<AnswerVM> Get()
        {
            IEnumerable<AnswerDTO> answerDTOs = _answerService.GetAnswers();
            return Mapper.Map<IEnumerable<AnswerVM>>(answerDTOs);
        }

        // GET: api/Answer/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Answer
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Answer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Answer/5
        public void Delete(int id)
        {
        }
    }
}

public class WelcomeMessageServiceModule : NinjectModule
{
    public override void Load()
    {
        this.Bind<IAnswerService>().To<AnswerService>();
    }
}