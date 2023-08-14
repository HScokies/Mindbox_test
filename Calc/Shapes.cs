using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public abstract class Shape
    {
        protected double? area = null;
        protected double? perimeter = null;
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }

    public class Triangle : Shape
    {
        public readonly double sideA;
        public readonly double sideB;
        public readonly double sideC;
        public readonly bool isRight;
        public Triangle(double Hypotenuse, double Opposite, double Base)
        {
            sideA = Hypotenuse;
            sideB = Opposite;
            sideC = Base;
            isRight = checkIfRight();
        }

        private bool checkIfRight()
        {
            if (sideA == 0 || sideB == 0 || sideC == 0) return false;
            if (sideA * sideA + sideB * sideB == sideC * sideC)
            {
                setRightTriangleArea(sideA, sideB);
                return true;
            }
            if (sideB * sideB + sideC * sideC == sideA * sideA)
            {
                setRightTriangleArea(sideB, sideC);
                return true;
            }
            if (sideC * sideC + sideA * sideA == sideB * sideB)
            {
                setRightTriangleArea(sideA, sideC);
                return true;
            }
            return false;
        }
        private void setRightTriangleArea(double Base, double Opposite) => area = (Base * Opposite) / 2;

        public override double GetArea()
        {
            if (area is not null) return (double)area;

            double halfPerimeter = GetPerimeter() / 2;
            area = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
            return (double)area;
        }

        public override double GetPerimeter()
        {
            if (perimeter is not null) return (double)perimeter;

            perimeter = sideA + sideB + sideC;
            return (double)perimeter;
        }
    }

    public class Circle : Shape
    {
        public readonly double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * (radius * radius);
        }

        public override double GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
