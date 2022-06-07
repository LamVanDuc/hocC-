using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Bai66.Output();
            Console.ReadLine();
        }
    }
    class Bai58
    {
        public static void Output()
        {
            int[] a = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("a["+i +"] : ");
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write(a[i] + " ");
            }  
        }
    }   
    class Bai59
    {
        public static void Output()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int maxValue = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
            }

            Console.WriteLine(maxValue);
        
        }
    }
    class Bai60
    {
        public static void Output()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write(arr[0] + arr[n - 1]);
        }
    }
    class Bai61
    {
        public static void Output()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
    class Bai62
    {
        public static void Output()
        {
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];

                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                int k = int.Parse(Console.ReadLine());

                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] == k)
                    {
                        count++;
                    }
                }
                Console.Write(count);
            }
    }
    class Bai63
    {
        public static void Output()
        {
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];

                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                int answer = 0;
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] % 2 != 0 && arr[i] > 0)
                    {
                        answer += arr[i];
                    }
                }
                Console.Write(answer);
            }
    }
        class Bai64
        {
            public static void Output()
            {
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];

                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < n; i++)
                {
                    if (arr[i] >= 0 && arr[i] <= 10)
                    {
                        Console.Write(arr[i] + " ");
                    }
                }
            }
        }
    class Bai65
    {
        public static void Output()
        {
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("arr["+i+"] : ");
                    arr[i] = int.Parse(Console.ReadLine());
                }

               for(int i = 0; i< n; i++)
                {
                    for(int j = 0; j <n; j++)
                    {
                        if(arr[i] < arr[j])
                        {
                            int temp = arr[j];
                            arr[j] = arr[i];
                            arr[i] = temp;
                        }
                         
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
    }
    class Bai66
    {
        public static void Output()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("arr["+i+","+j+"] : ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int answer = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    answer += arr[i, j];
                }
            }
            Console.WriteLine("answer : "+answer);
        }
    }
    class Bai67
    {
        public static void Output()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int answer = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] % 5 == 0)
                    {
                        answer += arr[i, j];
                    }
                }
            }
            Console.WriteLine(answer);
        }
    }
}
