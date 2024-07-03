using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class TwoSum
    {       
        public static int[] TwoSums(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            int x;

            for (int i = 0; i < nums.Length; i++)
            {
                x = target - nums[i];
                if (dict.ContainsKey(x))
                {                    
                    return new int[] { dict[x], i };
                }

                dict.TryAdd(nums[i], i);
            }

            return null;
        }

    }
}
