namespace Test_SAVOIR__VIVRE
{
    internal class Program
    {
        static void Main()
        {
            var quiz = new Quiz(QuestionsData.Questions);
            quiz.StartQuiz();
        }
    }
}
