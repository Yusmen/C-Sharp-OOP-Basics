using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBox
{
    public class Box
    {
        private double  length;
        private double width;
        private double height;

        public Box(double l,double w,double h)
        {
            this.length = l;
            this.width = w;
            this.height = h;
        }



        public double Height
        {
            get { return height; }
            set {
                if (value == 0 || value < 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                height = value;
            }
        }


        public double Width
        {
            get { return width; }
            set
            {
                if (value == 0 || value < 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value; }
        }


        public double  Length
        {
            get { return length; }
            set
            {
                if (value == 0 || value < 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                length = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {2*this.length*this.width+2*length*height+2*width*height:f2}");
            sb.AppendLine($"Lateral Surface Area - {2 * length * height + 2 * width * height:f2}");
            sb.AppendLine($"Volume - {length * width * height:f2}");
            return sb.ToString();
        }

    }
}
