using _05.Pizza_Calories;

Pizza pizza = new Pizza();

var dough = new Dough();

var toppings = new List<Topping>();

var inputLine = Console.ReadLine();

var countOfToppings = 0;

var inputToken = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

while (!inputLine.Equals("END"))
{
    if (inputLine.Contains("Dough"))
    {
        var doughInfo = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var type = doughInfo[1];
        var tech = doughInfo[2];
        var weight = double.Parse(doughInfo[3]);

        try
        {
            dough = new Dough(type, tech, weight);
            Console.WriteLine($"{dough.CalcCalories():f2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
    }
    else if (inputLine.Contains("Topping"))
    {
        var toppingInfo = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var toppingName = toppingInfo[1];
        var toppingWeight = double.Parse(toppingInfo[2]);

        try
        {
            var topping = new Topping(toppingName, toppingWeight, toppings);
            toppings.Add(topping);
            Console.WriteLine($"{topping.CalcCalories():f2}");
            countOfToppings++;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }
    }

    if (inputToken[0].Equals("Pizza") || inputLine.Equals("Topping Cheese 50"))
    {
        var name = inputToken[1];
    
        try
        {
            pizza = new Pizza(name, countOfToppings);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }
    }
    
    inputLine = Console.ReadLine();
}

Console.WriteLine($"{pizza.Name} – {pizza.CalcCalories(toppings, dough):f2} Calories.");