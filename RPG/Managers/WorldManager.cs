using RPG.Models;
using RPG.Models.Lifeforms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Managers
{
    public class WorldManager
    {
        public static WorldModel CreateWorld()
        {
            WorldModel world = new();

            return world;
        }
    }
}
