using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class MainClass
    {
        public static void Main()
        {
            string s = "III ";
            //LongestSubstringWithoutRepeatingCharacters a = new LongestSubstringWithoutRepeatingCharacters();
            RomanToInteger a = new RomanToInteger();
            Console.WriteLine(a.RomanToInt(s));
        }
    }
}
