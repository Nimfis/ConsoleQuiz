using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_SAVOIR__VIVRE
{
    internal class Answer
    {
        public string Text { get; init; }
        public bool IsCorrect { get; init; }

        public Answer(string text, bool isCorrect)
        {
            Text = text;
            IsCorrect = isCorrect;
        }
    }
}
