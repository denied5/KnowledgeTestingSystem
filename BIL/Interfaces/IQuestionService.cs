using BIL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL.Interfaces
{
    public interface IQuestionService: IDisposable
    {
        void AddQuestion(QuestionDTO questionDTO);
        QuestionDTO GetQuestion(int? id);
        ICollection<QuestionDTO> GetQuestions();
        void DeleteQuestion(int? id);
    }
}
