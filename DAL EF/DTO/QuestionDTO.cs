﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_EF.DTO
{
    public class QuestionDTO
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public int TestId { get; set; }
    }
}
