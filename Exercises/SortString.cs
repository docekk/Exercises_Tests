using System;
using System.Linq;

namespace Exercises
{

    public class SortString
    {
        public string Longest(string input1, string input2)
        {
            string Text = input1 + input2;

            char[] distinctText = Text.Distinct().ToArray();
            Array.Sort(distinctText);
            return new string(distinctText);
        }
    }
}
