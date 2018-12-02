using EvilHack.Models;
using System.Collections.Generic;

namespace EvilHack.Classes
{
    public class Db
    {
        public static List<Question> Questions { get; set; }

        public static List<Question> Get()
        {
            if (Db.Questions == null || Db.Questions.Count == 0)
            {
                Db.Save(new Question
                {
                    QuestionText = "What is the first question",
                    CorrectAnswer = "The correct answer",
                    IncorrectAnswer1 = "An incorrect answer",
                    IncorrectAnswer2 = "Another incorrect answer",
                    IncorrectAnswer3 = "Some other incorrect answer"
                });

                Db.Save(new Question
                {
                    QuestionText = "What is the second question",
                    CorrectAnswer = "The correct answer",
                    IncorrectAnswer1 = "An incorrect answer",
                    IncorrectAnswer2 = "Another incorrect answer",
                    IncorrectAnswer3 = "Some other incorrect answer"
                });

                Db.Save(new Question
                {
                    QuestionText = "What is the third question",
                    CorrectAnswer = "The correct answer",
                    IncorrectAnswer1 = "An incorrect answer",
                    IncorrectAnswer2 = "Another incorrect answer",
                    IncorrectAnswer3 = "Some other incorrect answer"
                });
            }

            return Questions;
        }

        public static void Save(Question question)
        {
            if (Db.Questions == null)
            {
                Db.Questions = new List<Question>();
            }

            Db.Questions.Add(question);
        }
    }


}