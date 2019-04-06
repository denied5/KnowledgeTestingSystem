using BIL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL.Interfaces
{
    public interface ITestService: IDisposable
    {
        void AddTest(TestDTO testDTO);
        TestDTO GetTest(int? id);
        ICollection<TestDTO> GetTests();
        TestDTO GetTestWithConnection(int? id);
        void DeleteTest(int? id);
    }
}
