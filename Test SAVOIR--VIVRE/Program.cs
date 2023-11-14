namespace Test_SAVOIR__VIVRE
{
    internal class Program
    {
        static void Main()
        {
            var question1 = new Question("Który z przykładów dotyczących pozdrawiania jest prawidłowy?", new List<Answer>
            {
                new Answer("młodszy pozdrawia starszego", false),
                new Answer("mężczyzna kobietę", false),
                new Answer("podwładny wita przełożonego", false),
                new Answer("zarówno odp a, b jaki i c są prawidłowe", true)
            }, 3);

            var question2 = new Question("Kto pierwszy mówi dzień dobry, osoba wchodzi do pomieszczenia czy osoby które się w pomieszczeniu znajdują?", new List<Answer>
            {
                new Answer("pierwsze mówią osoby, które się w pomieszczeniu znajdują", true),
                new Answer("pierwsza mówi osoba która wchodzi do pomieszczenia, nawet wtedy gdy jest przełożonym", false),
            }, 0);

            var question3 = new Question("W których z wymienionych sytuacji pozdrawiamy osoby nieznajome?", new List<Answer>
            {
                new Answer("wchodzimy do restauracji i mówimy dzień dobry", false),
                new Answer("wchodząc do windy mówimy dzień dobry", false),
                new Answer("pojawiając się w poczekalni u lekarza mówimy dzień dobry", false),
                new Answer(" w żadnej z tych sytuacji osób nieznajomych nie pozdrawiamy", false),
                new Answer("w każdej z tych sytuacji pozdrawiamy osoby nieznajome", true)
            }, 4);

            var question4 = new Question("Czy prawdą jest jeśli chodzi o przedstawianie się, że?", new List<Answer>
            {
                new Answer("starszy przedstawia się młodszemu", false),
                new Answer("kobieta przedstawia się mężczyźnie", false),
                new Answer("żadna z tych odpowiedzi nie jest prawidłowa", true),
                new Answer("obydwie odpowiedzi są prawidłowe", false)
            }, correctOptionIndex: 2);

            var question5 = new Question("Która z odpowiedzi jest prawidłowa? Kto komu podaje dłoń?", new List<Answer>
            {
                new Answer("starszy podaje dłoń młodszemu", false),
                new Answer("kobieta – mężczyźnie", false),
                new Answer("podwładny – przełożonemu", false),
                new Answer("odpowiedzi a i b są prawidłowe", true)
            }, correctOptionIndex: 2);

            var question6 = new Question("Czy prawdą jest jeśli chodzi o przedstawianie się, że?", new List<Answer>
            {
                new Answer("starszy przedstawia się młodszemu", false),
                new Answer("kobieta przedstawia się mężczyźnie", false),
                new Answer("żadna z tych odpowiedzi nie jest prawidłowa", true),
                new Answer("obydwie odpowiedzi są prawidłowe", false)
            }, correctOptionIndex: 2);

            var question7 = new Question("Czy prawdą jest jeśli chodzi o przedstawianie się, że?", new List<Answer>
            {
                new Answer("starszy przedstawia się młodszemu", false),
                new Answer("kobieta przedstawia się mężczyźnie", false),
                new Answer("żadna z tych odpowiedzi nie jest prawidłowa", true),
                new Answer("obydwie odpowiedzi są prawidłowe", false)
            }, correctOptionIndex: 2);

            var question8 = new Question("Czy prawdą jest jeśli chodzi o przedstawianie się, że?", new List<Answer>
            {
                new Answer("starszy przedstawia się młodszemu", false),
                new Answer("kobieta przedstawia się mężczyźnie", false),
                new Answer("żadna z tych odpowiedzi nie jest prawidłowa", true),
                new Answer("obydwie odpowiedzi są prawidłowe", false)
            }, correctOptionIndex: 2);
            
            var question9 = new Question("Czy prawdą jest jeśli chodzi o przedstawianie się, że?", new List<Answer>
            {
                new Answer("starszy przedstawia się młodszemu", false),
                new Answer("kobieta przedstawia się mężczyźnie", false),
                new Answer("żadna z tych odpowiedzi nie jest prawidłowa", true),
                new Answer("obydwie odpowiedzi są prawidłowe", false)
            }, correctOptionIndex: 2);

            var question10 = new Question("Czy prawdą jest jeśli chodzi o przedstawianie się, że?", new List<Answer>
            {
                new Answer("starszy przedstawia się młodszemu", false),
                new Answer("kobieta przedstawia się mężczyźnie", false),
                new Answer("żadna z tych odpowiedzi nie jest prawidłowa", true),
                new Answer("obydwie odpowiedzi są prawidłowe", false)
            }, correctOptionIndex: 2);



            var quiz = new Quiz();
            quiz.AddQuestion(question1);
            quiz.AddQuestion(question2);
            quiz.AddQuestion(question3);
            quiz.AddQuestion(question4);
            quiz.AddQuestion(question5);
            quiz.AddQuestion(question6);
            quiz.AddQuestion(question7);
            quiz.AddQuestion(question8);
            quiz.AddQuestion(question9);
            quiz.AddQuestion(question10);

            quiz.StartQuiz();
        }
    }
}
