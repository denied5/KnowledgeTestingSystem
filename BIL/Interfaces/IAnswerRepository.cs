using BIL.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL.Interfaces
{
    public interface IAnswerRepository
    {
        ICollection<Answer> GetAll();
        Answer Get(int id);
        void Create(Answer Answer);
        void Update(Answer Answer);
        void Delete(int id);
    }
}
