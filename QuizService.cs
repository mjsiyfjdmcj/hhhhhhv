using System.Collections.Generic;

namespace BanglaQuiz
{
    public class QuizService
    {
        public List<QuizQuestion> GetQuestions()
        {
            return new List<QuizQuestion>
            {
                new QuizQuestion
                {
                    Id = 1,
                    Question = "মানিকগঞ্জ জেলায় উয়ারী-বটেশ্বর অবস্থিত।",
                    CorrectAnswer = false,
                    Explanation = "নরসিংদী জেলায় উয়ারী-বটেশ্বর অবস্থিত",
                    Marks = 2
                },
                new QuizQuestion
                {
                    Id = 2,
                    Question = "কোম্পানির প্রথম শাসনকর্তা ছিলেন রবার্ট ক্লাইভ।",
                    CorrectAnswer = true,
                    Explanation = "",
                    Marks = 2
                },
                new QuizQuestion
                {
                    Id = 3,
                    Question = "১৯৭১ সালে ২৫শে মার্চ রাতে গণহত্যা হয়।",
                    CorrectAnswer = true,
                    Explanation = "",
                    Marks = 2
                },
                new QuizQuestion
                {
                    Id = 4,
                    Question = "চা-কে 'সোনালি আঁশ' বলা হয়।",
                    CorrectAnswer = false,
                    Explanation = "পাটকে সোনালি আঁশ বলা হয়",
                    Marks = 2
                },
                new QuizQuestion
                {
                    Id = 5,
                    Question = "অতিরিক্ত জনসংখ্যার জন্য কৃষিজমির পরিমাণ বেড়ে যাচ্ছে।",
                    CorrectAnswer = false,
                    Explanation = "অতিরিক্ত জনসংখ্যার জন্য কৃষিজমির পরিমাণ কমে যাচ্ছে",
                    Marks = 2
                }
            };
        }

        public int CalculateScore(Dictionary<int, bool> userAnswers)
        {
            var questions = GetQuestions();
            int score = 0;

            foreach (var question in questions)
            {
                if (userAnswers.ContainsKey(question.Id) && 
                    userAnswers[question.Id] == question.CorrectAnswer)
                {
                    score += question.Marks;
                }
            }

            return score;
        }
    }
}
