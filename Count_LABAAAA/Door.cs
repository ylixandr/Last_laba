using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Count_LABAAAA
{
    public class Door : Rectangle
    {
        private double lenght;
        private double width;
        new public double Length { get { return lenght; } set { lenght = value; } }
        new public double Width { get { return width; } set { width = value; } }
        new public double GetArea()
        {
            return Length * Width;
        }
        public Door(double lenght, double width)
        {
            this.lenght = lenght;
            this.width = width;
        }
    }
}
