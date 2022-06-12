using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookupDictionary
{
    class Program
    {
        Hashtable dictionary = new Hashtable();
        static void Main(string[] args)
        {
            Program program = new Program();
            program.AddDictionary();

            program.Output();

            Console.ReadLine();
            
        }

        public void AddDictionary()
        {
            Console.WriteLine("Enter key : ");
            string key = Console.ReadLine();
            Console.WriteLine("Enter value: ");
            string value = Console.ReadLine();

           dictionary.Add(key, value);
            

        }
        public void DeleteDictionary()
        {
            Console.WriteLine("Enter the delete key : ");

        }
        public void Output()
        {
            ICollection keys = dictionary.Keys;
            Console.WriteLine( dictionary.Contains("lam"));
        }
    }
   
}
