using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Circle:Form
    {
        public Circle(double radius):base(Math.PI * Math.Pow(radius,2)) { if (radius <= 0.0) throw new ArgumentException("The radius of the circle is not positive"); }
    }
}
