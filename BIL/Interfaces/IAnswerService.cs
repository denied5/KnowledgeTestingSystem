using BIL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL.Interfaces
{
    public interface IAnswerService : IDisposable
    {
        void AddAnswer(AnswerDTO answerDTO);
        AnswerDTO GetAnswer(int? id);
        ICollection<AnswerDTO> GetAnswers();
        void DeleteAnswer(int? id);
        void Change(int id, AnswerDTO answerDTO);
    }
}
