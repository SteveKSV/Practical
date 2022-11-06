using _06.Generic_Count_Method_Doubles;

int n = int.Parse(Console.ReadLine());

GenericCountMethodDoubles<double> generic = new GenericCountMethodDoubles<double>();
generic.List = new List<double>(n);
for (int i = 0; i < n; i++)
{
    generic.List.Add(double.Parse(Console.ReadLine()));
}

double doubleForCompare = double.Parse(Console.ReadLine());

Console.WriteLine(generic.CountMethod(generic.List, doubleForCompare));
