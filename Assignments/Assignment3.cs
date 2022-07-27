using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment3
    {
        public void calculator()
        {
            Console.WriteLine("Enter 2 numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("Enter option for operation:\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\nYour option");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Addition:" + (a + b));
                        break;
                    case 2:
                        Console.WriteLine("Subtraction:" + (a - b));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication:" + (a * b));
                        break;
                    case 4:
                        Console.WriteLine("Division:" + (a / b));
                        break;
                }
            } while (true);
        }
    }
}
