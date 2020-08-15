using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectric
    {
        public int Battery { get ; set; }
        public string Model { get; set; }
        public string Colour { get; set; }

        public Tesla(string model,string colour,int battery)
        {

            this.Model = model;
            this.Colour = colour;
            this.Battery = battery;
                
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine($"{Colour} Tesla {Model} with {Battery} Batteries");
            st.AppendLine(Start());
            st.Append(Stop());

            return st.ToString();
        }
    }
}
