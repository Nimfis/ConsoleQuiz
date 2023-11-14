using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_SAVOIR__VIVRE
{
    internal class Question
    {
        public string Text { get; init; }
        public List<Answer> Options { get; init; }
        public int CorrectOptionIndex { get; init; }

        public Question(string text, List<Answer> options, int correctOptionIndex)
        {
            Text = text;
            Options = options;
            CorrectOptionIndex = correctOptionIndex;
        }
    }

}
