using MordorCrue_Plan.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace MordorCrue_Plan.Factories
{
    public class FoodFactory
    {

        public Food CreateFood(string type)
        {
            type = type.ToLower();

            switch (type)
            {
                case "apple":return new Apple();
                case "cram":return new Cram();
                case "lembas":return new Lembas();
                case "melon": return new Melon();
                case "honeycake": return new HoneyCake();
                case "mushrooms": return new Mushrooms();
 
                default:
                case "junk": return new Junk();
            }
        }
    }
}
