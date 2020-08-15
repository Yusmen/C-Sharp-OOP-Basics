using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        public string Model { get; set; }
        public string Colour { get; set ; }

        public Seat(string model,string colour)
        {
            this.Model = model;
            this.Colour = colour;
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
            st.AppendLine($"{Colour} Seat {Model}");
            st.AppendLine(Start());
            st.Append(Stop());

            return st.ToString();
        }
    }
}
