using BIL.Entitys;
using BIL.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL
{
    class Program
    {
        static void Main(string[] args)
        {

            UnitOfWork f = new UnitOfWork();

            var q = new Question() { QuestionText = "2+2"};
           
            var t = new Test() { Name = "test", SecToFinish = 60, TimeOfCreation = DateTime.Now };
            var a = new Answer() { AnswerText = "4", IsItWright = true};
           
            
            

            f.Question.Create(q);
            f.Answer.Create(a);
            f.Test.Create(t);
            f.Save();
        }
    }
}
