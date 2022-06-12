using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_1
{

    class Vidu1
    {
        static void Main(string[] args)
        {
            byte[] a = new byte[5];

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("a[{0}] = ", i + 1);
                    a[i] = Convert.ToByte(Console.ReadLine());
                }
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("    {0}    ", a[i]);
                }
            }
            catch (FormatException ex)
            {

                Console.WriteLine("khong nhap ky tu cho mang so");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("khong duoc nhap gia tri nam ngoai mien 0-255");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("loi ! vuot qua pham vi cua mang");
            }
            

            Console.ReadLine();
        }
    }
}
