﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_triangle
{
    class Triangle : IComparable<Triangle>, IFormattable
    {
        private double a;
        private double b;
        private double c;

        public double A { get { return a; } }
        public double B { get { return b; } }
        public double C { get { return c; } }

        public Triangle()
        {
            a = 1.0; b = 1.0; c = 1.0;
        }
        public Triangle(double _a, double _b, double _c)
        {
            if (_a + _b <= _c || _a + _c <= _b || _b + _c <= _a)
            {
                throw new ArgumentException("Triangle with the given sides does not exist.");
            }
            a = _a; b = _b; c = _c;
        }
        public override string ToString()
        {
            return $"a = {a}, b = {b}, c = {c}\nS = {Area()}, P = {Perimeter()}";
        }
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format == null)
                return ToString();

            string formatString = format.ToUpper();
            switch (formatString)
            {
                case "S":
                    return $"S = {Area()} cm^2";
                case "P":
                    return $"P = {Perimeter()} cm";
                case "N":
                    return $"a = {a} cm, b = {b} cm, c = {c} cm\nS = {Area()} cm^2, P = {Perimeter()} cm";
                default:
                    throw new FormatException(String.Format("The {0} format string is not supported.", format));
            }
        }
        public double Perimeter()
        {
            return Math.Round(this.a + this.b + this.c, 2);
        }
        public double Area()
        {
            double half_per = Perimeter() / 2.0;
            return Math.Round(Math.Sqrt(half_per * (half_per - this.a) * (half_per - this.b) * (half_per - this.c)), 2);
        }
        public int CompareTo(Triangle other)
        {
            return Area().CompareTo(other.Area());
        }
        public static bool operator >(Triangle left, Triangle right)
        {
            return left.Area() > right.Area();
        }
        public static bool operator <(Triangle left, Triangle right)
        {
            return left.Area() < right.Area();
        }
        public static Triangle operator *(Triangle left, double n)
        {
            return new Triangle(left.a * n, left.b * n, left.c * n);
        }
        public static Triangle operator +(Triangle left, Triangle right)
        {
            return new Triangle(left.a + right.a, left.b + right.b, left.c + right.c);
        }
        public static Triangle operator -(Triangle left, Triangle right)
        {
            return new Triangle(left.a - right.a, left.b - right.b, left.c - right.c);
        }
    }

    class RightTriangle : Triangle, IFormattable
    {
        private double side;
        public RightTriangle(double side)
            : base(side, side, side)
        {
            this.side = side;
        }
        public double Side { get { return side; } }
        public double RadiusOfInscribedCircle()
        {
            return Math.Round(side * Math.Sqrt(3) / 3.0, 2);
        }
        public double RadiusOfCircumscribedCircle()
        {
            return Math.Round(side * Math.Sqrt(3) / 6.0, 2);
        }
        public override string ToString()
        {
            return base.ToString() + $"\nR = {RadiusOfInscribedCircle()}, r = {RadiusOfCircumscribedCircle()}";
        }
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format == null)
                return base.ToString();

            string formatString = format.ToUpper();
            switch (formatString)
            {
                case "R":
                    return $"R = {RadiusOfInscribedCircle()} cm";
                case "r":
                    return $"r = {RadiusOfCircumscribedCircle()} cm";
                case "N":
                    return base.ToString("N", formatProvider) + $"\nR = {RadiusOfInscribedCircle()} cm, r = {RadiusOfCircumscribedCircle()} cm";
                default:
                    throw new FormatException($"The {format} format string is not supported.");
            }
        }
    }
}
