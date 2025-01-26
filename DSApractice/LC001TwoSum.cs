using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSApractice
{
    public class LC001TwoSum
    {   
        public int[] TwoSumFunc(int[] nums, int target)
        {
            //Declare HashTable
            Dictionary<int, int> ht = new Dictionary<int, int>();

            //Loop through arr
            for (int i = 0; i < nums.Length; i++)
            {
                int tmp = nums[i];

                if (ht.ContainsKey(target - tmp))
                {
                    return new int[] { ht[target - tmp], i };
                }

                ht[tmp] = i;
            }

            return new int[0];
        }

        public static void Main()
        {
            LC001TwoSum ts = new LC001TwoSum();
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = ts.TwoSumFunc(nums, target);
            Console.WriteLine("[" + nums[0] + "," + nums[1] + "]");

        }
    }
}
