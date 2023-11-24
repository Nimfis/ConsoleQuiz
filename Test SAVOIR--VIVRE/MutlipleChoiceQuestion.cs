using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_SAVOIR__VIVRE
{
    internal class MutlipleChoiceQuestion : Question
    {
        internal class MultipleChoiceQuestion : Question
        {
            public int CorrectOptionIndex { get; }

            public MultipleChoiceQuestion(string text, List<Answer> answers, int correctOptionIndex)
                : base(text, answers, 0) 
            {
                CorrectOptionIndex = correctOptionIndex;
            }

            public bool IsAnswerCorrect(int userAnswer)
            {
                return userAnswer == CorrectOptionIndex;
            }
        }
    }
}
