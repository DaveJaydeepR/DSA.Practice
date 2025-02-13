using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Practice
{
    internal class LC088MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            //If m==0 copy all the elements from nums2 in nums1
            if (m == 0)
            {
                for (int index = 0; index < n; index++)
                {
                    nums1[index] = nums2[index];
                }
            }
            else if (n != 0)
            {
                var mIndex = m - 1;
                var nIndex = n - 1;
                var rIndex = m + n - 1;

                while (nIndex != -1) //Stop traversing when there are no elements left in nums2
                {
                    if (mIndex != -1)
                    {
                        //Compare the nth element in nums2 and 
                        //mth element in nums1
                        if (nums2[nIndex] >= nums1[mIndex])
                        {
                            nums1[rIndex] = nums2[nIndex];
                            nIndex--;
                        }
                        else
                        {
                            nums1[rIndex] = nums1[mIndex];
                            mIndex--;
                        }
                    }
                    else
                    {
                        nums1[rIndex] = nums2[nIndex];
                        nIndex--;
                    }
                    rIndex--;
                }
            }
        }
    }
}
