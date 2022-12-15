using System.Text.RegularExpressions;

string emailPattern = Console.ReadLine();
string text = Console.ReadLine();

string[] emailDecoupled = emailPattern.Split('@');

char[] c = emailDecoupled[0].ToCharArray();
for(int i = 0; i < emailDecoupled[0].Length; i++)
{
    c[i] = '*';
}

emailDecoupled[0] = new string(c);

string email = string.Join("", emailDecoupled);

string res = Regex.Replace(text, emailPattern, email);

Console.WriteLine(res);