using Classes.Person;

//------>>>> 
//------>>>> Abstraction
//------>>>> 


//var person = new Person();





var broker = new Broker("broker xpto pereira", DateTime.Parse("1995-11-30"), "12.345.678/0001-00");
var insurer = new Insurer("insurer xyz da silva", DateTime.Parse("1995-11-30"), "010.001.002-23");

//broker
Console.WriteLine("Broker Name: " + broker.Name);
Console.WriteLine("Broker Age: " + broker.GetAge());                    //method implemented on super-class (abstraction Person)
Console.WriteLine("Broker Document: " + broker.GetDocumentNumber());    //method implemented on sub-class

Console.WriteLine("------------------");

//insurer
Console.WriteLine("Insurer Name: " + insurer.Name);
Console.WriteLine("Insurer Age: " + insurer.GetAge());                  //method implemented on super-class (abstraction Person)
Console.WriteLine("Insurer Document: " + insurer.GetDocumentNumber());  //method implemented on sub-class

if (insurer.BuyInsurace())
    broker.SellInsurace();

Console.ReadKey();