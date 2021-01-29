using System;

namespace TriangleDemo
{
    public class Triangle
    {
        private int side1;
        private int side2;
        private int side3;
        private int baseVal;
        private int h;

        public Triangle(int a ,int b, int c,int basevalue,int height)
        {
            side1 = a;
            side2 = b;
            side3 = c;
            baseVal = basevalue;
            h = height;
        }

        public void CalculatePerimeter()
        {
            var results = side1 + side2 + side3;
            Console.WriteLine($"Perimeter of triangle {results}");
        }

        public void CalculateArea()
        {
            var area = (baseVal * h) / 2;
            Console.WriteLine($"Area of triangle {area}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle(2,4,7,5,2);
            triangle.CalculatePerimeter();
            triangle.CalculateArea();
        }
    }
}
