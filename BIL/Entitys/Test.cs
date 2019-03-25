using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL.Entitys
{
    public class Test
    {
        [Key]
        public int TestId { get; set; }
        [MaxLength(40)]
        public string Name { get; set; }
        public int SecToFinish { get; set; }
        public DateTime TimeOfCreation { get; set; }
        public virtual IQueryable <Question> Questions { get; set; }
    }
}
