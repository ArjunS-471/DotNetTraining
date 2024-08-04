using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class ExerciseUML_Diagram
    {
        public class Shape
        {
            public override string ToString()
            {
                return string.Empty;
            }

            public double Area()
            {
                return double.NaN;
            }

            public double Perimeter()
            {
                return double.NaN;
            }

            public Location location { get; set; }
        }

        public class Rectangle : Shape
        {
            protected double side1;
            protected double side2;
        }

        public class Circle : Shape
        {
            protected double radius;
        }

        public class Location
        {
            private double x;
            private double y;
        }
    
    }
}
