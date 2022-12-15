using System.Text.RegularExpressions;

var input = Console.ReadLine().Split(new char[] { '/', '\\', '(', ')', ' ' });
var regex = new Regex(@"^[A-Za-z]\w{2,24}$");

List<string> usernames = new List<string>();
foreach (var item in input)
{
    if (regex.IsMatch(item))
    {
        usernames.Add(item);
    }
}

var maxLength = 0;
var winningUsernames = new string[2];

while (usernames.Count > 1)
{
    var firstUser = usernames[0];
    var testLength = firstUser.Length + usernames[1].Length;

    if (testLength > maxLength)
    {
        maxLength = testLength;
        winningUsernames[0] = firstUser;
        winningUsernames[1] = usernames[0];
    }
}

Console.WriteLine($"{winningUsernames[0]}{Environment.NewLine}{winningUsernames[1]}");