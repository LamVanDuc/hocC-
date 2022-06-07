using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BaiTap
{
    public class Bai1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello C#");
            Console.WriteLine("Hello Word!");
            Console.WriteLine("Lam van duc");
            Console.WriteLine("------------------bai 2--------------");
            Bai2 bai2 = new Bai2();
            bai2.OutPut();
            Console.WriteLine("------------------bai 3--------------");
            Bai3.Output();
            Console.WriteLine("------------------bai 4--------------");
            Bai4.Output();
            Console.WriteLine("------------------bai 5--------------");
            Bai5.Output();
            Console.WriteLine("------------------bai 6--------------");
            Bai6.Output();
            Console.WriteLine("------------------bai 7--------------");
            Bai7.Output();
            Console.WriteLine("------------------bai 8--------------");
            Bai8.Output();
            Console.ReadKey();
        }
    }
}
