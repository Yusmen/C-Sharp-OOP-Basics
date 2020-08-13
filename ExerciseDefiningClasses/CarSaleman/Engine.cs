using System;
using System.Collections.Generic;
using System.Text;

namespace CarSaleman
{
    public class Engine
    {

        private string model;
        private string power;
        private string displacement;
        private string efficiency;
        public Engine()
        {
                
        }


        public Engine(string model, string power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = "n/a";
            this.Efficiency = "n/a";

        }

        public string Efficiency
        {
            get { return efficiency; }
            set { efficiency = value; }
        }


        public string Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }


        public string Power
        {
            get { return power; }
            set { power = value; }
        }


        public string Model
        {
            get { return model; }
            set { model = value; }
        }



    }
}
