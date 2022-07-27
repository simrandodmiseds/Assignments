using System;
using System.Linq;

namespace Assignments
{
    class Assignment8
    {
        public void longest()
        {
            Console.WriteLine("Enter string:");
            string s = Console.ReadLine();
            int max = 0;
            string[] ans = s.Split(' ');
            string lon=null;
            for (int i = 0; i < ans.Length; i++)
            {
                if (ans[i].Length > max)
                {
                    lon = ans[i];
                    max = ans[i].Length;
                }
            }
            Console.WriteLine(lon);
        }
    }
}
