using MordorCrue_Plan.Factories;
using MordorCrue_Plan.Foods;
using MordorCrue_Plan.Moods;
using System;

namespace MordorCrue_Plan.Core
{
    public class Engine
    {
        private FoodFactory foodFactory;
        private MoodFactory moodFactory;

        public Engine()
        {
            this.foodFactory = new FoodFactory();
            this.moodFactory = new MoodFactory();
        }

        public void Run()
        {
            int points = 0;
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                string type = input[i];
                Food currentFood = foodFactory.CreateFood(type);

                points += currentFood.Hapiness;
            }

            Mood mood=new Mood();
            if (points < -5)
            {
                mood = moodFactory.CreateMood("angry");
            }
            else if (points >= -5 && points <= 0) 
            {
                mood = moodFactory.CreateMood("sad");
            }
            else if (points >= 1 && points <= 15)
            {
                mood = moodFactory.CreateMood("happy");
            }
            else if (points > 15)
            {
                mood = moodFactory.CreateMood("javascript");
            }

            Console.WriteLine(points);
            Console.WriteLine(mood.Name);

        }
    }
}
