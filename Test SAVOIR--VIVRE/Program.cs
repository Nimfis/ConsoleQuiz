namespace Test_SAVOIR__VIVRE
{
    internal class Program
    {
        static void Main()
        {
            var quiz = new Quiz();
            
            quiz.AddQuestion(QABase.question1);
            quiz.AddQuestion(QABase.question2);
            quiz.AddQuestion(QABase.question3);
            quiz.AddQuestion(QABase.question4);
            quiz.AddQuestion(QABase.question5);
            quiz.AddQuestion(QABase.question6);
            quiz.AddQuestion(QABase.question7);
            quiz.AddQuestion(QABase.question8);
            quiz.AddQuestion(QABase.question9);
            quiz.AddQuestion(QABase.question10);

            quiz.StartQuiz();
        }
    }
}
