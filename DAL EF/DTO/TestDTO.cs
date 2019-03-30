using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_EF.DTO
{
    public class TestDTO
    {
        public int TestId { get; set; }
        public string Name { get; set; }
        public int SecToFinish { get; set; }
        public DateTime TimeOfCreation { get; set; }
    }
}
