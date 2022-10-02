using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Class_Box_Data_Validation
{
    class Box
    {
        private float length;
        private float width;
        private float height;

        public Box(float length, float width, float height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public float Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Length cannot be zero or negative.");
                }

                this.length = value;
            }
        }

        public float Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Width cannot be zero or negative.");
                }

                this.width = value;
            }
        }

        public float Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Height cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        public float SurfaceArea()
        {
            return (2 * length * width + 2 * length * height + 2 * width * height);
        }

        public float LateralSurfaceArea()
        {
            return (2 * length * height + 2 * width * height);
        }

        public float Volume()
        {
            return (length * width * height);
        }
    }
}
