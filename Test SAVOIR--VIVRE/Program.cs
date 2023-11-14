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
                new Answer("pierwsza mówi osoba która wchodzi do pomieszczenia, nawet wtedy gdy jest przełożonym", false)
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
            }, correctOptionIndex: 3);

            var question6 = new Question("Czy będąc w grupie ściskając dłoń możemy ją uścisnąć tylko jednej osobie a resztę pominąć?", new List<Answer>
            {
                new Answer("w grupie należy powitać wszystkich tak samo", true),
                new Answer("w grupie podają sobie rękę tylko ci którzy się znają", false),
                new Answer("w grupie podają sobie rękę tylko mężczyźni", false)
            }, correctOptionIndex: 0);

            var question7 = new Question("Jaki powinien być uścisk dłoni?", new List<Answer>
            {
                new Answer("powinien być pewny, ale nie za mocny, w żadnym razie również zbyt słaby", true),
                new Answer("powinien być bardzo silny", false),
                new Answer("powinien być bardzo słabiutki", false)
            }, correctOptionIndex: 0);

            var question8 = new Question("Jak przedstawić sobie wzajemnie osoby – mężczyznę i kobietę?", new List<Answer>
            {
                new Answer("najpierw wymieniamy imię i nazwisko mężczyzny", true),
                new Answer("najpierw wymieniamy imię i nazwisko kobiety", false),
                new Answer("kolejność nie ma znaczenia", false),
            }, correctOptionIndex: 0);
            
            var question9 = new Question("Jak przedstawić sobie wzajemnie osoby – młodszą i starszą?", new List<Answer>
            {
                new Answer("starsza osoba jest przedstawiana młodszej, a następnie młodsza starszej ", false),
                new Answer("młodsza osoba jest przedstawiana starszej, a następnie starsza młodszej", true),
                new Answer("w relacji młodszy – starszy – kolejność jest bez różnicy", false),
            }, correctOptionIndex: 1);

            var question10 = new Question("Co robi się z pięknie ułożoną serwetką na stole, gdzie ją kładziemy?", new List<Answer>
            {
                new Answer("za kołnierzyk", false),
                new Answer("odkładamy na bok", false),
                new Answer("kładziemy ją na kolanach", true),
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
