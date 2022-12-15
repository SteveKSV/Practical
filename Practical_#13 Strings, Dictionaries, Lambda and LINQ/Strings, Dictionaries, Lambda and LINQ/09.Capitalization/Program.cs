string[] input = Console.ReadLine().Split(new[] { ' ', ',', '.', '?', '!', ';' });
foreach (string line in input)
{
    for (int i = 0; i < line.Length; i++)
    {
        if(i == 0 || line[i - 1] == ' ')
        {
            Console.Write(char.ToUpper(line[i]) + line.Substring(1) + " "); 
           
        }
    }

}