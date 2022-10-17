using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    class Questions // The parent class for all the questions types.
    {
        protected static int num; // Static counter.
        protected int qtype; // Qtype.
        protected string text; // Question text.
        int serial;

        public static int Num
        {
            get
            {
                return num;
            }
        }
        public int Qtype
        {
            get
            {
                return qtype;
            }
        }
        public string Text
        {
            get
            {
                return text;
            }
        }

        public int Serial
        {
            get
            {
                return serial;
            }
        }

        public Questions(string text, int type) // Constructor.
        {
            num++;
            serial = num;
            this.text = text;
            qtype = type;
        }
    }
}
