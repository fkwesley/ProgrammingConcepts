using System.Reflection;

namespace Classes.Vehicle
{
    public class Car : Vehicle
    {
        // Constructor Default
        public Car() { }

        // Constructor with parameters
        public Car(string brand, string model, int year, string color, int numberOfDoors, string fuel) : base(brand, model, year, color)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
            NumberOfDoors = numberOfDoors;
            Fuel = fuel;
        }

        //Specifig Attributes
        public int NumberOfDoors { get; set; }
        public string Fuel { get; set; }
        private bool EngineRunning { get; set; }    //Encapsulation

        //Methods
        public bool StartEngine()
        {
            EngineRunning = true;

            return EngineRunning;
        }

        public bool StopEngine()
        {
            EngineRunning = false;

            return EngineRunning;
        }

        //compile-time polymorphism
        public void Honk(int seconds)
        {
            Console.WriteLine("Car Honking for " + seconds + " seconds !!! Biiiiiiiiiiiiiiii Bi!");
        }
    }
}