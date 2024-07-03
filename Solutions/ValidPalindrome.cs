using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {

            for (int i = 0, j = s.Length - 1;  i < j; i++, j--)
            {
                while(i<j && Char.IsLetterOrDigit(s[i]))
                {
                    i++;
                }
                while(i<j && Char.IsLetterOrDigit(s[j]))
                {
                    j--;
                }

                if (Char.ToLower(s[i]) != Char.ToLower(s[j]))
                {
                    return false;
                }

            }

            return true;
        }
        
    }
}
