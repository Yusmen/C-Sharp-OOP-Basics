using System;
using System.Collections.Generic;
using System.Text;

namespace MordorCrue_Plan.Foods
{
    public abstract class Food
    {

        public int Hapiness { get; }

        public Food(int hapiness)
        {
            this.Hapiness = hapiness;
        }
    }
}
