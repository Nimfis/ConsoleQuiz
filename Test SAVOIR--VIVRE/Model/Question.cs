using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_SAVOIR__VIVRE.Model
{
    internal class Question
    {
        public string Text { get; init; }
        public List<Answer> Answers { get; init; }

        public Question(string text, List<Answer> answers, int v)
        {
            Text = text;
            Answers = answers;
        }

        public void DisplayQuestion()
        {
            Console.WriteLine(Text);
            foreach (var answer in Answers)
            {
                Console.WriteLine(answer.Text);
            }
        }

        public const ConsoleColor TextColor = ConsoleColor.DarkCyan;
    }
}
