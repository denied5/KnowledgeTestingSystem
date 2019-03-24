namespace BIL.Interfaces
{
    internal interface IUnitOfWork
    {
        IAnswerRepository Product { get;}
        IQuestionRepository Category { get;}
        ITestRepository Provider { get;}
        void Save();
        void Dispose(bool disposing);
        void Dispose();
    }
}