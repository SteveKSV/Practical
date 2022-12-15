string input = Console.ReadLine();
List<string[]> studentsGroup = new List<string[]>();

while (!input.Equals("END"))
{
    string[] studentNames = input.Split();
    studentsGroup.Add(studentNames);
    input = Console.ReadLine();
}

var result = studentsGroup.Where(x => x[0].Substring(x[0].Length - 2).Equals("14") || x[0].Substring(x[0].Length - 2).Equals("15"));

foreach (var student in result)
{
    Console.WriteLine($"{string.Join(" ", student.Where((x, i) => i > 0))}");
}