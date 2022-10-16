using _06.Birthday_Celebrations;
using Microsoft.VisualBasic;

string inputString = Console.ReadLine();

List<Citizen> citizens = new List<Citizen>();

List<Robot> robots = new List<Robot>();

List<Pet> pets = new List<Pet>();

while (inputString != "End")
{
    string[] inputArray = inputString.Split();

    if (inputArray.Length == 5)
    {
        citizens.Add(new Citizen(inputArray[1], int.Parse(inputArray[2]), inputArray[3], inputArray[4]));
    }
    else
    {
        if (inputArray[0] == "Robot")
        {
            robots.Add(new Robot(inputArray[0], inputArray[1]));
        } else if (inputArray[0] == "Pet")
        {
            pets.Add(new Pet(inputArray[1], inputArray[2]));
        }
    }

    inputString = Console.ReadLine();
}

string year = Console.ReadLine();

foreach (Citizen currentCitizen in citizens)
{
    var date = currentCitizen.Birthdate.Split("/");
    var currentCitizenYear = date[2];

    if(year == currentCitizenYear)
    {
        Console.WriteLine(currentCitizen.Birthdate);
    }
}

foreach (Pet currentPet in pets)
{
    var date = currentPet.Birthdate.Split("/");
    var currentCitizenYear = date[2];

    if (year == currentCitizenYear)
    {
        Console.WriteLine(currentPet.Birthdate);
    }
}