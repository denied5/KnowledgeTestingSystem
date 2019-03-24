using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL.Entitys
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        [MaxLength(90)]
        public string QuestionText { get; set; }
        public virtual IQueryable<Answer> Answers { get; set; }
        public int TestId { get; set; }
        public virtual Test Test { get; set; }
    }
}
