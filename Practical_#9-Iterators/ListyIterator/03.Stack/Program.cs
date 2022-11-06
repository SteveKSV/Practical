using _03.Stack;
using System.Globalization;

class Program
{
    private static void Main(string[] args)
    {
        _03.Stack.Stack<int> stack = new _03.Stack.Stack<int>();

        string command = Console.ReadLine();

        while (command != "END")
        {
            try
            {
                string[] inputArgs = command.Split();

                switch (inputArgs[0])
                {
                    case "Push": 
                        for(int i = 1; i < inputArgs.Length; i++)
                        {
                            stack.Push(int.Parse(inputArgs[i]));
                        }
                        break;
                    case "Pop":
                        stack.Pop();
                        break;
                    default: Console.WriteLine("Invalid command!");  break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            command = Console.ReadLine();
        }

        for(int i = 0; i < 2; i++)
        foreach(int number in stack)
        {
            Console.WriteLine(number);
        }
       
    }
}