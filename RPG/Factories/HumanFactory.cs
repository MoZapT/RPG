using Newtonsoft.Json;
using RPG.Models.Species;
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
            Random rnd = new();
            bool gender = rnd.Next(0, 1) != 0;

            Human human = new()
            {
                Id = Guid.NewGuid(),
                Age = rnd.Next(18, 30),
                Gender = gender,

                FirstName = HumanFactory.GetRandomFirstName("Human", gender),
                LastName = HumanFactory.GetRandomLastName("Human", gender),
                PatronymName = string.Empty,
                AliasName = string.Empty,

                Strength = 3,
                Dexterity = 3,
                Endurance = 3,
                Intelligence = 3,
                Charisma = 3,
                Luck = 3,
                Psi = 3,
                Insight = 3,

                Culture = string.Empty,
                Religion = string.Empty,
                Weight = 70.0m,
                Height = 170.0m,
                Fertility = 4,
                SpeedMax = 0.0m,
                SpeedCrt = 0.0m,

                HealthMax = 35,
                HealthCrt = 35,
                ManaMax = 0,
                ManaCrt = 0,
                EnergyMax = 100,
                EnergyCrt = 100,
                StaminaMax = 30,
                StaminaCrt = 30,
                Calories = 1000,
                Water = 500,
                Metabolism = 2.5m,
                BloodVolume = 5.5m,

                FireResistance = 2,
                AirResistance = 2,
                WaterResistance = 3,
                EarthResistance = 2,
                RadiationResistance = 1,
                BluntResistance = 2,
                SlashingResistance = 1,
                PiercingResistance = 1,

                Spotability = 10,

                IsImmortal = false,
                IsAlive = true,

                Memories = new List<Memory>(),
            };

            return human;
        }

        public static string GetRandomFirstName(string race, bool gender, string culture = "Generic", string religion = "Generic")
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

        public static string GetRandomLastName(string race, bool gender, string culture = "Generic", string religion = "Generic")
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
