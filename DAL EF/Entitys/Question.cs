using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL.Entitys
{
    [Serializable]
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        [MaxLength(90)]
        public string QuestionText { get; set; }
        public int TestId { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
