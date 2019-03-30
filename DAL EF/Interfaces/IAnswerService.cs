using DAL_EF.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_EF.Interfaces
{
    public interface IAnswerService : IDisposable
    {
        void AddAnswer(AnswerDTO answerDTO);
        AnswerDTO GetAnswer(int? id);
        IEnumerable<AnswerDTO> GetAnswers();
        void DeleteAnswer(int? id);
    }
}
