using System.Net.NetworkInformation;
using _02.King_s_Gambit;
using _02_King_s_Gambit.Soldiers;

King king = null;
List<Soldier> soldiers = new List<Soldier>();
Run(ref king, ref soldiers);

static void Run(ref King king, ref List<Soldier> soldiers)
{
    BuildKingdom(ref soldiers, ref king);
    ExecuteCommands(ref king, ref soldiers);
}

static void ExecuteCommands(ref King king, ref List<Soldier> soldiers)
{
    var command = Console.ReadLine().Split();
    try
    {
        while (command[0] != "End")
        {

            switch (command[0])
            {
                case "Attack":
                    king.OnUnderAttack();
                    break;
                case "Kill":
                    RemoveDeadSoldier(ref soldiers, command[1], ref king);
                    break;
                default:
                    break;
            }

            command = Console.ReadLine().Split();
        }
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

static void RemoveDeadSoldier(ref List<Soldier> soldiers, string soldierName, ref King king)
{
    for (int i = 0; i < soldiers.Count; i++)
    {
        if (soldiers[i].Name == soldierName)
        {
            king.UnderAttack -= soldiers[i].KingUnderAttack;
            soldiers.Remove(soldiers[i]);
        }
        else if (king.Name == soldierName)
        {
            throw new ArgumentException("King cannot be killed!");
        }
    }
}
static void BuildKingdom(ref List<Soldier> soldiers, ref King king)
{
    var kingName = Console.ReadLine();
    king = new King(kingName);

    var royalGuardNames = Console.ReadLine().Split();
    foreach (var name in royalGuardNames)
    {
        var royalGuard = new RoyalGuard(name);
        soldiers.Add(royalGuard);
        king.UnderAttack += royalGuard.KingUnderAttack;
    }

    var footmanNames = Console.ReadLine().Split();
    foreach (var name in footmanNames)
    {
        var footman = new Footman(name);
        soldiers.Add(footman);
        king.UnderAttack += footman.KingUnderAttack;
    }
}