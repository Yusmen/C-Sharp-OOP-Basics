using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Reactangle : Shape
    {

        public double Width { get; set; }
        public double Height { get; set; }

        public Reactangle(double height,double width)
        {
            this.Width = width;
            this.Height = height;
                
        }
        



        public override double CalculateArea()
        {
            return this.Height * this.Width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (this.Height + this.Width);
        }

        public sealed override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
    }
}
