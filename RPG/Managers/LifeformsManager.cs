using RPG.Models.Lifeforms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Models;

namespace RPG.Managers
{
    public class LifeformsManager
    {
        public const int MAX_LIFEFORMS = 20;
        public const int MIN_LIFEFORMS = MAX_LIFEFORMS / 2;

        public static void SeedLifeforms(WorldModel world)
        {
            //Random rnd = new();
            //int lifeformsCount = rnd.Next(MIN_LIFEFORMS, MAX_LIFEFORMS);
            //Console.WriteLine("Количество форм жизни: " + lifeformsCount);

            //ICollection<IOrganicLifeform> organics = CreateOrganicLifeforms(ref lifeformsCount, lifeformsCount / 2);
            //ICollection<IOrganicLifeform> nonorganics = CreateNonOrganicLifeforms(ref lifeformsCount);

            //Console.WriteLine("Количество органических форм жизни: " + organics.Count);
            //Console.WriteLine("Количество неорганических форм жизни: " + nonorganics.Count);
            //Console.WriteLine("Количество не выданных форм жизни: " + lifeformsCount);
        }
    }
}
