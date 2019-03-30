using DAL_EF.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_EF.Interfaces
{
    interface ITestService: IDisposable
    {
        void AddTest(TestDTO testDTO);
        TestDTO GetTest(int? id);
        IEnumerable<TestDTO> GetTests();
        void DeleteTest(int? id);
    }
}
