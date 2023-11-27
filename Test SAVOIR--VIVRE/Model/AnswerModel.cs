using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_SAVOIR__VIVRE.Model
{
    public class Answer
    {
        public string Text { get; init; }
        public bool IsCorrect { get; init; }

        public Answer(string text, bool isCorrect)
        {
            Text = text;
            IsCorrect = isCorrect;
        }

        public ConsoleColor FinalAnswerColor => IsCorrect ? ConsoleColor.Green : ConsoleColor.Red;

        public const ConsoleColor TextColor = ConsoleColor.White;
    }
}
