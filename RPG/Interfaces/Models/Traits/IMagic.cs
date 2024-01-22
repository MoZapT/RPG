using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Interfaces.Models.Traits
{
    internal interface IMagic
    {
        //Characteristics
        public int ManaMax { get; set; }
        public int ManaCrt { get; set; }
    }
}
