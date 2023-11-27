using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_SAVOIR__VIVRE.Model;

namespace Test_SAVOIR__VIVRE
{
    internal class MutlipleChoiceQuestion : QuestionModel
    {
        private static int userAnswer;

        public bool IsAnswerCorrect(int userAnswer)
        {
            return userAnswer == CorrectOptionIndex;
        }
        public int CorrectOptionIndex { get; init; }
    
        public MutlipleChoiceQuestion(string text, List<Answer> answers, int correctOptionIndex)
            : base(text, answers, userAnswer)
        {
            CorrectOptionIndex = correctOptionIndex;
        }
    }
}
