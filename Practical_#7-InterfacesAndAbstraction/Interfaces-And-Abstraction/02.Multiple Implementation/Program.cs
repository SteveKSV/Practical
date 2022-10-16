using _02.Multiple_Implementation;
using Interfaces_And_Abstraction;

Console.WriteLine("Input(name, age, id, birthdate): ");
string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
string id = Console.ReadLine();
string birthdate = Console.ReadLine();


IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
IBirthable birthable = new Citizen(name, age, id, birthdate);

Console.WriteLine("Output: ");
Console.WriteLine(identifiable.ID);
Console.WriteLine(birthable.Birthdate);