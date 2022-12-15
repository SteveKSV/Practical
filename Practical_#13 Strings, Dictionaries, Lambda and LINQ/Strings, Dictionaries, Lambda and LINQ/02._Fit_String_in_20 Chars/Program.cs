string input = Console.ReadLine();
string res = "";
if (input.Length < 20)
{
    res = input.PadRight(20, '*');
} else if (input.Length > 20)
{
    res = input.Substring(0, 20);
}

Console.WriteLine(res);