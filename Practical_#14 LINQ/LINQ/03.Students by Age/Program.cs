string input = Console.ReadLine();
List<string[]> studentsGroup = new List<string[]>();

while (!input.Equals("END"))
{
    string[] studentNames = input.Split();
    studentsGroup.Add(studentNames);
    input = Console.ReadLine();
}

var result = studentsGroup.Where(x => int.Parse(x[x.Length - 1]) >= 18 && int.Parse(x[x.Length - 1]) <= 24);

foreach (var item in result)
{
    Console.WriteLine($"{item[0]} {item[1]} {item[2]}");
}