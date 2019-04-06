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

namespace KnowledgeQuestioningSystemWebAPI.Controllers
{
    public class QuestionController : ApiController
    {
        private IQuestionService _questionService;
        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        // GET: api/Question
        [HttpGet]
        public IEnumerable<QuestionVM> Get()
        {
            IEnumerable<QuestionDTO> questionDTOs = _questionService.GetQuestions();
            return Mapper.Map<IEnumerable<QuestionVM>>(questionDTOs);
        }

        // GET: api/Question/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Question
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Question/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Question/5
        public void Delete(int id)
        {
        }
    }
}
