using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class ArrayListDemo
    {
        static void Main(string[] args)
        {


            


            ArrayList arraylist = new ArrayList();
            ArrayList arraylist1 = new ArrayList();

            arraylist.Add("i Macbook");
            arraylist.Add("i Phone");
            arraylist.Add("i Mac");
            arraylist.Add("i EveryThing");

            arraylist.AddRange(arraylist1);
            arraylist.Insert(3, "newProduct");
            for (int i = 0; i < arraylist.Count; i++)
            {
                Console.WriteLine(arraylist[i]);
            }



            // boxing and unboxing

            int valueBoxing = 345;
            object boxed = valueBoxing; //boxed

            // unboxing
            int valueOutOfBox = (int)boxed;
            Console.WriteLine(valueOutOfBox);

            //Icollection.CopyTo

            ArrayList student = new ArrayList();
            student.Add("khoi");
            student.Add("Nam");
            student.Add("Phu");

            student.Reverse();


            string[] studentArray = new string[3];

            student.CopyTo(studentArray,0);


            foreach (string name in studentArray)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine(student.IsSynchronized);

            student.Remove("khoi");
            Console.WriteLine("-----------------------------------");

            foreach (string name in student)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(student.Contains("Phu"));



            // hashtable
            //Idictionary
            Hashtable hashTable = new Hashtable();

            hashTable.Add("t", "Trung");
            hashTable.Add("d", "Trung");
            hashTable.Add("v", "Vinh");
            hashTable.Add("n", "Ngoc");

            hashTable.Remove("t");
            hashTable.Contains("v");

            ICollection keys = hashTable.Keys;
            ICollection values = hashTable.Values;

            foreach (object key in keys)
            {
                Console.WriteLine(key);
            }

            // giup hasstable dc sap sep và khong phan biet viet hoa viet thuong
            SortedList sortedList = new SortedList(hashTable,new CaseInsensitiveComparer());


                     
            


            Console.ReadLine();
        }
    }
}
