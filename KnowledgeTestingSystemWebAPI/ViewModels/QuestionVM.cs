using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnowledgeTestingSystemWebAPI.ViewModels
{
    public class QuestionVM
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public int TestId { get; set; }
    }
}