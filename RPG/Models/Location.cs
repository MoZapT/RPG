using RPG.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Models
{
    internal class Location : ILocation
    {
        public IEnumerable<ITransitionNode> Transitions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int HealthMax { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int HealthCrt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal SpeedMax { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal SpeedCrt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int FireResistance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int WaterResistance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int AirResistance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int EarthResistance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int RadiationResistance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int BluntResistance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int PiercingResistance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SlashingResistance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Spotability { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsImmortal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsAlive => throw new NotImplementedException();
    }
}
