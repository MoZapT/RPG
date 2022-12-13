using Newtonsoft.Json;
using RPG.Interfaces.Models.Lifeforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Models.Lifeforms
{
    internal class Lifeform : ILifeform
    {
        public string Name { get; set; }
        public decimal Age { get; set; }

        public override string ToString()
        {
            return "NAME: " + Name + ", AGE: " + Age;
        }

        protected void GetRandomName(string race, string gender, string culture = "Generic")
        {
            Random rnd = new();

            JsonTextReader reader = new(new StreamReader("Resources/Names.json"));

            while (reader.Read())
            {
                if (reader.Value == null || reader.Depth < 4)
                    continue;

                if (rnd.Next(200) >= 100)
                {
                    Name = reader.Value.ToString() ?? "Test";
                    return;
                }
            }

            Name ??= "Test";
        }
    }
}
