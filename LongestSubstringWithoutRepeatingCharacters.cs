using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            int highest = 0;
            int start = 0;
            int end = 0;

            Dictionary<int,char> chars = new Dictionary<int,char>();
            //pdfdss
            for (int i = 0; i < s.Length; i++)
            {
                if (!chars.ContainsValue(s[i]))
                {
                    chars.Add(i,s[i]);            
                }
                else
                {
                    start = chars[s[i]] +1;
                    highest = chars.Count > highest ? chars.Count : highest;
                    chars.Clear();
                   // chars.Add(s[i], i);
                }

            }

            highest = chars.Count > highest ? chars.Count : highest;
            return highest;
        }
    }
}
