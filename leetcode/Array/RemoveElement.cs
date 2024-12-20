using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Array
{
    internal class RemoveElement
    {
        public int inits(int[] nums, int val)
        {
            int answer = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[answer] = nums[i];
                    answer++;
                }
            }

            return answer;
        }
    }
}
