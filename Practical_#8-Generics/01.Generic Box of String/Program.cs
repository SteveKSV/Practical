using _01.Generic_Box_Of_String;

int n = int.Parse(Console.ReadLine());
int i = 0;

while (i < n)
{
    string str = Console.ReadLine();

    GenericBoxOfString<string> currentString = new GenericBoxOfString<string>(str);
    Console.WriteLine($"\n------------{currentString}------------");
    i++;
}