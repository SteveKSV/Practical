using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_5
{
    class Box
    {
        float length, width, height;

        public float Length
        {
            get { return length; }
            set { length = value; }
        }
        public float Width
        {
            get { return width; }
            set { width = value; }
        }

        public float Height
        {
            get { return height; }
            set { height = value; }
        }

        public float SurfaceArea(float length, float width, float height)
        {
            return (2 * length * width + 2 * length * height + 2 * width * height);
        }

        public float LateralSurfaceArea(float length, float width, float height)
        {
            return (2 * length * height + 2 * width * height);
        }

        public float Volume(float length, float width, float height)
        {
            return (length * width * height);
        }
    }
}
