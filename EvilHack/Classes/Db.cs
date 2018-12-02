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
                    QuestionText = "Who is mostlikely to be a target of a cyber crime?",
                    CorrectAnswer = "Everyone",
                    IncorrectAnswer1 = "Adults",
                    IncorrectAnswer2 = "Elderly",
                    IncorrectAnswer3 = "Children",
                    Hint = "Realize that you are an attractive target to hackers. Don’t ever say “It won’t happen to me.”"
                });

                Db.Save(new Question
                {
                    QuestionText = "Which of these passwords would you most likely pick as your passsword?",
                    CorrectAnswer = "P3ngu1ns!",
                    IncorrectAnswer1 = "DogDogDog",
                    IncorrectAnswer2 = "Password1",
                    IncorrectAnswer3 = "MyFirstAddress01",
                    Hint = "Practice good password management. Use a strong mix of characters, and don’t use the same password for multiple sites. Don’t share your password with others, don’t write it down, and definitely don’t write it on a post-it note attached to your monitor."
                });

                Db.Save(new Question
                {
                    QuestionText = "Which is the best practice for locking your devices when you leave them unattended?",
                    CorrectAnswer = "Whenever I leave the room",
                    IncorrectAnswer1 = "Whenever I leave it, and people I don't know are in the room",
                    IncorrectAnswer2 = "Whenever leave it, and anyone is in the room",
                    IncorrectAnswer3 = "I don't have password set up on my devices",
                    Hint = "Never leave your devices unattended. If you need to leave your computer, phone, or tablet for any length of time—no matter how short—lock it up so no one can use it while you’re gone. If you keep sensitive information on a flash drive or external hard drive, make sure to lock it up as well"
                });

                Db.Save(new Question
                {
                    QuestionText = "What do you do when you receive an email with a link or attachment, from a familiar source?",
                    CorrectAnswer = "Hover over the link to check the source or scan the attachments",
                    IncorrectAnswer1 = "Click the on link or download the files and check if they are safe",
                    IncorrectAnswer2 = "Make sure the email is from someone I know",
                    IncorrectAnswer3 = "Respond and ask if the link or attachments are safe",
                    Hint = "Always be careful when clicking on attachments or links in email. If it’s unexpected or suspicious for any reason, don’t click on it. Double check the URL of the website the link takes you to: bad actors will often take advantage of spelling mistakes to direct you to a harmful domain."
                });

                Db.Save(new Question
                {
                    QuestionText = "When is it safe to use open WiFi?",
                    CorrectAnswer = "Never",
                    IncorrectAnswer1 = "Only from well known brands",
                    IncorrectAnswer2 = "Always",
                    IncorrectAnswer3 = "Ask employees or frends if its safe",
                    Hint = "Sensitive browsing, such as banking or shopping, should only be done on a device that belongs to you, on a network that you trust. Whether it’s a friend’s phone, a public computer, or a cafe’s free WiFi—your data could be copied or stolen."
                });

                Db.Save(new Question
                {
                    QuestionText = "How often do you update your software?",
                    CorrectAnswer = "Whenever possible",
                    IncorrectAnswer1 = "I try not to update too often",
                    IncorrectAnswer2 = "Never",
                    IncorrectAnswer3 = "When I have 1 min left till very important meeting",
                    Hint = "Back up your data regularly, and make sure your anti-virus software is always up to date."
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