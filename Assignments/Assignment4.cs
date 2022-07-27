using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment4
    {
        public void multiplication()
        {
            Console.WriteLine("Enter number:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Table of "+ n+":");
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(n * i);
        }
    }
}
