using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Practice
{
    internal class LC844BackspaceString
    {
        public bool BackspaceCompare(string s, string t)
        {
            if (string.IsNullOrEmpty(s) && string.IsNullOrEmpty(t))
            {
                return true;
            }

            s = ProcessString(s);
            t = ProcessString(t);

            if(s.Equals(t))
            {
                return true;
            }  

            return false;

        }

        private string ProcessString(string s)
        {
            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrEmpty(s))
            {
                foreach (char c in s)
                {
                    if (c == '#')
                    {
                        if (sb.Length > 0)
                        {
                            sb.Length--;
                        }
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }
            }

            return sb.ToString();
        }
    }
}
