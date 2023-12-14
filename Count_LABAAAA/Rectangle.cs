using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_LABAAAA
{
    public class Rectangle
    {
        private double lenght;
        private double width;
        public double Length { get { return lenght; } set { lenght = value; } }
        public double Width { get { return width; } set { width = value; } }

       
        public double GetArea()
        {
            return Length * Width;
        }

        public double GetPerimeter()
        {
            return 2 * (Length + Width);
        }
    }

}

