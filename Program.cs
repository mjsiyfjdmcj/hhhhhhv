using System;
using System.Collections.Generic;

namespace BanglaQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            var quizService = new QuizService();
            var questions = quizService.GetQuestions();
            var userAnswers = new Dictionary<int, bool>();

            Console.WriteLine("=== শুদ্ধ-অশুদ্ধ পরীক্ষা (মোট নম্বর: ১০) ===\n");

            foreach (var question in questions)
            {
                Console.WriteLine($"প্রশ্ন {question.Id}: {question.Question}");
                Console.WriteLine($"নম্বর: {question.Marks}");
                Console.Write("উত্তর (শুদ্ধ/অশুদ্ধ): ");
                
                string input = Console.ReadLine()?.Trim().ToLower();
                bool answer = input == "শুদ্ধ" || input == "true" || input == "t";
                userAnswers[question.Id] = answer;
                Console.WriteLine();
            }

            int totalScore = quizService.CalculateScore(userAnswers);
            
            Console.WriteLine("\n=== ফলাফল ===");
            Console.WriteLine($"আপনার প্রাপ্ত নম্বর: {totalScore}/১০");
            
            Console.WriteLine("\n=== সঠিক উত্তর ===");
            foreach (var question in questions)
            {
                string correctAnswer = question.CorrectAnswer ? "শুদ্ধ" : "অশুদ্ধ";
                Console.WriteLine($"{question.Id}. {correctAnswer}");
                if (!string.IsNullOrEmpty(question.Explanation))
                {
                    Console.WriteLine($"   ব্যাখ্যা: {question.Explanation}");
                }
            }
        }
    }
}
