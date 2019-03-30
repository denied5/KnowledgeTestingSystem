using AutoMapper;
using BIL.Entitys;
using BIL.Interfaces;
using DAL_EF.DTO;
using DAL_EF.Infrastructure;
using DAL_EF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_EF.Services
{
    public class AnswerService : IAnswerService
    {
        IUnitOfWork _unitOfWork { get; set; }

        public AnswerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddAnswer(AnswerDTO answerDTO)
        {
            if (answerDTO == null)
                throw new BILException("answer null", "");

            _unitOfWork.Answer.Create( Mapper.Map<Answer>(answerDTO));
        }

        public void DeleteAnswer(int? id)
        {
            if (id == null)
                throw new BILException("we don't have this id", "");
            else
                _unitOfWork.Answer.Delete(id.GetValueOrDefault());
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }

        public AnswerDTO GetAnswer(int? id)
        {
            if (id == null)
                throw new BILException("we don't have this id", "");

            return Mapper.Map<AnswerDTO>(_unitOfWork.Answer.Get(id.GetValueOrDefault()));
        }

        public IEnumerable<AnswerDTO> GetAnswers()
        {
            return Mapper.Map<IEnumerable<AnswerDTO>>(_unitOfWork.Answer.GetAll());
        }
    }
}
