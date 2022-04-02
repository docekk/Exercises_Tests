using System;

namespace Exercises
{
    public class CharWar
    {
        public string Battle(string firstWord, string secondWord)
        {
            char[] allChar = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            int pointsFirst = 0;
            int pointsSecond = 0;

            foreach (char c in firstWord)
            {
                pointsFirst += Array.IndexOf(allChar, c) + 1;
            }
            foreach (char c in secondWord)
            {
                pointsSecond += Array.IndexOf(allChar, c) + 1;
            }

            if (pointsFirst > pointsSecond)
            {
                return firstWord;
            }
            else if (pointsFirst < pointsSecond)
            {
                return secondWord;
            }

            return "Tie!";
        }
    }
}
