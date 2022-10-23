using _05.Generic_Count_Method_Strings;

int n = int.Parse(Console.ReadLine());

GenericCountMethodStrings<string> generic = new GenericCountMethodStrings<string>();
generic.List = new List<string>(n);
for (int i = 0; i < n; i++)
{
    generic.List.Add(Console.ReadLine());
}

string strForCompare = Console.ReadLine();

Console.WriteLine(generic.CountMethod(generic.List, strForCompare));