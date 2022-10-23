using _04.Generic_Swap_Method_Integers;

int n = int.Parse(Console.ReadLine());
GenericSwapMethodIntegers<int> generic = new GenericSwapMethodIntegers<int>();
generic.IntList = new List<int>(n);
for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    generic.IntList.Add(num);
}

string[] twoIndexes = Console.ReadLine().Split(" ");

generic.SwapFromList(generic.IntList, int.Parse(twoIndexes[0]), int.Parse(twoIndexes[1]));
Console.WriteLine("-------------------");
generic.PrintElem(generic.IntList);
