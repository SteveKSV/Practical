using System;
using System.Linq;
using System.Collections.Generic;
namespace Problem_9
{
    public class Rectangle
    {
        public string ID { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public Rectangle(string id, double width, double height, double x, double y)
        {
            this.ID = id;
            this.Width = width;
            this.Height = height;
            this.X = x;
            this.Y = y;
        }

        public string Intersects(Rectangle rectangle)
        {
            if ((rectangle.Y >= this.Y && rectangle.Y - rectangle.Height <= this.Y && rectangle.X <= this.X && rectangle.X + rectangle.Width >= this.X) ||
                (rectangle.Y >= this.Y && rectangle.Y - rectangle.Height <= this.Y && rectangle.X >= this.X && rectangle.X <= this.X + this.Width) ||
                (rectangle.Y <= this.Y && rectangle.Y >= this.Y - this.Height && rectangle.X <= this.X && rectangle.X + rectangle.Width >= this.X) ||
                (rectangle.Y <= this.Y && rectangle.Y >= this.Y - this.Height && rectangle.X >= this.X && rectangle.X <= this.X + this.Width))
            {
                return "true";
            }

            return "false";
        }
    }
    class Program
    {
        static void Main()
        {
            var arrayOfNumbers = Console.ReadLine().Split();
            int n = int.Parse(arrayOfNumbers[0]);
            int m = int.Parse(arrayOfNumbers[1]);

            var rectangles = new Rectangle[n];

            for (int i = 0; i < n; i++)
            {
                var rectangleInfo = Console.ReadLine().Split();
                var id = rectangleInfo[0];
                var width = double.Parse(rectangleInfo[1]);
                var height = double.Parse(rectangleInfo[2]);
                var x = double.Parse(rectangleInfo[3]);
                var y = double.Parse(rectangleInfo[4]);

                rectangles[i] = new Rectangle(id, width, height, x, y);
            }
            for (int i = 0; i < m; i++)
            {
                var idOfRectangles = Console.ReadLine().Split();
                var firstRectangle = rectangles.Where(r => r.ID == idOfRectangles[0]).First();
                var secondRectangle = rectangles.Where(r => r.ID == idOfRectangles[1]).First();

                Console.WriteLine(firstRectangle.Intersects(secondRectangle));
            }
        }
    }
}
