using AutoMapper;
using BIL.DTO;
using BIL.Infrastructure;
using BIL.Interfaces;
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

        [HttpGet]
        [Route("api/Answer")]
        public IHttpActionResult Get()
        {
            IEnumerable<AnswerDTO> answerDTOs = _answerService.GetAnswers();
            return Ok(Mapper.Map<IEnumerable<AnswerVM>>(answerDTOs));
        }

        [HttpGet]
        [Route("api/Answer/{id}")]
        public IHttpActionResult Get(int id)
        {
            if (id < 0)
            {
                return NotFound();
            }

            AnswerDTO answerDTO;
            try
            {
                answerDTO = _answerService.GetAnswer(id);
            }
            catch (BILException myExc)
            {

                return InternalServerError(myExc);
            }
            if (answerDTO == null)
            {
                return NotFound();
            }
            
            return Ok(answerDTO);
        }

        [HttpPost]
        [Route("api/Answer")]
        public IHttpActionResult Post([FromBody]AnswerDTO answerDTO)
        {
            if (answerDTO == null)
            {
                return BadRequest();
            }

            _answerService.AddAnswer(answerDTO);
            return Ok();
        }

        [HttpPost]
        [Route("api/Answer/{id}")]
        public IHttpActionResult Put(int id, [FromBody]AnswerDTO answerDTO)
        {
            if (id == null || answerDTO == null )
            {
                return BadRequest();
            }
            try
            {
                _answerService.Change(id, answerDTO);
            }
            catch (BILException myExc)
            {
                return InternalServerError(myExc);
            }
            return Ok();
        }

        // DELETE: api/Answer/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                _answerService.DeleteAnswer(id);
            }
            catch (BILException myExc)
            {
                return InternalServerError(myExc);
            }
            return Ok();
        }
    }
}