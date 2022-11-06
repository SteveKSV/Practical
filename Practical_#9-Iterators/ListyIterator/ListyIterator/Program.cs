using ListyIterator;

ListyIterator<string> myCollection = new ListyIterator<string>();

string command = Console.ReadLine();

while(command != "END")
{
    string[] inputArgs = command.Split();
    try
    {
        switch (inputArgs[0])
        {
            case "Create":
                List<string> items = new List<string>(inputArgs.Length - 1);
                for (int i = 1; i < inputArgs.Length; i++)
                {
                    items.Add(inputArgs[i]);
                }
                myCollection.Create(items);
                break;
            case "HasNext":
                Console.WriteLine(myCollection.HasNext());
                break;
            case "Move":
                Console.WriteLine(myCollection.Move());
                break;
            case "Print":
                myCollection.Print();
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    command = Console.ReadLine();
}