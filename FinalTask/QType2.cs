using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    class QType2 : Questions // Inheritance.
    {
        bool answer;
        string img;

        public QType2(string text, int type, bool answer, string image) : base(text, type) // Parent constructor
        {
            this.answer = answer;
            img = ($@"..\\..\\Qimages\\{image}"); // Question image.
        }
        public bool Answer
        {
            get
            {
                return answer;
            }
        }

        public string Img 
        {
            get
            {
               return img;
            }
        }
    }
}
