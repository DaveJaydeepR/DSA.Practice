using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Practice
{
    internal class LC027RemoveElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums.Length <= 1) { return nums.Length; }
            var index = 0;
            var lastValue = nums[index];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == lastValue) { continue; }

                nums[++index] = nums[i];
                lastValue = nums[index];
            }
            return index + 1;
        }
    }
}
