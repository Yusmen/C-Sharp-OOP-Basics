using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    
    class Car
    {

        private string model;
        private string speed;

        public Car(string model, string speed)

        {
            this.Model = model;
            this.Speed = speed;
        }
                    

        public string Speed
        {
            get { return speed; }
            set { speed = value; }
        }


        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public override string ToString()
        {
            return $"{this.Model} {this.Speed}";
        }



    }
}
