string input = Console.ReadLine();
List<string[]> studentsGroup = new List<string[]>();

while (!input.Equals("END"))
{
    string[] studentNames = input.Split();
    studentsGroup.Add(studentNames);
    input = Console.ReadLine();
}

var result = studentsGroup.OrderBy(x => x[1]).ThenByDescending(x => x[0]);

foreach (var item in result)
{
    Console.WriteLine($"{item[0]} {item[1]}");
}