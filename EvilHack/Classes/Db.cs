using EvilHack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvilHack.Classes
{
    public class Db
    {
        public static List<Question> Get()
        {
            var q1 = new Question
            {
                QuestionText = "Is Jan evil?",
                CorrectAnswer = "Yes",
                IncorrectAnswer1 = "No",
                IncorrectAnswer2 = "Maybe",
                IncorrectAnswer3 = "I don't know."
            };

            var q2 = new Question
            {
                QuestionText = "Is Nick evil?",
                CorrectAnswer = "No",
                IncorrectAnswer1 = "Yes",
                IncorrectAnswer2 = "Maybe",
                IncorrectAnswer3 = "I don't know."
            };

            var q3 = new Question
            {
                QuestionText = "Is question 3 evil?",
                CorrectAnswer = "Erm",
                IncorrectAnswer1 = "What?",
                IncorrectAnswer2 = "Eh?",
                IncorrectAnswer3 = "Huh?"
            };

            var questions = new List<Question> { q1, q2, q3 };

            return questions;
        }
    }
}