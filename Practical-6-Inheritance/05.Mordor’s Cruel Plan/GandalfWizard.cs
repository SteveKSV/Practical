using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Mordor_s_Cruel_Plan
{
    public class GandalfWizard : Mood
    {
        public GandalfWizard(int mood = 0)
        {
            this.MoodCount = mood;
        }

        private string MoodType()
        {
            if (this.MoodCount < -5)
            {
                return "Angry";
            }
            if (this.MoodCount >= -5 && this.MoodCount < 0)
            {
                return "Sad";
            }
            if (this.MoodCount >= 0 && this.MoodCount <= 15)
            {
                return "Happy";
            }

            else return "JavaScript";
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append(this.MoodCount)
                .Append(Environment.NewLine)
                .Append(this.MoodType());

            return builder.ToString();
        }
    }
}
