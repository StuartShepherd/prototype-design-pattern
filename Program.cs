using PrototypeDesignPattern;

Console.WriteLine("Prototype Design Pattern");
Console.WriteLine("Prototype is a creational design pattern that allows cloning objects, even complex ones, without coupling to their specific classes.");
Console.WriteLine();

var person1 = new Person();
person1.Age = 46;
person1.BirthDate = Convert.ToDateTime("1976-01-01");
person1.Name = "Stuart Shepherd";
person1.IdInfo = new IdInfo(12345);

var person2 = person1.ShallowCopy();
var person3 = person1.DeepCopy();

Console.WriteLine("Original values:");
Console.WriteLine("\tperson1 instance values: ");
DisplayValues(person1);

Console.WriteLine("\tperson2 instance values:");
DisplayValues(person2);

Console.WriteLine("\tperson3 instance values:");
DisplayValues(person3);
Console.WriteLine();

person1.Age = 32;
person1.BirthDate = Convert.ToDateTime("1990-01-01");
person1.Name = "John Smith";
person1.IdInfo.IdNumber = 67890;

Console.WriteLine("Values of person1, person2 and person3 after changes to person1:");
Console.WriteLine("\tperson1 instance values: ");
DisplayValues(person1);

Console.WriteLine("\tperson2 instance values (reference values have changed):");
DisplayValues(person2);

Console.WriteLine("\tperson3 instance values (everything was kept the same):");
DisplayValues(person3);

static void DisplayValues(Person p)
{
    Console.WriteLine("\t\tName: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}", p.Name, p.Age, p.BirthDate);
    Console.WriteLine("\t\tID#: {0:d}", p.IdInfo.IdNumber);
}