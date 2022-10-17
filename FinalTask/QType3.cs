using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    class QType3 : Questions // Inheritance.
    {
        string[] picture;
        string answer;
        public QType3(string text, int type, string img1, string img2, string img3) : base(text, type) // Parent constructor.
        {
            picture = new string[3]; // Imge paths array.
            picture[0] = img1; // first image path.
            picture[1] = img2; // second image path.
            picture[2] = img3; // third image path.
            answer = img3;
        }

        public string[] Picture
        {
            get
            {
                return picture;
            }
        }

        public string Answer
        {
            get
            {
                return answer;
            }
        }
    }
}
