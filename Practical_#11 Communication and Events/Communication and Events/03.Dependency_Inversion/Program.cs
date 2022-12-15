using System;

namespace Dependency_Inversion
{
    class Program
    {
        static void Main()
        {
            var calculator = new Primitive_Calculator();
            var engine = new Engine(calculator);
            
            engine.Operation += Display;

            engine.Run();
        }

        static void Display(int res)
        {
            Console.WriteLine(res);
        }
    }
}
