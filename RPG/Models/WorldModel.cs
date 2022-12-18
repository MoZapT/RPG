using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Interfaces.Models.StellarModels;
using RPG.Models.StellarModels;

namespace RPG.Models
{
    public class WorldModel
    {
        public IStarBody Star { get; set; }

        public WorldModel()
        {
            Star = new StarBody();
        }
    }
}
