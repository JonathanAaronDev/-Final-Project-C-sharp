using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    class QType0 : Questions // Inheritance.
    {
        bool answer;
        public QType0(string text, int type, bool answer) : base(text, type) // Parent constructor.
        {
            this.answer = answer;
        }

        public bool Answer
        {
            get
            {
                return answer;
            }
        }
    }
}
