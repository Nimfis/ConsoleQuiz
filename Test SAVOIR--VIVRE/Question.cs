using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_SAVOIR__VIVRE
{
    internal class Question
    {
        internal int CorrectAnswerIndex;

        public string Text { get; init; }
        public List<Answer> Answers { get; init; }
        public int CorrectOptionIndex { get; init; }

        public Question(string text, List<Answer> answers, int correctOptionIndex)
        {
            Text = text;
            Answers = answers;
            CorrectOptionIndex = correctOptionIndex;
        }

        public const ConsoleColor TextColor = ConsoleColor.DarkCyan;
    }
}
