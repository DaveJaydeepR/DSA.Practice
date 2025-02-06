using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Practice
{
    internal class LC020IsValidPalindrome
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char,char> matchingBrackets = new Dictionary<char, char> {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }

            foreach (char ch in s)
            {
                if (matchingBrackets.ContainsValue(ch))
                {
                    stack.Push(ch);
                }
                else if (matchingBrackets.ContainsKey(ch))
                {
                    if (stack.Count == 0 || stack.Pop() != matchingBrackets[ch])
                    {
                        return false;
                    }
                }
            }

            return false;
        }
    }
}
