﻿using MordorCrue_Plan.Moods;
using System;
using System.Collections.Generic;
using System.Text;

namespace MordorCrue_Plan.Factories
{
    public class MoodFactory
    {


        public Mood CreateMood(string type)
        {
            type = type.ToLower();

            switch (type)
            {
                case "angry":return new Angry();
                case "sad":return new Sad();
                case "happy":return new Happy();
                case "javascript":return new JavaScript();
                default:
                    throw new Exception("Invalid type!");
            }
        }
    }
}
