using Classes.Vehicle;

//------>>>> 
//------>>>> Inheritance
//------>>>> 

//initializing objects
var car = new Car("Audi", "A8", 2015, "Black", 4, "Gasoline");
var bike = new Bicycle("Caloi", "Velox 21 marchas Aro 26", 2020,"Red", true);

//using commom attributes/methods (both vehicles can honk)
car.Honk();     
bike.Honk();

Console.WriteLine("Car Brand: " + car.Brand);
Console.WriteLine("Car Model: " + car.Model);
Console.WriteLine("Car Year: " + car.Year);
Console.WriteLine("Car Color: " + car.Color);

Console.WriteLine("Bike Brand: " + bike.Brand);
Console.WriteLine("Bike Model: " + bike.Model);
Console.WriteLine("Bike Year: " + bike.Year);
Console.WriteLine("Bike Color: " + bike.Year);

//using specific attributes/methods
car.StartEngine();
car.StopEngine();

bike.Pedal();
bike.AddItemsToBasket();
bike.RemoveItemsToBasket();

Console.WriteLine("Car Color: " + car.NumberOfDoors);
Console.WriteLine("Car Color: " + car.Fuel);

Console.WriteLine("Car Color: " + bike.HasBasket);