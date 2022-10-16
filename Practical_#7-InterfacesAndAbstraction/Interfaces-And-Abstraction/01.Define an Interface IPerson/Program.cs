using Interfaces_And_Abstraction;
Console.WriteLine("Input (name, age): ");
string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
IPerson person = new Citizen(name, age);

Console.WriteLine("Output: ");
Console.WriteLine(person.Name);
Console.WriteLine(person.Age);