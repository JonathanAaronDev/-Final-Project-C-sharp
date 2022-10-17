using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    class DataItemWithPicture : DataItem // Inheritance.
    {
        string image;
        public DataItemWithPicture(string text, string img) : base(text) // Constructor, using the father class constructor.
        {
            image = img; // Image Path.
        }

        public string Image // Property.
        {
            get
            {
                return image;
            }
        }
    }
}
