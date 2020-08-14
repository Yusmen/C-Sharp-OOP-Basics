using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {

        private string flour;
        private string bakingTechnique;
        private double weight;
        public Dough()
        {
            this.flour = string.Empty;
            this.bakingTechnique = string.Empty;
            this.weight = 0.0;
        }

        public Dough(string flout,string bakingTechnique,double weight)
        {
            this.Flour = flout;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value < 1 || value > 200)
                {
                    Exception exs = new Exception("Dough weight should be in the range [1..200].");
                    Console.WriteLine(exs.Message);
                    Environment.Exit(0);
                }
                weight = value;
            }
        }

        public string BakingTechnique
        {
            get { return bakingTechnique; }
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade") 
                {
                    Exception exs = new Exception("Invalid type of dough.");
                    Console.WriteLine(exs.Message);
                    Environment.Exit(0);
                }
               
                bakingTechnique = value;
            }
        }



        public string Flour
        {
            get { return flour; }
            set

            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    Exception exs = new Exception("Invalid type of dough.");
                    Console.WriteLine(exs.Message);
                    Environment.Exit(0);

                }
                flour = value;
            }
        }

        public double Calories()
        {

            double result = 0;
            if (flour.ToLower() == "white")
            {
                if (bakingTechnique.ToLower() == "crispy")
                {
                    result= 2 * weight * 1.5 * 0.9;
                }
                else if (bakingTechnique.ToLower() == "chewy")
                {
                    result =2 * weight * 1.5 * 1.1;
                }
                else if (bakingTechnique.ToLower() == "homemade")
                {
                    result=2 * weight * 1.5 * 1.0;
                }
            }
            else if (flour.ToLower() == "wholegrain")
            {
                if (bakingTechnique.ToLower() == "crispy")
                {
                    result=2 * weight * 1.0 * 0.9;
                }
                else if (bakingTechnique.ToLower() == "chewy")
                {
                    result=2 * weight * 1.0 * 1.1;
                }
                else if (bakingTechnique.ToLower() == "homemade")
                {
                    result=2 * weight * 1.0 * 1.0;
                }
            }
            return result;


        }



    }
}
