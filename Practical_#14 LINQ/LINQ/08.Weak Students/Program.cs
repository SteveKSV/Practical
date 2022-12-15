string input = Console.ReadLine();
List<string[]> studentsGroup = new List<string[]>();

while (!input.Equals("END"))
{
    string[] studentNames = input.Split();
    studentsGroup.Add(studentNames);
    input = Console.ReadLine();
}

var result = studentsGroup.Where(x => x.Where(z => z == "3").Count() + x.Where(z => z == "2").Count() >= 2);

foreach (var item in result)
{
    Console.WriteLine($"{item[0]} {item[1]}");
}