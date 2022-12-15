using System.Text.RegularExpressions;
using System.Text;

var sb = new StringBuilder();
var input = Console.ReadLine();

while (input != "end")
{
    sb.Append($"{input}{Environment.NewLine}");
    input = Console.ReadLine();
}

var regex = new Regex(@"^[A-Z][a-z]+\s[A-Z][a-z]+");
var matches = regex.Matches(sb.ToString());

foreach (Match match in matches)
{
    Console.WriteLine(match);
}