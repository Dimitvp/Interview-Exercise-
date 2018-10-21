using System;

namespace Exercises
{
    class Program
    {
        public static bool IsPalindrome(string word)
        {
            var lowerString = word.ToLower();
            for (int fL = 0, lL = lowerString.Length - 1; fL < lL; fL++, lL--){
                if (lowerString[fL] != lowerString[lL])
                {
                    return false;
                }
            }
            return true;

        }

        public static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("Deleveled"));
        }
    }
}
