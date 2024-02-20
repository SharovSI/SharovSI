using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    abstract class Car
    { }
    class DogdeCar : Car
    {
        public DogdeCar(int km, int speed)
        {
            Console.WriteLine("Dogde");
            Console.WriteLine($"приехал {km * speed} за 10 часов");            
            Console.WriteLine($"Скорость: {speed}");
            int time = km / speed;           
            Console.WriteLine("--------------------------------");
        }
    }
    class FerrariCar : Car
    {
        public FerrariCar(int km, int speed)
        {
            Console.WriteLine("Ferrari");
            Console.WriteLine($"приехал {km * speed} за 10 часов");
            Console.WriteLine($"Скорость: {speed}");
            int time = km / speed;
            Console.WriteLine("--------------------------------");
        }
    }
    class NissanCar : Car
    {
        public NissanCar(int km, int speed)
        {
            Console.WriteLine($"Nissan");
            Console.WriteLine($"приехал {km * speed} за 10 часов");
            Console.WriteLine($"Скорость: {speed}");
            int time = km / speed;
            Console.WriteLine("--------------------------------");
        }
    }
}
