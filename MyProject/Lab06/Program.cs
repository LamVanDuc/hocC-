using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    //class Program
    //{
    //    public void Increment(ref int X);
  
    //    public static void Add2(ref int x)
    //    {
    //        x += 2;
    //    }

    //    public static void Add3(ref int x) {
    //        x += 3;
    //    }
    //    static void Main(string[] args)
    //    {
    //        Increment functionDelegate = Add2;
    //        functionDelegate += Add3;
    //        functionDelegate += Add2;
    //        int x = 5;
    //        functionDelegate(ref x);
    //        Console.ReadLine();
    //    }
    //}
    class Thermostat
    {
        private float _CurrentTemperature;
        public delegate void TemperatureChangeHandler(float newTemperature);

        private TemperatureChangeHandler _OnTemperatureChange;
        public TemperatureChangeHandler OnTemperatureChange
        {
            get { return _OnTemperatureChange; }
            set { _OnTemperatureChange = value; }
        }
        public float CurrentTemperature
        {
            get { return _CurrentTemperature; }
            set
            {
                if (value != CurrentTemperature)
                {
                    _CurrentTemperature = value;
                    if (OnTemperatureChange !=null)
                    {
                        OnTemperatureChange(value);
                    }
                }
            }
        }
        
    }
    class Cooler
    {
        private float _Temperature;
        public Cooler(float temperature)
        {
            temperature = temperature;
        }

        public float Temperature
        {
            get { return _Temperature; }
            set { _Temperature = value; }
            
        }
        public void OnTemperatureChanged(float newTemperature)
        {
            if (newTemperature > Temperature)
            {
                Console.WriteLine("Cooler : ON");
            }
            else
            {
                Console.WriteLine("Cooler : Off");
            }
        }
    }

    class Heater
    {
        public Heater(float temperature)
        {
            Temperature = temperature;
        }
        public float Temperature
        {
            get { return _Temperature; }
            set { _Temperature = value; }
        }
        private float _Temperature;
        public void  OnTemperatureChanged(float newTemperature)
        {
            if (newTemperature < Temperature)
            {
                Console.WriteLine("Heater : On");
            }
            else
            {
                Console.WriteLine("Heater : Off");
            }
        }
    }


    class Test
    {
        static void Main(string[] args)
        {
            Thermostat thermostat = new Thermostat();
            Heater heater = new Heater(60);
            thermostat.OnTemperatureChange += heater.OnTemperatureChanged;


            Heater heaterCuong = new Heater(100);
            thermostat.OnTemperatureChange += heaterCuong.OnTemperatureChanged;



            Cooler cooler = new Cooler(80);
            thermostat.OnTemperatureChange += cooler.OnTemperatureChanged;

            string temperature;
            Console.Write("Enter temperature : ");
            temperature = Console.ReadLine();
            thermostat.CurrentTemperature = int.Parse(temperature);
            Console.ReadLine();
        }
    }
}
