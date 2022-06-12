using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar;
            System.Console.WriteLine("Creating a Car object and assigning its memory location to myCar");
            myCar = new Car();


            myCar.make = "Toyota";
            myCar.model = "MR2";
            myCar.color = "red";
            myCar.yearBuilt = 1995;


            System.Console.WriteLine("myCar details: ");
            System.Console.WriteLine("myCar.make: " + myCar.make);
            System.Console.WriteLine("myCar.model: "+myCar.model);
            System.Console.WriteLine("myCar.color: "+myCar.color);
            System.Console.WriteLine("myCar.yearBuilt: "+myCar.yearBuilt);


            myCar.Start();
            myCar.Stop();


            System.Console.WriteLine("Creating another Car object and" + "assigning its memory location to redPorsche");

            Car redPorsche = new Car();
            redPorsche.make = "Porsche";
            redPorsche.model = "Boxster";
            redPorsche.color = "Red";
            redPorsche.yearBuilt = 2000;
            Console.WriteLine("redPorsche is a " + redPorsche.model);
            Console.WriteLine("Assigning redPorsche to myCar");

            myCar = redPorsche;
            System.Console.WriteLine("myCar details: ");
            System.Console.WriteLine("myCar.make: " + myCar.make);
            System.Console.WriteLine("myCar.model: " + myCar.model);
            System.Console.WriteLine("myCar.color: " + myCar.color);
            System.Console.WriteLine("myCar.yearBuilt: " + myCar.yearBuilt);

            Console.Read();

        }
    }
    class Car
    {
        public string make;
        public string model;
        public string color;
        public int yearBuilt;

        public void Start()
        {
            System.Console.WriteLine(model + " started");
        }

        public void Stop()
        {
            System.Console.WriteLine(model + "stopped");
        }
    }

    class Window
    {
        protected int top;
        protected int left;
        public Window(int top , int left)
        {
            this.top = top;
            this.left = left;
        }

        

        public virtual void DrawWindow()
        {
            Console.WriteLine("Window: drawing Window at {0}, {1}",top,left);
        }
    }
    class ListBox : Window
    {
        public ListBox(int top, int left, string contents): base(top,left) // call base constructor
        {
            this.listBoxContents = contents;
        }

        

        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("Writing string to the listbox:{0}", listBoxContents);
        }
        private string listBoxContents;
    }

    class Button : Window
    {
        public Button(int top, int left) : base(top, left)
        {
        }

        public override void DrawWindow()
        {
            Console.WriteLine("Drawing a button at {0} , {1}\n", top, left);
        }
    }
    class Polymorphism
    {
        public static void Main(string[] args)
        {
            Window win = new Window(1, 2);
            ListBox lb = new ListBox(3, 4 , "Stand alone list box");
            Button b = new Button(5, 6);

            Console.WriteLine("-------------- Win ---------------");
            win.DrawWindow();
            Console.WriteLine("-------------- lb ---------------");
            lb.DrawWindow();
            Console.WriteLine("-------------- b ---------------");
            b.DrawWindow();
            Console.WriteLine("-------------- array ---------------");
            Window[] winArray = new Window[3];

            winArray[0] = new Window(1, 2);
            winArray[1] = new Window(3, 4);
            winArray[2] = new Window(5, 6);

            for (int i = 0; i < winArray.Length; i++)
            {
                winArray[i].DrawWindow();
            }

            Console.ReadLine();
        }
    }




}
