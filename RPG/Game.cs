using RPG.Factories;
using RPG.Interfaces.Models;
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
        private ILifeform _player;

        public Game()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Инициализация игрового мира!");
            Console.WriteLine(PrintConstants.LINE_DIVIDER);

            _world = WorldManager.CreateWorld();
            _player = HumanFactory.CreateGenericHuman();
            LifeformsManager.SeedLifeforms(_world);

            Console.WriteLine("Инициализация игрового мира завершена!");
            Console.WriteLine(PrintConstants.LINE_DIVIDER);
        }
    }
}
