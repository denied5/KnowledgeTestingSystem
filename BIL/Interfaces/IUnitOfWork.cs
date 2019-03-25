namespace BIL.Interfaces
{
    internal interface IUnitOfWork
    {
        IAnswerRepository Answer { get;}
        IQuestionRepository Question { get;}
        ITestRepository Test { get;}
        void Save();
        void Dispose(bool disposing);
        void Dispose();
    }
}