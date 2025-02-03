using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Practice
{
    internal class LC003LongestSubString
    {
        public int LengthOfLongestSubstring(string s)
        {

            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            int n = s.Length;
            int maxLength = 0;
            int left = 0; // Start of the window
            int right = 0; // End of the window
            HashSet<char> charSet = new HashSet<char>(); // Keep track of characters in the window

            while (right < n)
            {
                char c = s[right];

                if (!charSet.Contains(c))
                {
                    charSet.Add(c);
                    maxLength = Math.Max(maxLength, right - left + 1); // Update max length
                    right++; // Expand the window
                }
                else
                {
                    charSet.Remove(s[left]); // Shrink the window from the left
                    left++;
                }
            }

            return maxLength;
        }
    }
}
