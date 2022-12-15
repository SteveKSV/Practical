using _12.Office_Stuff;
using System.Xml.Linq;

int n = int.Parse(Console.ReadLine());

List<Products> products = new List<Products>();
List<Company> companies = new List<Company>();

for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine();

    var indexOfFirstSlash = input.IndexOf('-');
    var indexOfLastSlash = input.LastIndexOf('-');

    var name = input.Substring(1, indexOfFirstSlash - 1).Trim();
    var amount = int.Parse(input.Substring(indexOfFirstSlash + 2, indexOfLastSlash - indexOfFirstSlash - 2));
    var product = input.Substring(indexOfLastSlash + 2).Trim('|');

    var currentCompany = companies.Where(c => c.Name == name).FirstOrDefault();

    if (currentCompany == null)
    {
        currentCompany = new Company
        {
            Name = name,
            Products = new List<Products>()
        };

        companies.Add(currentCompany);
    }

    var currentProduct = currentCompany.Products.Where(p => p.Name == product).FirstOrDefault();

    if (currentProduct == null)
    {
        currentProduct = new Products
        {
            Name = product,
            Amount = 0
        };

        currentCompany.Products.Add(currentProduct);
    }

    currentProduct.Amount += amount;
}

foreach (var company in companies.OrderBy(c => c.Name))
{
   
    Console.WriteLine($"{company.Name}: {string.Join(", ", company.Products.Select(p => $"{p.Name}-{p.Amount}"))}");
}