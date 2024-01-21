using RPG.Models.Memories;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Interfaces.Models
{
    internal interface ILifeform
    {
        public Guid Id { get; set; }

        //Main characteristics
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PatronymName { get; set; }
        public string? AliasName { get; set; }
        public decimal Age { get; set; }

        //Main attributes
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Endurance { get; set; }
        public int Intelligence { get; set; }
        public int Charisma { get; set; }
        public int Luck { get; set; }
        public int Psi { get; set; }
        public int Insight { get; set; }

        //Characteristics
        public int HealthMax { get; set; }
        public int HealthCrt { get; set; }
        public int ManaMax { get; set; }
        public int ManaCrt { get; set; }
        public int EnergyMax { get; set; }
        public int EnergyCrt { get; set; }
        public int StaminaMax { get; set; }
        public int StaminaCrt { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public decimal SpeedMax { get; set; }
        public decimal SpeedCrt { get; set; }

        //Resistances
        public int FireResistance { get; set; }
        public int WaterResistance { get; set; }
        public int AirResistance { get; set; }
        public int EarthResistance { get; set; }
        public int RadiationResistance { get; set; }
        public int BluntResistance { get; set; }
        public int PiercingResistance { get; set; }
        public int SlashingResistance { get; set; }

        public int Calories { get; set; }
        public int Water { get; set; }
        public decimal Metabolism { get; set; }
        public decimal BloodVolume { get; set; }
        public int Fertility { get; set; }
        public bool Gender { get; set; }

        //
        public string? Culture { get; set; }
        public string Race { get; }
        public string? Religion { get; set; }

        //
        public IEnumerable<Memory>? Memories { get; set; }
        //public IEnumerable<Trait> Traits { get; set; }
        //public IEnumerable<Ability> Abilities { get; set; }
        //public IEnumerable<Perk> Perks { get; set; }
        //public IEnumerable<Tag> Tags { get; set; }
    }
}
