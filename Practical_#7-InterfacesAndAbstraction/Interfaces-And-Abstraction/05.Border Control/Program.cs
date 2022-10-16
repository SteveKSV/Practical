using _05.Border_Control;

string inputString = Console.ReadLine();

List<Citizen> citizens = new List<Citizen>();

List<Robot> robots = new List<Robot>();

while (inputString != "End")
{
    string[] inputArray = inputString.Split();

    if (inputArray.Length == 3)
    {
        citizens.Add(new Citizen(inputArray[0], int.Parse(inputArray[1]), inputArray[2]));
    }
    else
    {
        robots.Add(new Robot(inputArray[0], inputArray[1]));
    }

    inputString = Console.ReadLine();
}

string lastNumbersOfFakeIds = Console.ReadLine();


foreach (Citizen currentCitizen in citizens)
{
    int count = 0;
    char[] numbers = lastNumbersOfFakeIds.ToCharArray();
    char[] arrayOfId = currentCitizen.Id.ToCharArray();

    numbers = numbers.Reverse().ToArray();
    arrayOfId = arrayOfId.Reverse().ToArray();

    for(int i = 0; i < numbers.Length; i++)
    {
        if (arrayOfId[i] == numbers[i])
        {
            count++;
        }
    }

    if (count == lastNumbersOfFakeIds.Length)
    {
        Console.WriteLine(currentCitizen.Id);
    }
}

foreach (Robot currentRobot in robots)
{
    int count = 0;
    char[] numbers = lastNumbersOfFakeIds.ToCharArray();
    char[] arrayOfId = currentRobot.Id.ToCharArray();
    numbers = numbers.Reverse().ToArray();
    arrayOfId = arrayOfId.Reverse().ToArray();

    for (int i = 0; i < numbers.Length; i++)
    {
        if (arrayOfId[i] == numbers[i])
        {
            count++;
        }
    }

    if (count == lastNumbersOfFakeIds.Length)
    {
        Console.WriteLine(currentRobot.Id);
    }
}