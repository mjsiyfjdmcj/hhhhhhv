namespace BanglaQuiz
{
    public class QuizQuestion
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public bool CorrectAnswer { get; set; }
        public string Explanation { get; set; }
        public int Marks { get; set; }
    }
}
