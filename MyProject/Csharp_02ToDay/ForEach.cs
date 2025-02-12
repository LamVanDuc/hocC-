﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_02ToDay
{
    class ForEach
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------ foreach statement----------------------");
            DateTime now = DateTime.Now;
            Random rand = new Random((int)now.Millisecond);
            int[] Arr = new int[10];
            for(int x = 0; x <Arr.Length; x++)
            {
                Arr[x] = rand.Next() % 100;

            }

            int Total = 0;
            Console.Write("Array values are ");
            foreach (int val in Arr)
            {
                Total += val;
                    Console.Write(val + " ");

            }

            Console.WriteLine("\nAnd the average is {0,0:F1}", ((double)Total / (double)Arr.Length));
            Console.WriteLine("------------------ Array of Object ----------------------");

            ObjectArray arr = new ObjectArray();
            arr.Run();

            Console.WriteLine("------------------ Array Class ----------------------");
            ArrayClass a = new ArrayClass();
            a.Output();
            Console.ReadLine();
        }
    }
}
