using System.Text.RegularExpressions;

var pattern = @"<a.{0,}?(href=?(['|""]?).+?\2).{0,}?>(.+?)<\/a>";

string replacedHtml = "";

var input = Console.ReadLine();

while (input != "end")
{
    var replacedLine = Regex.Replace(input, pattern, m => $"[URL {m.Groups[1].Value}]{m.Groups[3].Value}[/URL]");
    replacedHtml = replacedLine;

    input = Console.ReadLine();
}

Console.WriteLine(string.Join(Environment.NewLine, replacedHtml));