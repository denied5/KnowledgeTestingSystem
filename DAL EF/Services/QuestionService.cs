using AutoMapper;
using BIL.Entitys;
using BIL.Interfaces;
using DAL_EF.DTO;
using DAL_EF.Infrastructure;
using DAL_EF.Interfaces;
using System.Collections.Generic;

namespace DAL_EF.Services
{
    class QuestionService : IQuestionService
    {

        IUnitOfWork _unitOfWork { get; set; }

        public QuestionService(IUnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;
        }

        public void AddQuestion(QuestionDTO questionDTO)
        {
            if (questionDTO == null)
                throw new BILException("question null", "");

            _unitOfWork.Question.Create(Mapper.Map<Question>(questionDTO));
        }

        public void DeleteQuestion(int? id)
        {
            if (id == null)
                throw new BILException("we don't have this id", "");
            else
                _unitOfWork.Question.Delete(id.GetValueOrDefault());
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }

        public QuestionDTO GetQuestion(int? id)
        {
            if (id == null)
                throw new BILException("we don't have this id", "");

            return Mapper.Map<QuestionDTO>(_unitOfWork.Question.Get(id.GetValueOrDefault()));
        }

        public IEnumerable<QuestionDTO> GetQuestions()
        {
            return Mapper.Map<IEnumerable<QuestionDTO>>(_unitOfWork.Question.GetAll());
        }
    }
}
