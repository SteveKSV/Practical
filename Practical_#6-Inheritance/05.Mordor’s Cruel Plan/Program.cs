using _05.Mordor_s_Cruel_Plan;
using _05.Mordor_s_Cruel_Plan.Factories;
using _05.Mordor_s_Cruel_Plan.Factories.FoodList;

string input = Console.ReadLine();

var gandalf = new GandalfWizard();

var foods = FoodFactory.ProduceFood(input);
MoodFactory.ChangeMood(gandalf, foods);

Console.WriteLine(gandalf);