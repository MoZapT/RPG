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
            Console.WriteLine("Инициализация игрового мира!");
            Console.WriteLine(PrintConstants.LINE_DIVIDER);

            _world = WorldManager.CreateWorld();
            //_world = LifeformsManager.SeedLifeforms(_world);

            Console.WriteLine("Инициализация игрового мира завершена!");
            Console.WriteLine(PrintConstants.LINE_DIVIDER);
        }
    }
}
