using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }
    class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod() { return new CarA(); }
    }

    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod() { return new CarB(); }
    }

    class ConcreteCreatorC : Creator
    {
        public override Product FactoryMethod() { return new CarC(); }
    }
}
