using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    class QType1 : Questions // Inheritance.
    {
        string[] answers;
        string answer;
        public QType1(string text, int type, string one, string two, string three) : base(text, type) // Parent constructor.
        {
            answers = new string[3]; // Answers array.
            answers[0] = one; // answer one.
            answers[1] = two; // answer two.
            answers[2] = three; // answer thrre.
            answer = one;
        }

        public string[] Answers
        {
            get
            {
                return answers;
            }
        }
    }
}
