using BIL.Entitys;
using BIL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL.Repository
{
    class AnswerRepository: IAnswerRepository
    {
        private IContext db;

        public AnswerRepository(IContext context)
        {
            db = context;
        }

        public IQueryable<Answer> GetAll()
        {
            return db.Answers;
        }

        public Answer Get(int id)
        {
            return db.Answers.Find(id);
        }

        public void Create(Answer Answer)
        {
            db.Answers.Add(Answer);
        }

        public void Update(Answer Answer)
        {
            ((DBContext)db).Entry(Answer).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Answer answer = db.Answers.Find(id);
            if (answer != null)
                db.Answers.Remove(answer);
        }

        public IQueryable<Answer> GetAllIncluding()
        {
            return db.Answers.Include("Question");
        }
    }
}
