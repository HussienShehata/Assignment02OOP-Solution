using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02OOP
{
    internal class Rectangle
    {
        #region attributes


        private double height;
        private double width;
        private double area;
        #endregion


        #region properties

        public double Height
        {
            get
            {
             return height;
            }

            set
            {
                if(value >0)
                {
                    height = value;
                }
                else
                    Console.WriteLine("Height can't be negative");
            }
            
        }

      

        public double Width
        {
            get { return width; }
            set 
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                    Console.WriteLine("Width cannot be negative");
            }
        }


        public double Area 
        { 
            get
            {
                return area = height*width ; 
            
            } 
        }


        #endregion


        #region Constructor


        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public Rectangle()
        {
        }


        #endregion

        #region Methods
        

        public void DisplayInfo()
        {
            //double height = Height;
            //double width= Width;
            //double  area = Area;
            Console.WriteLine($"Height is {Height}, width is {Width} and area is {Area}");

        }

        #endregion

        public override string ToString()
        {
            return $"Dimensions of the rectangle are height : {height} and width : {width}";
        }
    }
}
