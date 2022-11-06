using _02.Collection;

ListyIterator<string> myCollection = new ListyIterator<string>();
int counter = 0;
string command = Console.ReadLine();

while (command != "END")
{
    counter++;
    if (counter >= 1 && counter <= 100)
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
                case "PrintAll":
                    myCollection.PrintAll();
                    break;
                default:
                    Console.WriteLine("Invali Command!");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        command = Console.ReadLine();
    } else
    {
        Console.WriteLine("The range of commands is [1...100]");
        return;
    }
}