using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL.Entitys
{
    public class Answer
    {
        [Key]
        public int AnswerId { get; set; }
        public bool IsItWright { get; set; }
        [MaxLength(90)]
        public string  AnswerText { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
