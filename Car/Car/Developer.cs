using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    abstract class Developer
    {
        public string Name { get; set; }

        public Developer(string n)
        {
            Name = n;
        }
        // фабричный метод
        abstract public Car Create(int km,int speed);
    }
    class DogdeDeveloper : Developer
    {
        public DogdeDeveloper(string n) : base(n)
        { }

        public override Car Create(int km, int speed)
        {
            return new DogdeCar(km,speed);
        }

    }
    class NissanDeveloper : Developer
    {
        public NissanDeveloper(string n) : base(n)
        { }

        public override Car Create(int km, int speed)
        {
            return new NissanCar(km,speed);
        }
    }
    class FerrariDeveloper : Developer
    {
        public FerrariDeveloper(string n) : base(n)
        { }

        public override Car Create(int km, int speed)
        {
            return new FerrariCar(km,speed);
        }
    }
}
