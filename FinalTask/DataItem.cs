using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    class DataItem
    {
        protected static int num; // Static counter.
        protected int serial; // Object specific counter.
        protected string text; // Info text.

        public string Text // property.
        {
            get
            {
                return text;
            }
        }

        public int Serial // Property.
        {
            get
            {
                return serial;
            }
        }

        public static int Num // Property.
        {
            get
            {
                return num;
            }
        }
        public DataItem(string text) // Constructor
        {
            num++;
            this.text = text;
            serial = Num;
        }
    }
}
