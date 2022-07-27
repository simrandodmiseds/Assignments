using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment11
    {
        public void middle()
        {
            int[] arr1 = new int[3];
            int[] arr2 = new int[3];
            int[] arr3 = new int[3];

            Console.WriteLine("Enter 3 arrays:");
            for (int i = 0; i < 3; i++)
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 3; i++)
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 3; i++)
                arr3[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(arr1[arr1.Length / 2] + " " + arr2[arr2.Length / 2] + " " + arr3[arr3.Length / 2]);
        }
    }
}
