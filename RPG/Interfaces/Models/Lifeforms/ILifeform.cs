using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Interfaces.Models.Lifeforms
{
    internal interface ILifeform
    {
        public string Name { get; set; }
        public decimal Age { get; set; }
    }
}
