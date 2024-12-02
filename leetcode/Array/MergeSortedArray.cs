using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Array
{
    internal class MergeSortedArray
    {
        public int[] OptimizationSolution(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = m + n - 1; i > -1; i--)
            {
                if (m == 0)
                {
                    nums1[i] = nums2[n - 1];
                    n -= 1;
                    continue;
                }
                else if (n == 0)
                {
                    break;
                }
                if (nums2[n - 1] >= nums1[m - 1])
                {
                    nums1[i] = nums2[n - 1];
                    n -= 1;
                }
                else
                {
                    nums1[i] = nums1[m - 1];
                    m -= 1;
                }
            }

            return nums1;
        }
    }
}
