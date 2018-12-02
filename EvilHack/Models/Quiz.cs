using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvilHack.Models
{
    public class Quiz
    {
        public Quiz(List<Question> questions)
        {
            this.Questions = questions;
        }

        public List<Question> Questions { get; set; }
    }
}