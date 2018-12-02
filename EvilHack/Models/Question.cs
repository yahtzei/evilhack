using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvilHack.Models
{
    public class Question
    {
        public string QuestionText { get; set; }

        public string CorrectAnswer { get; set; }
        public bool CorrectChoice { get; set; }

        public string IncorrectAnswer1 { get; set; }
        public bool IncorrectChoice1 { get; set; }

        public string IncorrectAnswer2 { get; set; }
        public bool IncorrectChoice2 { get; set; }

        public string IncorrectAnswer3 { get; set; }
        public string Hint { get; set; }

        public bool IncorrectChoice3 { get; set; }
    }
}