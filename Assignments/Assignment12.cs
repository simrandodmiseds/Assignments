using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment12
    {
        public void palindrome()
        {
            Console.WriteLine("Enter string");
            string s = Console.ReadLine();
            int i,j;
            for( i=0,j=(s.Length-1);i<s.Length/2;i++,j--)
            {
                if (s[i] == s[j])
                    continue;
                else
                    break;
            }
            if (i >= (s.Length/2))
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not palindrome");
        }
    }
}
