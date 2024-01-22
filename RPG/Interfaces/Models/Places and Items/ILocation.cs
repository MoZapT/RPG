using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Interfaces.Models.Common;

namespace RPG.Interfaces.Models
{
    internal interface ILocation : ICreation
    {
        //Type -> forest, building, whatever?
        //Owner -> who runs this place?
        //What's in? -> furniture, trees, persons, animals?
        //Description of this place
        public IEnumerable<ITransitionNode> Transitions { get; set; }
    }
}
