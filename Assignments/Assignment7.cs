using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment7
    {
        public bool posneg()
        {
            Console.WriteLine("Enter 2 numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if ((a >= 0 && b < 0) || (a < 0 && b >= 0))
                return true;
            else
                return false;
        }
    }
}
