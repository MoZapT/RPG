using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Models
{
    public class WorldModel
    {
        public const int MAX_LIFEFORMS = 20;
        public const int MIN_LIFEFORMS = MAX_LIFEFORMS / 2;

        public TimeModel TimeModel { get; set; }
        public decimal MaxTemperature { get; set; }
        public decimal MinTemperature { get; set; }
        public int Size { get; set; }
        public decimal LandSize { get; set; }
        public decimal WaterSize { get; set; }
        public int Moons { get; set; }

        public WorldModel()
        {
            Random rnd = new();

            TimeModel = new TimeModel();

            MaxTemperature = rnd.Next(80);
            MinTemperature = rnd.Next(-80);
            Size = rnd.Next(100);
            LandSize = rnd.Next(100);
            WaterSize = rnd.Next(100);
            Moons = rnd.Next(10);
        }
    }
}
