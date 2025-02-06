using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Practice
{
    internal class LC1249MakeValidParentheses
    {
        public string MinRemoveToMakeValid(string s)
        {
            char[] temp = s.ToCharArray();
            Stack<int> stack = new Stack<int>();
            for (int i=0; i< s.Length;i++)
            {
                if (temp[i] == '(')
                {
                    stack.Push(i);
                }
                else if(s[i] == ')' && stack.Count > 0)
                {
                    stack.Pop();
                }
                else if (temp[i] ==')' && stack.Count == 0)
                {
                    temp[i] = '*';
                }
            }

            while (stack.Any())
            {
                int index = stack.Pop();
                temp[index] = '*';
            }
            return new string(temp).Replace("*","");

        }
    }
}
