using DAL_EF.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_EF.Interfaces
{
    public interface IQuestionService: IDisposable
    {
        void AddQuestion(QuestionDTO questionDTO);
        QuestionDTO GetQuestion(int? id);
        IEnumerable<QuestionDTO> GetQuestions();
        void DeleteQuestion(int? id);
    }
}
