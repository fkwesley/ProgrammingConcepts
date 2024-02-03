namespace Classes.Vehicle
{
    public class Vehicle
    {
        // Constructor Default
        public Vehicle() { }

        // Constructor with parameters
        public Vehicle(string brand, string model, int year, string color)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        //virtual to enable override of this methods
        public virtual void Honk()
        {
            Console.WriteLine("Vehicle Honking!!! Bi Bi!");
        }
    }
}
