using System.Text.RegularExpressions;

var key = Console.ReadLine();
var text = Console.ReadLine();

var regex = Regex.Matches(text, $@"[^.!?]+?\b{key}\b[^.!?]+?[!?.]", RegexOptions.IgnoreCase);

foreach (Match match in regex)
{
    Console.WriteLine(match.Value);
}