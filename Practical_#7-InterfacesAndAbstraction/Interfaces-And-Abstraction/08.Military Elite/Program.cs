using _08.Military_Elite.Classes;
using _08.Military_Elite.Interfaces;
using System.Runtime.ExceptionServices;

string inputString = Console.ReadLine();
List<Soldier> soldiers = new List<Soldier>();
List<string> privateIds = new List<string>();

while (inputString != "End")
{
    string[] inputArray = inputString.Split(" ");

    if (inputArray[0] == "Private")
    {
        Private soldierPrivate = new Private(inputArray[1], inputArray[2], inputArray[3], double.Parse(inputArray[4]));
        soldiers.Add(soldierPrivate);
    }

    if (inputArray[0] == "LeutenantGeneral")
    {
        LeutenantGeneral leutenantGeneral = new LeutenantGeneral(inputArray[1], inputArray[2], inputArray[3], double.Parse(inputArray[4]));

        for (int i = 5; i < inputArray.Length; i++)
        {
            privateIds.Add(inputArray[i]);
        }

        foreach (var currentSoldier in soldiers)
        {
            for (int i = 0; i < privateIds.Count(); i++)
            {
                if (privateIds[i] == currentSoldier.Id)
                {
                    List<IPrivate> correctIdPrivateList = new List<IPrivate>();
                    correctIdPrivateList.Add((IPrivate)currentSoldier);
                    IPrivate element = null;
                    for (int j = 0; j < correctIdPrivateList.Count(); j++)
                    {
                        element = correctIdPrivateList[j];
                        leutenantGeneral.Privates.Add(element);
                    }

                }
            }
        }
        soldiers.Add(leutenantGeneral);
    }

    if (inputArray[0] == "Engineer")
    {
        Engineer engineer = new Engineer(inputArray[1], inputArray[2], inputArray[3], double.Parse(inputArray[4]), inputArray[5]);
        List<string> repairsPartsList = new List<string>();
        List<int> repairsHoursList = new List<int>();

        for (int i = 6; i < inputArray.Length; i++)
        {
            if (i % 2 == 0)
            {
                repairsPartsList.Add(inputArray[i]);
            }
            else if (i % 2 != 0)
            {
                repairsHoursList.Add(int.Parse(inputArray[i]));
            }
        }

        List<Repair> repairs = new List<Repair>();

        for (int i = 0; i < repairsPartsList.Count; i++)
        {
            Repair currentRepair = new Repair(repairsPartsList[i], repairsHoursList[i]);
            repairs.Add(currentRepair);
        }

        foreach (var repair in repairs)
        {
            engineer.Repairs.Add(repair);
        }

        soldiers.Add(engineer);
    }

    if (inputArray[0] == "Commando")
    {
        if (inputArray[5] != "Airforces" && inputArray[5] != "Marines")
        {
            return;
        }

        Commando commando = new Commando(inputArray[1], inputArray[2], inputArray[3], double.Parse(inputArray[4]), inputArray[5]);

        List<string> listOfMissions = new List<string>();
        for (int i = 6; i < inputArray.Length; i++)
        {
            listOfMissions.Add(inputArray[i]);
        }

        var allMissions = new List<IMission>();
        for (int i = 0; i < listOfMissions.Count() - 1; i += 2)
        {
            var code = listOfMissions[i];
            var state = listOfMissions[i + 1];

            if (state != "inProgress" && state != "Finished") continue;

            allMissions.Add(new Mission(code, state));
        }
        foreach (var mission in allMissions)
        {
            commando.Missions.Add(mission);
        }

        soldiers.Add(commando);
    }

    if (inputArray[0] == "Spy")
    {
        soldiers.Add(new Spy(inputArray[1], inputArray[2], inputArray[3], int.Parse(inputArray[4])));
    }

    inputString = Console.ReadLine();
}

foreach (var soldier in soldiers)
{
    Console.WriteLine(soldier);
}