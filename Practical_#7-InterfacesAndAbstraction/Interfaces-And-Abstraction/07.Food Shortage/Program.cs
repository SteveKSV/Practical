using _07.Food_Shortage.Classes;
using System.Xml;

int N = int.Parse(Console.ReadLine());

string inputString;

List<Citizen> citizens = new List<Citizen>();

List<Rebel> rebels = new List<Rebel>();
int i = 0;
while (i < N)
{
    inputString = Console.ReadLine();
    string[] inputArray = inputString.Split();
    if (inputArray.Length == 4)
    {
        citizens.Add(new Citizen(inputArray[0], int.Parse(inputArray[1]), inputArray[2], inputArray[3]));
    }
    else if (inputArray.Length == 3)
    {
        rebels.Add(new Rebel(inputArray[0], int.Parse(inputArray[1]), inputArray[2]));
    }
    i++;
}


string inputName = Console.ReadLine();
int allFood = 0;

while (inputName != "End")
{
    for (i = 0; i < citizens.Count; i++)
    {
        if (inputName == citizens[i].Name)
        {
            citizens[i].BuyFood();
        }
    }

    for (i = 0; i < rebels.Count; i++)
    {
        if (inputName == rebels[i].Name)
        {
            rebels[i].BuyFood();
        }
    }
    inputName = Console.ReadLine();
}

for (i = 0; i < citizens.Count; i++)
{
    allFood += citizens[i].Food;
}

for (i = 0; i < rebels.Count; i++)
{
    allFood += rebels[i].Food;
}

Console.WriteLine("All food that was purchased: " + allFood);

