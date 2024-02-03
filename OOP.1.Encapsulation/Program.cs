using Classes.Vehicle;
using Classes.Person;

//------>>>> 
//------>>>> Encapsulation
//------>>>> 

//Car to be purchased (initializing seting parameters)
var car = new Car("Audi","A8",2015,"Black", 4,"Gasoline");

var engineTest = car.StartEngine();  //Trying to turn on the car engine

if (engineTest)
{
    car.StopEngine();                  //Turning off the car engine
    car.Honk();

    var person = new Client();      //Person who will buy the car
    var carStore = new CarStore();  //Store where the car will be purchased
    bool result = carStore.BuyCar(car, person);

    if (result)
        Console.WriteLine("Car successfully purchased.");
}
else
{
    Console.WriteLine("Engine Test Failed");
}

