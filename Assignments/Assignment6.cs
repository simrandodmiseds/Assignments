using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment6
    {
        public void replaceString()
        {
            Console.WriteLine("Enter string:");
            string s = Console.ReadLine();
            StringBuilder s1 = new StringBuilder();
            char tem1 = s.ElementAt(0);
            char tem2 = s.ElementAt(s.Length - 1);
            s1.Append(tem2);
            for (int i = 1; i < s.Length-1; i++)
                s1.Append(s[i]);
            s1.Append(tem1);
            Console.WriteLine(s1);
        }
    }
}
