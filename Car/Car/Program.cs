namespace Car
{
    class CarA : Product
    {

    }
    class CarB : Product
    {

    }
    class CarC : Product
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new DogdeDeveloper("Dogde");
            Car car = dev.Create(10,30);

            dev = new NissanDeveloper("Nissan");
            Car car2 = dev.Create(10,80);

            dev = new FerrariDeveloper("Ferrari");
            Car car3 = dev.Create(10,50);

            Console.WriteLine();
            
        }
    }
}