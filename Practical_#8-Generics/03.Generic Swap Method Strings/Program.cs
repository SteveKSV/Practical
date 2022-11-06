using _03.Generic_Swap_Method_Strings;

int n = int.Parse(Console.ReadLine());
GenericSwapMethodStrings<string> generic = new GenericSwapMethodStrings<string>();
generic.StringList = new List<string>(n);
for (int i = 0; i < n; i++)
{
    string str = Console.ReadLine();
    generic.StringList.Add(str);
}

string[] twoIndexes = Console.ReadLine().Split(" ");

generic.SwapFromList(generic.StringList, int.Parse(twoIndexes[0]), int.Parse(twoIndexes[1]));
Console.WriteLine("-------------------");
generic.PrintElem(generic.StringList);
