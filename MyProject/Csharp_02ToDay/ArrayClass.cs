using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_02ToDay
{
    class ArrayClass
    {
        public void Output()
        {
            int[] Arr = new int[12] { 29, 82, 42, 46, 54, 655, 50, 42, 5, 94, 159, 340 };
            Console.WriteLine("The first occurrence of 42 is at index " + Array.IndexOf(Arr, 42));

            Console.WriteLine("The last occurrence of 42 is at index " + Array.IndexOf(Arr , 42));
            int x = 0;
            while ((x = Array.IndexOf(Arr , 42 , x)) >= 0)
            {
                Console.WriteLine("42 found at index " + x);
                ++x;
            }

            x = Arr.Length - 1; 
            while((x = Array.LastIndexOf(Arr ,42 ,x)) >= 0)
            {
                Console.WriteLine("42 found at index " + x);
                --x;
            }

            Console.WriteLine("Array that before sorted");
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine("{0} :        {1}", i + 1, Arr[i]);

            }

            Array.Sort(Arr);
            Console.WriteLine("Array that after sorted");
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine("{0} :        {1}" , i+1 , Arr[i]);
            }


        }
    }
}
