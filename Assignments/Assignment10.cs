using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment10
    {
        public void rotate()
        {
            int[] arr1 = new int[3];

            Console.WriteLine("Enter array:");
            for (int i = 0; i < 3; i++)
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            int tem = arr1[0];
            int j = 0;
            for (int i = 1; i < 3; i++)
            {
                (arr1[j]) = arr1[i];
                j++;
            }
            arr1[j] = tem;

            Console.WriteLine("Rotated array:");
            for (int i = 0; i < arr1.Length; i++)
                Console.Write(arr1[i]+" ");
        }
    }
}
