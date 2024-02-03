namespace Classes.Vehicle
{
    public class Bicycle : Vehicle
    {
        // Constructor Default
        public Bicycle() { }

        // Constructor with parameters
        public Bicycle(string brand, string model, int year, string color, bool hasBasket) : base(brand, model, year, color)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
            HasBasket = hasBasket;
        }

        //Specifig Attributes
        public bool HasBasket { get; set; }
        private bool BasketFull { get; set; }   //encapsulation

        //Methods
        public void Pedal()
        {
            Console.WriteLine("Pedalling!");
        }

        public bool AddItemsToBasket()
        {
            if (HasBasket)
                BasketFull = true;

            return BasketFull;
        }

        public bool RemoveItemsToBasket()
        {
            if (HasBasket)
                BasketFull = false;

            return BasketFull;
        }

        //runtime polymorphism 
        public override void Honk()
        {
            Console.WriteLine("Bicycle Honking!!!");
        }
    }
}
