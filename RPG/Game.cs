using RPG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Managers
{
    internal class Game
    {
        private readonly WorldModel _world;

        public Game()
        {
            _world = WorldManager.CreateWorld();
        }
    }
}
