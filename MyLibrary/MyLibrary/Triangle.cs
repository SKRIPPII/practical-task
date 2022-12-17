using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Triangle:Form
    {
        readonly double[] Sides;
        public Triangle(double a,double b,double c):base(Math.Sqrt( GetHalfThePerimeter(a,b,c) * ( GetHalfThePerimeter(a, b, c) - a) * (GetHalfThePerimeter(a, b, c) - b) * (GetHalfThePerimeter(a, b, c) - c))) 
        {
            if (a <= 0 || b <= 0 || c <= 0) throw new ArgumentException("the sides of the triangle are not positive");
            else if (a + b <= c || a + c <= b || b + c <= a) throw new ArgumentException("the figure is not a triangle");
            Sides = new double[] { a,b,c};
        }
        static double GetHalfThePerimeter(double a, double b, double c) => (a + b + c) / 2;
        public bool IsRectangular() 
        { if(Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2) == Math.Pow(Sides[2], 2) || 
                Math.Pow(Sides[0], 2) + Math.Pow(Sides[2], 2) == Math.Pow(Sides[1], 2) || 
                Math.Pow(Sides[2], 2) + Math.Pow(Sides[1], 2) == Math.Pow(Sides[0], 2)) return true; 
        return false;
        }
    }
}
