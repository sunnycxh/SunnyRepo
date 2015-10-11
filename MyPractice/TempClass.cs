using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractice
{
    public class TempClass
    {
        public int Number = 1;
        public string Text = "Hehe";

        public TempClass(int number, string text)
        {
            Number = number;
            Text = text;
        }

        ~TempClass()
        { }
    }
}
