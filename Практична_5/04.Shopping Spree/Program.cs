using _04.Shopping_Spree;


List<Person> people = new List<Person>();
List<Product> products = new List<Product>();

Console.WriteLine("Enter names of people and their money: ");
var personAndMoney = Console.ReadLine().Split(new[] { ';' });

foreach (var currentPerson in personAndMoney)
{
    try
    {
        var personArgs = currentPerson.Split('=');
        var name = personArgs[0];
        var money = int.Parse(personArgs[1]);
        var person = new Person(name, money);
        people.Add(person);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        return;
    }
}

Console.WriteLine("Enter names of procuts and their costs: ");
var productAndCost = Console.ReadLine().Split(new[] { ';' });

foreach (var currentProduct in productAndCost)
{
    try
    {
        var productArgs = currentProduct.Split('=');
        string productName = productArgs[0];
        int productCost = int.Parse(productArgs[1]);
        Product product = new Product(productName, productCost);
        products.Add(product);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        return;
    }
}

var commandLine = Console.ReadLine();

while (!commandLine.Equals("END"))
{
    var purchaseArgs = commandLine.Split(' ');
    Person a = new Person("-", 0);
    Product b = new Product("-", 0);

    var person = a;
    var product = b;
    foreach (var currentPerson in people)
    {
        if (currentPerson.Name == purchaseArgs[0])
        {
            person = currentPerson;
        }
    }
    foreach (var currentProduct in products)
    {
        if (currentProduct.Name == purchaseArgs[1])
        {
            product = currentProduct;
        }
    }

    if (person != null && product != null)
    {
        if (product.Cost <= person.Money)
        {
            person.Products.Add(product);
            person.Money -= product.Cost;

            Console.WriteLine($"{person.Name} bought {product.Name}");
        }
        else
        {
            Console.WriteLine($"{person.Name} can't afford {product.Name}");
        }
    }
    commandLine = Console.ReadLine();
}

foreach (var person in people)
{
    if (!person.Products.Any())
    {
        Console.WriteLine($"{person.Name} - Nothing bought");
        continue;
    }
    foreach(var product in person.Products)
    Console.WriteLine($"{person.Name} - {product.Name}");
}
