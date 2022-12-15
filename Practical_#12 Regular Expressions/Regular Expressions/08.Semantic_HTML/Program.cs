using System.Text;
using System.Text.RegularExpressions;

internal class Program
{
    public static void Main()
    {
        var html = ReadInput();
        var pattern = @"(<\s*?(div)\s*?([\s\S]+?)\s*(class|id)\s*?=\s*?(""|')([a-zA-Z]+)\5([\s\S]*?)\s*)>([\s\S]*?)(<\s*?\/\s*?\2\s*?>\s*<\s*!--\s*\6\s*--\s*>)";

        while (Regex.IsMatch(html, pattern))
        {
            var match = Regex.Match(html, pattern);
            var tagType = match.Groups[6].Value;

            if (tagType == "main" || tagType == "header" || tagType == "nav" || tagType == "article" ||
                tagType == "section" || tagType == "aside" || tagType == "footer")
            {
                var sb = new StringBuilder();

                sb.Append(string.Join(" ",
                    $"<{tagType}{match.Groups[3].Value}{match.Groups[7].Value}"
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)));

                sb.Append('>');
                sb.Append(match.Groups[8].Value);
                sb.Append($"</{tagType}>");

                html = Regex.Replace(html, pattern, sb.ToString());
            }
        }
        Console.Write(html);
    }

    private static string ReadInput()
    {
        var sb = new StringBuilder();
        var input = Console.ReadLine();

        while (input != "END")
        {
            sb.Append($"{input}{Environment.NewLine}");
            input = Console.ReadLine();
        }

        return sb.ToString();
    }
}
