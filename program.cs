using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //static = modifier to declare a static member, which belongs to the classs itself
            //              rather than to any specific object

            Car car1 = new Car("Proton");
            Car car2 = new Car("Honda");
            Car car3 = new Car("Lambo");

            Console.WriteLine(Car.numberOfCars);

            Car.StartRace();



            Console.ReadKey();

        }

    }
    class Car
    {

        String model;
        public static int numberOfCars;

        public Car( String model)
        {

            this.model = model;
            numberOfCars++;
        }
        public static void StartRace()
        {
            Console.WriteLine("the race hasa begun");
        }



    }
}






