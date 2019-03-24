using BIL.Interfaces;
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

        public UnitOfWork(IContext context, IAnswerRepository answerRepository, IQuestionRepository questionRepository, ITestRepository testRepository)
        {
            db = context;
            _answerRepository = answerRepository;
            _questionRepository = questionRepository;
            _testRepository = testRepository;
        }


        public IAnswerRepository Product
        {
            get; private set;
        }

        public IQuestionRepository Category
        {
            get; private set;
        }

        public ITestRepository Provider
        {
            get; private set;
        }

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
