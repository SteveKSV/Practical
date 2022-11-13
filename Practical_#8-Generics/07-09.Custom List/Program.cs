using _07_09.Custom_List;

CustomList<string> myList = new CustomList<string>();

var inputString = Console.ReadLine();
while (!inputString.Equals("END"))
{
    Execute(inputString, myList);
    inputString = Console.ReadLine();
}

static void Execute(string inputString, ICustomList<string> myList)
{
    var commandArgs = inputString.Split();
    
    switch (commandArgs[0])
    {
        case "Add":
            myList.Add(commandArgs[1]);
            break;
        case "Remove":
            myList.Remove(int.Parse(commandArgs[1]));
            break;
        case "Contains":
            Console.WriteLine(myList.Contains(commandArgs[1]));
            break;
        case "Swap":
            myList.Swap(int.Parse(commandArgs[1]), int.Parse(commandArgs[2]));
            break;
        case "Greater":
            Console.WriteLine(myList.CountGreaterThan(commandArgs[1]));
            break;
        case "Min":
            Console.WriteLine(myList.Min());
            break;
        case "Max":
            Console.WriteLine(myList.Max());
            break;
        case "Print":
            myList.Print();
            break;
        case "Sort":
            myList.Sort();
            break;
        default:
            break;
    }
}