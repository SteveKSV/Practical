using Practical_5;

Box box = new Box();

Console.WriteLine("Enter the length, width and height: ");

for (int i = 0; i < 3; i++)
{
    float n = float.Parse(Console.ReadLine());
    switch (i)
    {
        case 0: box.Length = n; break;
        case 1: box.Width = n; break;
        case 2: box.Height = n; break;
    }
}

for (int i = 0; i < 3; i++)
{
    float result;
    switch (i)
    {
        case 0:
            result = box.SurfaceArea(box.Length, box.Width, box.Height);
            Console.WriteLine($"Surface Area - {result:f2}"); break;
        case 1:
            result = box.LateralSurfaceArea(box.Length, box.Width, box.Height);
            Console.WriteLine($"Lateral Surface Area - {result:f2}"); break;
        case 2:
            result = box.Volume(box.Length, box.Width, box.Height);
            Console.WriteLine($"Volume - {result:f2}"); break;
    }
}