using _02.Generic_Box_Of_Integer;

int n = int.Parse(Console.ReadLine());
int i = 0;

while (i < n)
{
    int number = int.Parse(Console.ReadLine());

    GenericBoxOfInteger<int> currentInteger = new GenericBoxOfInteger<int>(number);
    Console.WriteLine($"\n------------{currentInteger}------------");
    i++;
}