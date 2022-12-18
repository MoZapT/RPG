using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Interfaces.Models.StellarModels
{
    public interface IStellarBody
    {
        public Guid Id { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double OrbitLineLength { get; set; }
        public int OrbitLinePosition { get; set; }
        public int PositionOnOrbitLine { get; set; }
        public double OrbitRotationSpeed { get; set; }
        public double EquatorRotationSpeed { get; set; }
        public ICollection<IStellarBody> Bodies { get; set; }

        public double GravityMass { get; set; }
        public double Radius { get; set; }
        public double EquatorLength { get { return (Radius * Radius) * Math.PI; } }
        public double Volume { get { return (Radius * Radius * Radius) * ((4 / 3) * Math.PI); } }
        public double SurfaceSize { get { return (Radius * Radius) * (4 * Math.PI); } }
    }
}
