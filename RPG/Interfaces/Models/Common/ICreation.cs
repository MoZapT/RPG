using RPG.Models.Memories;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Interfaces.Models.Common
{
    internal interface ICreation
    {
        public Guid Id { get; set; }
        public decimal Age { get; set; }

        //Characteristics
        public int HealthMax { get; set; }
        public int HealthCrt { get; set; }
        public decimal Weight { get; set; }
        public decimal SpeedMax { get; set; }
        public decimal SpeedCrt { get; set; }
        public decimal Height { get; set; }

        //Resistances
        public int FireResistance { get; set; }
        public int WaterResistance { get; set; }
        public int AirResistance { get; set; }
        public int EarthResistance { get; set; }
        public int RadiationResistance { get; set; }
        public int BluntResistance { get; set; }
        public int PiercingResistance { get; set; }
        public int SlashingResistance { get; set; }

        public int Spotability {  get; set; }

        public bool IsImmortal { get; set; }
        public bool IsAlive { get; }

        public ILocation? Location { get; set; }
    }
}
