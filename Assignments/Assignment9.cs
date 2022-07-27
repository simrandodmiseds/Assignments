using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment9
    {
        public void sum()
        {
            Console.WriteLine("Enter number:");
            int a = Convert.ToInt32(Console.ReadLine());
            int div, sum = 0;
            while(a!=0)
            {
                div = a % 10;
                sum += div;
                a /= 10;
            }
            Console.WriteLine("Sum of Integers:"+sum);
        }
    }
}
