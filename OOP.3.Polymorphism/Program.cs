using Classes.Vehicle;
using System.Numerics;

//------>>>> 
//------>>>> Polymorphism
//------>>>> 

var car = new Car("Audi", "A8", 2015, "Black", 4, "Gasoline");
var bike = new Bicycle("Caloi", "Velox 21 marchas Aro 26", 2020, "Red", true);

//(compile - time polymorphism) 
car.Honk();     //super-class method will be executed
car.Honk(20);   //sub-class method will be executed due the parameter sent

//(runtime polymorphism)
bike.Honk();    //sub-class method will be executed