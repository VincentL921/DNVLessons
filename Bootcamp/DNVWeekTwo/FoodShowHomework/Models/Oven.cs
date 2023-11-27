using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShowHomework.Models
{
    public class Oven : Food
    {
        public void GetCookTime()
        {
            Console.WriteLine(this.CookTimeMin);
        }

        public void SetTimeElapsed()
        {
            Console.WriteLine(this.ElapsedCookTime);
        }

        public void GetTimeRemaining()
        {
            var parsedElapsedTime = int.TryParse(this.ElapsedCookTime, out int goodElapsedTime);
            var timeRemaining = this.CookTimeMin - goodElapsedTime;
            Console.WriteLine(timeRemaining);
        }
    }
}
