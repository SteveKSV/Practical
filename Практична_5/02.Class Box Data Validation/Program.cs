using _02.Class_Box_Data_Validation;
using System.ComponentModel;
using System.Reflection;

try
{
    Console.WriteLine("Enter the length, width and height: ");
    float length = float.Parse(Console.ReadLine());
    float width = float.Parse(Console.ReadLine());
    float height = float.Parse(Console.ReadLine());

    Box box = new Box(length, width, height);

    for (int i = 0; i < 3; i++)
    {
        float result;
        switch (i)
        {
            case 0:
                result = box.SurfaceArea();
                Console.WriteLine($"Surface Area - {result:f2}");
                break;
           case 1:
                result = box.LateralSurfaceArea();
                Console.WriteLine($"Lateral Surface Area - {result:f2}");
                break;
            case 2:
                result = box.Volume();
                Console.WriteLine($"Volume - {result:f2}");
                break;
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}