using Newtonsoft.Json;
using RPG.Models.Lifeforms;
using RPG.Models.Memories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Factories
{
    internal class HumanFactory
    {
        public static Human CreateGenericHuman()
        {
            return new Human()
            {
                Id = Guid.NewGuid(),
                FirstName = string.Empty,
                LastName = string.Empty,
                PatronymName = string.Empty,
                AliasName = string.Empty,
                Age = 0,
                Gender = true,
                Strength = 0,
                Dexterity = 0,
                Endurance = 0,
                Intelligence = 0,
                Charisma = 0,
                Luck = 0,
                Psi = 0,
                Insight = 0,
                Weight = 0,
                Height = 0,
                Fertility = 0,
                SpeedMax = 0,
                SpeedCrt = 0,
                HealthMax = 0,
                HealthCrt = 0,
                ManaMax = 0,
                ManaCrt = 0,
                EnergyMax = 0,
                EnergyCrt = 0,
                StaminaMax = 0,
                StaminaCrt = 0,
                Calories = 0,
                Water = 0,
                Metabolism = 0,
                BloodVolume = 0,
                FireResistance = 0,
                AirResistance = 0,
                WaterResistance = 0,
                EarthResistance = 0,
                RadiationResistance = 0,
                BluntResistance = 0,
                SlashingResistance = 0,
                PiercingResistance = 0,
                Memories = new List<Memory>(),
            };
        }

        public static string GetRandomFirstName(string race, string gender, string culture = "Generic")
        {
            Random rnd = new();

            JsonTextReader reader = new(new StreamReader("Resources/Names.json"));
            string? name = null;

            while (reader.Read())
            {
                if (reader.Value == null || reader.Depth < 4)
                    continue;

                if (rnd.Next(200) >= 100)
                {
                    return reader.Value.ToString() ?? "Test";
                }
            }

            return name ?? "Test";
        }

        public static string GetRandomLastName(string race, string gender, string culture = "Generic")
        {
            Random rnd = new();

            JsonTextReader reader = new(new StreamReader("Resources/Names.json"));
            string? name = null;

            while (reader.Read())
            {
                if (reader.Value == null || reader.Depth < 4)
                    continue;

                if (rnd.Next(200) >= 100)
                {
                    return reader.Value.ToString() ?? "Test";
                }
            }

            return name ?? "Test";
        }
    }
}
