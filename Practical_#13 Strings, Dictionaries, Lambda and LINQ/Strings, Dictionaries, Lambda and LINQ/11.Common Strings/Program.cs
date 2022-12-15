string input_1 = Console.ReadLine();
string input_2= Console.ReadLine();

for (int i = 0; i < input_1.Length; i++)
{
    string substr1 = input_1.Substring(i, 1);

    for (int j = 0; j < input_2.Length; j++)
    {
        string substr2 = input_2.Substring(j, 1);

        if (substr1 == substr2)
        {
            Console.WriteLine("yes");
            return;
        }
    }
}

Console.WriteLine("no");