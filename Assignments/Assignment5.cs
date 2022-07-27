using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment5
    {
        public void fourtimes()
        {
            Console.WriteLine("Enter number:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number with space:");
            for (int i = 1; i <= 4; i++)
                Console.Write( n + " ");
            Console.WriteLine("\nNumber without blank space:");
            for (int i = 1; i <=4; i++)
                Console.Write(n);
        }
    }
}
