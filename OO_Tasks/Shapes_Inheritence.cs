using System;

namespace OO_Tasks_Inheritence
{
      public abstract class Shape
      {
            private string _name;
            private string _colour;

            public abstract double GetArea();
            public abstract double GetPerimeter();

            public Shape(string colour, string name)
            {

            }
      }

      public abstract class Quadrilateral : Shape
      {
            private int _NumSides = 4;

            public Quadrilateral(string colour, string name) : base(colour, name)
            {
                 
            }
      }

      public class Square : Quadrilateral
      {
            private double _sideLength;

            public Square(string colour, string name, double sideLength) : base(colour, name)
            {

            }
            public override double GetArea()
            {
                  return _sideLength * _sideLength;
            }

            public override double GetPerimeter()
            {
                  return 4 * _sideLength;
            }
      }

      public class Rectangle : Quadrilateral
      {
            private double _length;
            private double _width;

            public Rectangle(string colour, string name, double Length, double Width) : base(colour, name)
            {

            }
            public override double GetArea()
            {
                  return _length * _width;
            }

            public override double GetPerimeter()
            {
                  return 2 * _length + 2 * _width;
            }
      }

      public class Circle : Shape
      {
            public const double PI = 3.142;
            private double _radius;

            public Circle(string colour, string name, double radius) : base(colour, name)
            {

            }

            public override double GetArea()
            {
                  return _radius * _radius * PI;

            }

            public override double GetPerimeter()
            {
                  return 2 * _radius * PI;
            }

            public double GetCircumference()
            {
                  throw new NotImplementedException();
            }
      }


}