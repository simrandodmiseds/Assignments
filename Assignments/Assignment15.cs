using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment15
    {
        public void remove()
        {
            Console.WriteLine("Enter string");
            string s = Console.ReadLine();
            string ns = null ;
            for(int i=0;i<s.Length;i++)
            {
                if (((s[i] >= 65 && s[i] <= 90) || (s[i] >= 97 && s[i] <= 122) || (s[i] >= 48 && s[i] <= 57)))
                    ns = ns + s[i];
            }
            Console.WriteLine(ns);
        }
    }
}
