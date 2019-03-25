using BIL.Interfaces;
using BIL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL.UnitOfWorks
{
    public class UnitOfWork: IUnitOfWork, IDisposable
    {
        private IContext db;
        private IAnswerRepository _answerRepository;
        private IQuestionRepository _questionRepository;
        private ITestRepository _testRepository;

        public UnitOfWork(/*IContext context, IAnswerRepository answerRepository, IQuestionRepository questionRepository,
             ITestRepository testRepository */)
        {
            //db = context;
            //_answerRepository = answerRepository;
            //_questionRepository =  questionRepository;
            //_testRepository = testRepository;

            db = new DBContext();
            _answerRepository = new AnswerRepository(db);
            _questionRepository = new QuestionRepository(db);
            _testRepository = new TestRepository(db);
        }

        public IAnswerRepository Answer { get => _answerRepository; private set => _answerRepository = value; }
        public IQuestionRepository Question { get => _questionRepository; private set => _questionRepository = value; }
        public ITestRepository Test { get => _testRepository; private set => _testRepository = value; }

        public void Save()
        {
            ((DBContext)db).SaveChanges();
        }

        private bool disposed = false;

        

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    ((DBContext)db).Dispose();
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
