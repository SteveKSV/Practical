using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Mordor_s_Cruel_Plan.Factories
{
    public class MoodFactory
    {
        public static void ChangeMood(Mood person, List<AbstractFood> foods)
        {
            foreach (var food in foods)
            {
                person.MoodCount += food.Happiness;
            }
        }
    }
}
