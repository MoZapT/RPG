using Newtonsoft.Json;
using RPG.Interfaces.Models.Lifeforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Models.Lifeforms
{
    internal class Human : Lifeform, IHumanoid
    {
        public Human()
        {
            Random rnd = new();

            GetRandomName();
            Age = rnd.Next(15, 65);
        }
    }
}
