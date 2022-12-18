using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Models
{
    public class TimeModel
    {
        public int Days { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int CurrentDay { get; set; }
        public int CurrentHour { get; set; }
        public int CurrentMinute { get; set; }

        public TimeModel()
        {
            Random rnd = new();

            Days = rnd.Next(100, 600);
            Hours = rnd.Next(10, 40);
            Minutes = rnd.Next(30, 120);
            CurrentDay = rnd.Next(1, Days);
            CurrentHour = rnd.Next(0, Hours-1);
            CurrentMinute = rnd.Next(0, Minutes-1);
        }
    }
}
