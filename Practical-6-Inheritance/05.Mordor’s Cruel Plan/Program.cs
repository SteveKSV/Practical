using _05.Mordor_s_Cruel_Plan;

string input = Console.ReadLine();

var gandalf = new GandalfWizard();

var foods = FoodFactory.ProduceFood(input);
MoodFactory.ChangeMood(gandalf, foods);

Console.WriteLine(gandalf);