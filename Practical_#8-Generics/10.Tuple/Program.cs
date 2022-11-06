
public class Program
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();
        var name = $"{input[0]} {input[1]}";
        var address = input[2];
        var tuple1 = new Tuple<string, string>(name, address);
        

        input = Console.ReadLine().Split();
        name = input[0];
        var litersOfBeer = int.Parse(input[1]);
        var tuple2 = new Tuple<string, int>(name, litersOfBeer);
       

        input = Console.ReadLine().Split();
        var integer = int.Parse(input[0]);
        var doubleValue = double.Parse(input[1]);
        var tuple3 = new Tuple<int, double>(integer, doubleValue);

        Console.WriteLine($"{tuple1.Item1} -> {tuple1.Item2}");
        Console.WriteLine($"{tuple2.Item1} -> {tuple2.Item2}");
        Console.WriteLine($"{tuple3.Item1} -> {tuple3.Item2}");
    }
}