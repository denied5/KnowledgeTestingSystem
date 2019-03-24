using BIL.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL.Interfaces
{
    public interface ITestRepository
    {
        IQueryable<Test> GetAllIncluding();
        IQueryable<Test> GetAll();
        Test Get(int id);
        void Create(Test Test);
        void Update(Test Test);
        void Delete(int id);
    }
}
