using System;

namespace OO_Tasks_Interface
{
      public interface IShapeProps
      {
            double GetArea();
            double GetPerimeter();
      }

      public interface ICircleProps
      {
            double GetArea();
            double GetCircumference();
      }

      public class Shape
      {
            private string _name;
            private string _colour;

            public Shape(string name, string colour)
            {

            }

      }

      public class Quadrilateral : Shape
      {
            private int _NumSides = 4;
            public Quadrilateral(string name, string colour) : base(name, colour)
            {

            }
      }

      public class Square : Quadrilateral, IShapeProps
      {
            private double _sideLength;

            public Square(string name, string colour, double sideLength) : base(name, colour)
            {

            }
            public double GetArea()
            {
                  return _sideLength * _sideLength;
            }

            public double GetPerimeter()
            {
                  return 4 * _sideLength;
            }
      }

      public class Rectangle : Quadrilateral, IShapeProps   
      {
            private double _length;
            private double _width;

            public double GetArea()
            {
                  return _length * _width;
            }

            public double GetPerimeter()
            {
                  return 2 * _length + 2 * _width;
            }

            public Rectangle(string name, string colour, double length, double width) : base(name, colour)
            {

            }
      }

      public class Circle : Shape, ICircleProps
      {
            private double _radius;
            public const double PI = 3.142;
            public Circle(string name, string colour, double radius) : base(name, colour)
            {

            }

            public double GetArea()
            {
                  return _radius * _radius * PI;
            }

            public double GetCircumference()
            {
                  return 2 * _radius * PI;
            }

            public double GetPerimeter()
            {
                  throw new NotImplementedException();
            }
      }
}