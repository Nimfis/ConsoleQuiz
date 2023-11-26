using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_SAVOIR__VIVRE.Model;

namespace Test_SAVOIR__VIVRE
{
    internal class UserAnswerColorInterpreter : Question
    {
        public bool CorrectAnswer { get; init; }

        public UserAnswerColorInterpreter(string text, bool correctAnswer)
            : base(text, new List<Answer> { new Answer("True", true), new Answer("False", false) }, 0)
        {
            CorrectAnswer = correctAnswer;
        }

        public bool IsAnswerCorrect(bool userAnswer)
        {
            return userAnswer == CorrectAnswer;
        }
    }
}
