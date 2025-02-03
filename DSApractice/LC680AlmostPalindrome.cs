using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DSA.Practice
{
    internal class LC680AlmostPalindrome
    {
        public bool ValidPalindrome(string s)
        {
            int l = 0, r = s.Length - 1;

            while (l < r)
            {
                if (s[l] != s[r])
                {
                    return IsPalindrome(s, l + 1, r) || IsPalindrome(s, l, r - 1);
                }
                l++;
                r--;
            }
            return true;
        }

        private bool IsPalindrome(string s, int l, int r)
        {
            while (l < r)
            {
                if (s[l] != s[r]) return false;
                l++;
                r--;
            }
            return true;
        }
    }
}
