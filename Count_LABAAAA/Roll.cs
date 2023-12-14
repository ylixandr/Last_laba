using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_LABAAAA
{
    public class Roll : Rectangle
    {
        private double pricePerRoll;
        private double lenght;
        private double width;
        public double PricePerRoll { get { return pricePerRoll; } set { pricePerRoll = value; } }
        new public double Length { get { return lenght; } set { lenght = value; } }
        new public double Width { get { return width; } set { width = value; } }
        new public double GetArea()
        {
            return Length * Width;
        }
        public Roll(double length, double width, double pricePerRoll)
        {
            Length = length;
            Width = width;
            this.pricePerRoll= pricePerRoll;
        }
    }
}
