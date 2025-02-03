using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DSA.Practice
{
    internal class LC125IsPalindrome
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            s = Regex.Replace(s, "[^0-9a-zA-Z]+", "").ToLower();
            int lastIndex = s.Length - 1;
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals(s[lastIndex]))
                {
                    lastIndex--;
                }
                else
                {
                    return false;
                }
            }    
            return true;
        }
    }
}
