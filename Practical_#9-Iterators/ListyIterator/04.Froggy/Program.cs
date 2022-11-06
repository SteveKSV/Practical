
using _04.Froggy;

string str = Console.ReadLine();

string[] arrayStr = str.Split(',');

int[] stones = new int[arrayStr.Length];
for (int i = 0; i < arrayStr.Length; i++)
{
    stones[i] = int.Parse(arrayStr[i]);
}

Lake<int> path = new Lake<int>(stones);

foreach (int stone in path)
{
    Console.Write(stone + " ");
}
