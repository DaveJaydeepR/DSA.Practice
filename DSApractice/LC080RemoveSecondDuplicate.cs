using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Practice
{
    internal class LC080RemoveSecondDuplicate
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 2) // Check if the array has fewer than 2 elements
            {
                return nums.Length; // Return the length of the array as no duplicates exist
            }
            int k = 2;
            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[i] != nums[k - 2])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            return k;
        }
    }
}
