using System;

namespace demo_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(100, 40, "Land Rover", "Range Rover");

            Console.WriteLine(car1.AddFuel(30));
            


        }
    }
}
