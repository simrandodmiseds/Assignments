using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment14
    {
        public void conversion()
        {
            Console.WriteLine("Enter string");
            string s = Console.ReadLine();
            int stoi = Convert.ToInt32(s);
            Console.WriteLine(stoi);

            Console.WriteLine("Enter integer");
            int i = Convert.ToInt32(Console.ReadLine());
            string itos =Convert.ToString( i);
            Console.WriteLine(itos);
        }
    }
}
