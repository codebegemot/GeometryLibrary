using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class Triangle : IShape
    {
        private double A;
        private double B;
        private double C;
        public Triangle(double A, double B, double C) 
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public double CalculateArea()
        {
            double semiPerimeter = (A + B + C) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));
        }

        public bool IsRightTriangle()
        {
            double[] sides = { A, B, C };
            Array.Sort(sides);

            double aSquare = sides[0] * sides[0];
            double bSquare = sides[1] * sides[1];
            double cSquare = sides[2] * sides[2];

            return Math.Abs(cSquare - (aSquare + bSquare)) < double.Epsilon;
        }
    }
}
