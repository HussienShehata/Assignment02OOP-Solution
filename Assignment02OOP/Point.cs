using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02OOP
{
    internal struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }


        public Point(double x,double y)
        {
            X = x;  
            Y = y;  
        }
        
        public override string ToString()
        {
            return $"the points are {X} & {Y} ";
        }
    }


}
