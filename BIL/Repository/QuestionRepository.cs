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
    class QuestionRepository: IQuestionRepository
    {
        private IContext db;

        public QuestionRepository(IContext context)
        {
            db = context;
        }

        public IQueryable<Question> GetAll()
        {
            return db.Questions;
        }

        public Question Get(int id)
        {
            return db.Questions.Find(id);
        }

        public void Create(Question Question)
        {
            db.Questions.Add(Question);
        }

        public void Update(Question Question)
        {
            ((DBContext)db).Entry(Question).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Question question = db.Questions.Find(id);
            if (question != null)
                db.Questions.Remove(question);
        }

        public IQueryable<Question> GetAllIncluding()
        {
            IQueryable<Question> qwery = db.Questions.Include("Answers");
            return qwery.Include("Test");
        }
    }
}
