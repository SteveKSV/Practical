string input = Console.ReadLine();
List<string[]> studentsGroup = new List<string[]>();

while (!input.Equals("END"))
{
    string[] studentNames = input.Split();
    studentsGroup.Add(studentNames);
    input = Console.ReadLine();
}

var result = studentsGroup.Where(x => x[x.Length - 1] == "2").OrderBy(x => x[0]);

foreach (var item in result)
{
    Console.WriteLine($"{item[0]} {item[1]}");
}