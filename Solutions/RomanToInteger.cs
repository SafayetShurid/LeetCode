using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class RomanToInteger
    {
        
            public int RomanToInt(string s)
            {
               
                int sum = 0;

            for (int i = s.Length-1; i!=-1 ; i--)
            {
                char current = s[i];
                int currentVal = GetInt(current);

                if (i != 0)
                {
                   
                    char previous = s[i - 1];

                    
                    int previousVal = GetInt(previous);

                    if (previousVal< currentVal)
                    {
                        sum = sum + (currentVal - previousVal);
                        i--;
                    }
                    else
                    {
                        sum += currentVal;
                    }
                }
                else
                {
                    sum += currentVal;
                }
            }

                return sum;
            }

        public int GetInt(char c)
        {
            switch (c)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return 0;

            }
        }
        
    }
}
