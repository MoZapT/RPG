using RPG.Models.Memories;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Interfaces.Models.Traits
{
    internal interface IOrganic
    {
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
        public int EnergyMax { get; set; }
        public int EnergyCrt { get; set; }
        public int StaminaMax { get; set; }
        public int StaminaCrt { get; set; }
        public int Calories { get; set; }
        public int Water { get; set; }
        public decimal Metabolism { get; set; }
        public decimal BloodVolume { get; set; }
        public int Fertility { get; set; }
        public bool Gender { get; set; }

        //
        public string Race { get; }

        //
        public IEnumerable<Memory>? Memories { get; set; }
        //public IEnumerable<Trait> Traits { get; set; }
        //public IEnumerable<Ability> Abilities { get; set; }
        //public IEnumerable<Perk> Perks { get; set; }
        //public IEnumerable<Tag> Tags { get; set; }
    }
}
